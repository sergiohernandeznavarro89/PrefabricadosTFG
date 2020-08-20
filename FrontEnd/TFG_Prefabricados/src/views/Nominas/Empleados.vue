<template class="Empleado">
    <div class=" row ml-5 mr-5 mb-7">          
      <v-card class="col-sm-12" elevation="5">    
        <v-card-title class="headline">Empleados</v-card-title>   
        <v-divider></v-divider>        
        <div class="row">
          <div class="col-sm-12">
            <v-card-title>
              <!-- botón añadir empleado -->
              <v-btn tile outlined color="primary" @click="anyadirEmpleado">
                <v-icon left>mdi-plus</v-icon> Crear Empleado
              </v-btn>   
              <!-- -----------------------  -->
              <v-spacer></v-spacer>
              <!-- buscador tabla -->
              <v-text-field v-model="search" append-icon="mdi-magnify" label="Search" single-line hide-details></v-text-field>
              <!-- -------------- -->
            </v-card-title>
            <!-- tabla -->
            <v-data-table :headers="headers" :items="rows" :search="search" @click:row="rowClick">
              <template v-slot:[`item.opciones`]="row">
                <v-btn icon color="primary" @click="edit($event, row.item)">
                  <v-icon>mdi-table-edit</v-icon>
                </v-btn> 
                <v-btn icon color="primary" @click="remove($event, row.item)">
                  <v-icon>mdi-delete</v-icon>
                </v-btn>                        
              </template>
            </v-data-table>
            <!-- ----------------- -->
          </div>
        </div>

        <!-- toastr -->
        <v-snackbar v-model="showToastr" color="success" :timeout='toastrTimeOut' top='top' vertical='vertical'>
          {{ textToastr }}          
        </v-snackbar>
        <!-- --------------------- -->
      </v-card>

      <!-- modal addEdit -->
      <v-dialog v-model="showModal" width="1500px">
        <template >
        </template>
        <v-card>
          <v-card-title>
            <span class="headline">Empleado</span>
          </v-card-title>
          <v-card-text>
            <addEditEmpleado v-model="model" :isEditMode="isEditMode"></addEditEmpleado>
          </v-card-text>
          <v-card-actions>
            <v-spacer></v-spacer>
            <v-btn color="red darken-1" text @click="cancelarButtonClick">Cancelar</v-btn>
            <v-btn color="success darken-1" text @click="guardarButtonClick">Guardar</v-btn>
          </v-card-actions>
        </v-card>
      </v-dialog>
      <!-- ------------------------- -->


    </div>    
</template> 

<script>
import addEditEmpleado from '@/components/Nominas/Empleados/AddEditEmpleado.vue';
import axios from "axios";

export default {
    name: 'Empleado',    
    components: {
      addEditEmpleado,
    },         
    data() {
      return {   
        toastrTimeOut: 6000, 
        textToastr: null,
        showToastr: false,

        showModal: false,
        isEditMode: false,

        model: {
          codigo: null,
          nombre: null,
          apellidos: null,
          nif: null,
          email: null,
          poblacion: null,
          provincia: null,          
          codPostal: null,
          direccion: null,
          telefono: null,
          iban: null
        },        

        search: '',
        headers: [
          { text: 'Codigo', value: 'idEmpleado' },
          { text: 'Nombre', value: 'nombre' },
          { text: 'Apellidos', value: 'apellidos' },
          { text: 'DNI', value: 'nif' },
          { text: 'Email', value: 'email' },
          { text: 'Poblacion', value: 'poblacion' },
          { text: 'Provincia', value: 'provincia' },
          { text: 'Cod. Postal', value: 'codPostal' },
          { text: 'Dirección', value: 'direccion' },
          { text: 'Teléfono', value: 'telefono' },
          { text: 'IBAN', value: 'iban' },
          { text: 'opciones', value: 'opciones' },

        ],
        
        rows: [ ],
      };
    }, 

    created () {       
      this.loadItems();
    },
    
    methods: {
      remove(event, row ){
        if(event){
          event.stopPropagation();          
        }
        axios.delete('https://localhost:44379/api/Empleados/' + row.idEmpleado)
          .then(response => {
            this.loadItems();
                this.textToastr = "Empleado borrado satisfactoriamente" 
                this.showToastr = true;                
          });
      },

      edit (event, row){
        if(event){
          event.stopPropagation();          
        }
        this.showModal = true;
        this.isEditMode = true;
        
         this.model.codigo = row.idEmpleado;
        this.model.nombre = row.nombre;
        this.model.apellidos = row.apellidos;
        this.model.nif = row.nif;
        this.model.email = row.email;
        this.model.poblacion = row.poblacion;
        this.model.provincia = row.provincia;
        this.model.codPostal = row.codPostal;
        this.model.direccion = row.direccion;
        this.model.telefono = row.telefono;
        this.model.iban = row.iban;
      },

      loadItems (){
        axios.get('https://localhost:44379/api/Empleados')
          .then(response => {
            if(response.data)
              this.rows = response.data;
          });
      },

      rowClick (row){
        this.edit(null, row);
      },

      anyadirEmpleado (){
        this.isEditMode = false;
        this.showModal = true;
      },

      resetModel (){
        this.model.nombre = null;
        this.model.apellidos = null;
        this.model.nif = null;
        this.model.email = null;
        this.model.poblacion = null;
        this.model.provincia = null;
        this.model.codPostal = null;
        this.model.direccion = null;
        this.model.telefono = null;
        this.model.iban = null;
      },

      cancelarButtonClick (){   
        this.showModal = false;
        this.resetModel();
      },

      guardarButtonClick (){        
        let datosEnviar = {
            nombre: this.model.nombre,
            apellidos: this.model.apellidos,
            nif: this.model.nif,
            email: this.model.email,
            poblacion: this.model.poblacion,
            provincia: this.model.provincia,
            codPostal: this.model.codPostal,
            direccion: this.model.direccion,
            telefono: parseInt(this.model.telefono),
            iban: parseInt(this.model.iban)
          }      

        if(!this.isEditMode){          
          axios.post('https://localhost:44379/api/Empleados', datosEnviar)
          .then(response => {
            if(response.data)
              this.loadItems();
                this.textToastr = "Empleado creado satisfactoriamente" 
                this.showToastr = true;
                this.showModal = false;       
          });                   
        }
        else{
          datosEnviar.idEmpleado = this.model.codigo;
          axios.put('https://localhost:44379/api/Empleados', datosEnviar)
          .then(response => {
            if(response.data)
              this.loadItems();
              this.textToastr = "Empleado modificado satisfactoriamente";
              this.showToastr = true; 
              this.showModal = false;      
          });                                                     
        }                
      }
    }       
  };
</script>


