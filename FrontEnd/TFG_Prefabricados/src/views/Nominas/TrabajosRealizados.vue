<template>
    <div class=" row ml-5 mr-5 mb-7">          
      <v-card class="col-sm-12" elevation="5">    
        <v-card-title class="headline">Trabajos Realizados</v-card-title>   
        <v-divider></v-divider>                              
        
        <div class="row mt-5">
            <v-alert text color="info" class="col-sm-6 offset-3">
              <p class="font-weight-bold"> Indica el trabajador para el que deseas incurrir los trabajos realizados para agosto de 2020 </p>  
              <div class="col-sm-12">            
                <v-select :items="empleados" item-text="text" item-value="value" label="Seleccionar Empleado" v-model="model.empleadoSeleccionado" dense></v-select>
              </div>  
            </v-alert>
          </div>
          
          <div v-show="model.empleadoSeleccionado" class="row">
            <div class="col-sm-12 ml-5">
              <v-btn tile outlined color="primary" @click="showModalAgregarTarea = true">
              <v-icon left>mdi-plus</v-icon> Agregar tarea
            </v-btn>
            </div>                
          </div>                                

          <!-- modal agregar tarea -->
          <v-dialog v-model="showModalAgregarTarea" width="400px">
            <template >
            </template>
            <v-card>
              <v-card-title>
                <span class="headline">Agregar tarea</span>
              </v-card-title>
              <v-card-text>
                <div class="row">
                  <div class="col-sm-12">            
                    <v-select :items="tareas" item-text="text" item-value="value" label="Seleccionar Tarea" dense></v-select>
                  </div>                            
                </div>
                
              </v-card-text>
              <v-card-actions>
                <v-spacer></v-spacer>
                <v-btn color="red darken-1" text @click="showModalAgregarTarea = false">Cancelar</v-btn>
                <v-btn color="success darken-1" text @click="showModalAgregarTarea = false">Guardar</v-btn>
              </v-card-actions>
            </v-card>
          </v-dialog>
          <!-- ------------------------- -->
        <div v-show="model.empleadoSeleccionado" class="row">         
          <div class="col-sm-4" v-for="tarea in tareasAgregadas" :key="tarea.value">
            <v-expansion-panels class="mb-6">
              <v-expansion-panel>
                <v-expansion-panel-header class="primary--text" expand-icon="mdi-menu-down">
                  <h3>{{ tarea }}</h3>
                </v-expansion-panel-header>
                <v-expansion-panel-content>
                  <v-card-title>              
                    <!-- buscador tabla -->
                    <v-text-field v-model="search" append-icon="mdi-magnify" label="Search" single-line hide-details></v-text-field>
                    <!-- -------------- -->
                    <v-spacer></v-spacer>
                    <v-btn class="mx-2" fab dark small color="primary" @click.stop="dialog = true">
                      <v-icon dark>mdi-plus</v-icon>
                    </v-btn>
                    
                    <!-- modal agregar trabajo realizado -->
                    <v-dialog v-model="dialog" width="400px">
                      <template >
                      </template>
                      <v-card>
                        <v-card-title>
                          <span class="headline">Agregar trabajo realizado</span>
                        </v-card-title>
                        <v-card-text>
                          <div class="row">
                            <div class="col-sm-6">            
                              <v-text-field label="Pedido*"></v-text-field>            
                            </div>
                            <div class="col-sm-6">            
                              <v-text-field label="Pares*" ></v-text-field>            
                            </div>
                          </div>
                        </v-card-text>
                        <v-card-actions>
                          <v-spacer></v-spacer>
                          <v-btn color="red darken-1" text @click="dialog = false">Cancelar</v-btn>
                          <v-btn color="success darken-1" text @click="diaslog=false">Guardar</v-btn>
                        </v-card-actions>
                      </v-card>
                    </v-dialog>
                    <!-- ------------------------- -->   

                  </v-card-title>
                   <!-- tabla -->
                  <v-data-table :headers="headers" :items="rows" :search="search" @click:row="rowClick">
                    <template v-slot:item.opciones="{}">
                      <v-btn icon color="primary">
                        <v-icon>mdi-pencil</v-icon>
                      </v-btn> 
                      <v-btn icon color="primary">
                        <v-icon>mdi-delete</v-icon>
                      </v-btn>                        
                    </template>
                  </v-data-table>
                  <!-- ------------ -->
                </v-expansion-panel-content>
              </v-expansion-panel>
            </v-expansion-panels>
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
            <span class="headline">Editar tarea</span>
          </v-card-title>
          <v-card-text>
            <h4>datos de la tarea a editar</h4>
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

export default {
    name: 'About',    
    components: { },         
    data() {
      return { 
        showModalAgregarTarea: false,
        dialog: false,  
        toastrTimeOut: 6000, 
        textToastr: null,
        showToastr: false,

        showModal: false,
        isEditMode: false,

        model: {
          empleadoSeleccionado: null,
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
          { text: 'Pedido', value: 'pedido' },
          { text: 'Pares', value: 'pares' },
          { text: 'Acciones', value: 'opciones' },
        ],

        tareas: [
          {
            text: 'Troquelar palmillas',
            value: 'Troquelar palmillas'
          },
          {
            text: 'Troquelar talonetas',
            value: 'Troquelar talonetas'
          },
        ],

        empleados: [
          {
            text: 'Indalecio Hernández Más',
            value: 'IHM'
          },
          {
            text: 'Itziar García Yates',
            value: 'IGY'
          },
          {
            text: 'Zuriñe Corbí García',
            value: 'ZCG'
          },
          {
            text: 'Javier Hernández Navarro',
            value: 'JHN'
          },
        ],

        tareasAgregadas: ['Numerar palmillas', 'Rebajar talonetas', 'Dar cola palmillas', 'Dar cola talonetas', 'Desvirar palmillas', 'Moldear palmillas', 'Troquelar palmillas', 'Troquelar talonetas'],
        
        rows: [
          {
            pedido: 1,
            pares: 1000,            
          },
          {
            pedido: 2,
            pares: 2600,
          },
          {
            pedido: 3,
            pares: 150,
          },
          {
            pedido: 4,
            pares: 700,
          },
          {
            pedido: 5,
            pares: 5000,
          },
          {
            pedido: 6,
            pares: 500,
          },    
          {
            pedido: 7,
            pares: 270,
          }        
        ],
      };
    }, 

    methods: {
      rowClick (row){
        this.showModal = true;
        this.isEditMode = true;              
        debugger;
      },

      anyadirEmpleado (){
        this.isEditMode = false;
        this.showModal = true;
      },

      resetModel (){
        
      },

      cancelarButtonClick (){   
        this.showModal = false;
        this.resetModel();
      },

      guardarButtonClick (){
        debugger;
        
        if(!this.isEditMode){

        }
        else{
         
        }
        this.showModal = false; 
        this.showToastr = true;                
      }
    }       
  };
</script>


