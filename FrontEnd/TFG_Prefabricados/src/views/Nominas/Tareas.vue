<template class="Tarea">
    <div class=" row ml-5 mr-5 mb-7">          
      <v-card class="col-sm-12" elevation="5">    
        <v-card-title class="headline">Tareas</v-card-title>   
        <v-divider></v-divider>        
        <div class="row">
          <div class="col-sm-12">
            <v-card-title>
              <!-- botón añadir empleado -->
              <v-btn tile outlined color="primary" @click="anyadirEmpleado">
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
              <template v-slot:item.opciones="{}">
                <v-btn icon color="primary">
                  <v-icon>mdi-table-edit</v-icon>
                </v-btn> 
                <v-btn icon color="primary">
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
          { text: 'Codigo', value: 'codigo' },
          { text: 'Nombre Tarea', value: 'nombre' },
          { text: 'Descripcion Tarea', value: 'descripcion' },
          { text: 'Precio/Par', value: 'precio' },        
        ],
        
        rows: [
          {
            codigo: 1,
            nombre: 'Numerar palmillas',
            descripcion: 'Poner el número correspondiente a cada palmilla',
            precio: '0,006 €',
          },
          {
            codigo: 2,
            nombre: 'Rebajar talonetas',
            descripcion: 'Rebajar la parte superior de las talonetas',
            precio: '0,006 €',
          },
          {
            codigo: 3,
            nombre: 'Dar cola palmillas',
            descripcion: 'Dar de cola palmillas para posteriormente pegarlas a las talonetas',
            precio: '0,012 €',
          },
          {
           codigo: 4,
            nombre: 'Dar cola talonetas',
            descripcion: 'Dar de cola las talonetas para posteriormente pegarlas a las palmillas',
            precio: '0,012 €',
          },
          {
            codigo: 5,
            nombre: 'Desvirar palmillas',
            descripcion: 'Desvirar las palmillas pegadas para eliminar el sobrante',
            precio: '0,006 €',
          },
          {
            codigo: 6,
            nombre: 'Moldear palmillas',
            descripcion: 'Dar forma a las palmillas para que se adapten al pie',
            precio: '0,018 €',
          },          
          {
            codigo: 7,
            nombre: 'troquelar palmillas',
            descripcion: 'Cortar las palmillas necesarias para el pedido de la plancha del material',
            precio: '0,024 €',
          }, 
          {
            codigo: 8,
            nombre: 'troquelar talonetas',
            descripcion: 'Cortar las taloneas necesarias para el pedido de la plancha del material',
            precio: '0,024 €',
          },              
        ],
      };
    }, 

    methods: {
      rowClick (row){
        this.showModal = true;
        this.isEditMode = true;
        
        this.model.codigo = row.codigo;
        this.model.nombre = row.nombre;
        this.model.descripcion = row.descripcion;
        this.model.precio = row.precio;                
      },

      anyadirEmpleado (){
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
        debugger;
        
        if(!this.isEditMode){
          this.rows.push(
            {            
              codigo: this.rows.length + 1,
              nombre: this.model.nombre,
              descripcion: this.model.descripcion,
              precio: this.model.precio,              
            }          
          );
          this.textToastr = "Tarea creada satisfactoriamente" 
        }
        else{
          debugger;
          this.rows[this.model.codigo - 1].codigo = this.model.codigo;
          this.rows[this.model.codigo - 1].nombre = this.model.nombre;
          this.rows[this.model.codigo - 1].descripcion = this.model.descripcion;
          this.rows[this.model.codigo - 1].precio = this.model.precio;                 
          
          this.textToastr = "Tarea modificada satisfactoriamente";
        }
        this.showModal = false; 
        this.showToastr = true;                
      }
    }       
  };
</script>


