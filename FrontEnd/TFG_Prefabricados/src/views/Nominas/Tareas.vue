<template class="Tarea">
    <div class=" row ml-5 mr-5 mb-7">          
      <v-card class="col-sm-12" elevation="5">    
        <v-card-title class="headline">Tareas</v-card-title>   
        <v-divider></v-divider>        
        <div class="row">
          <div class="col-sm-12">
            <v-card-title>
              <!-- botón añadir empleado -->
              <v-btn tile outlined color="primary" @click="anyadirTarea">
                <v-icon left>mdi-plus</v-icon> Crear Tarea
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
      <v-dialog v-model="showModal" width="800px">
        <template >
        </template>
        <v-card>
          <v-card-title>
            <span class="headline">Tarea</span>
          </v-card-title>
          <v-card-text>
            <addEditTarea v-model="model" :isEditMode="isEditMode"></addEditTarea>
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
import addEditTarea from '@/components/Nominas/Tareas/AddEditTarea.vue';
import axios from "axios";

export default {
    name: 'Tarea',    
    components: {
      addEditTarea,
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
          descripcion: null,
          precio: null,          
        },        

        search: '',
        headers: [
          { text: 'Codigo', value: 'idTrabajo' },
          { text: 'Nombre Tarea', value: 'nombre' },
          { text: 'Descripcion Tarea', value: 'descripcion' },
          { text: 'Precio/Par', value: 'precio' }, 
          { text: 'opciones', value: 'opciones' },       
        ],
        
        rows: [],
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
        axios.delete('https://localhost:44379/api/Trabajos/' + row.idTrabajo)
          .then(response => {
            this.loadItems();
                this.textToastr = "Tarea borrada satisfactoriamente" 
                this.showToastr = true;                
          });
      },

      loadItems (){
        axios.get('https://localhost:44379/api/Trabajos')
          .then(response => {
            if(response.data)
              this.rows = response.data;
          });
      },

      edit (event, row){
        if(event){
          event.stopPropagation();          
        }
        this.showModal = true;
        this.isEditMode = true;
        
        this.model.codigo = row.idTrabajo;
        this.model.nombre = row.nombre;
        this.model.descripcion = row.descripcion;
        this.model.precio = row.precio;
      },

      rowClick (row){
        this.edit(null, row);          
      },

      anyadirTarea (){
        this.isEditMode = false;
        this.showModal = true;
      },

      resetModel (){
        this.model.nombre = null;
        this.model.descripcion = null;
        this.model.precio = null;        
      },

      cancelarButtonClick (){   
        this.showModal = false;
        this.resetModel();
      },

      guardarButtonClick (){
        
        let datosEnviar = {
            nombre: this.model.nombre,
            descripcion: this.model.descripcion,
            precio: parseInt(this.model.precio),
          }      

        if(!this.isEditMode){          
          axios.post('https://localhost:44379/api/Trabajos', datosEnviar)
          .then(response => {
            if(response.data)
              this.loadItems();
              this.textToastr = "Tarea creada satisfactoriamente" 
              this.showToastr = true;
              this.showModal = false;       
          });                   
        }
        else{
          datosEnviar.idTrabajo = this.model.codigo;
          axios.put('https://localhost:44379/api/Trabajos', datosEnviar)
          .then(response => {
            if(response.data)
              this.loadItems();
              this.textToastr = "Tarea modificada satisfactoriamente";
              this.showToastr = true; 
              this.showModal = false;      
          });                                                     
        }                
      }
    }       
  };
</script>


