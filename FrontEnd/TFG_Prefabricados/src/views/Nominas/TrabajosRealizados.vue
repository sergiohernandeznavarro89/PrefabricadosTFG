<template>
    <div class=" row ml-5 mr-5 mb-7">          
      <v-card class="col-sm-12" elevation="5">    
        <v-card-title class="headline">Trabajos Realizados</v-card-title>   
        <v-divider></v-divider>                              
        
        <div class="row mt-5">
            <v-alert text color="info" class="col-sm-6 offset-3">
              <p class="font-weight-bold"> Indica el trabajador para el que deseas incurrir los trabajos realizados para agosto de 2020 </p>  
              <div class="col-sm-12">            
                <v-select :items="empleados" item-text="text" item-value="value" label="Seleccionar Empleado" v-model="model.empleadoSeleccionado" @change="changeEmpleado" dense></v-select>
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
                    <v-select :items="tareas" v-model="model.tareaSeleccionada" item-text="text" item-value="value" label="Seleccionar Tarea" dense></v-select>
                  </div>                            
                </div>
                
              </v-card-text>
              <v-card-actions>
                <v-spacer></v-spacer>
                <v-btn color="red darken-1" text @click="showModalAgregarTarea = false">Cancelar</v-btn>
                <v-btn color="success darken-1" text @click="guardarTareaClick()">Guardar</v-btn>
              </v-card-actions>
            </v-card>
          </v-dialog>
          <!-- ------------------------- -->
        <div v-show="model.empleadoSeleccionado" class="row">         
          <div class="col-sm-4" v-for="tarea in tareasAgregadas" :key="tarea.value">
            <v-expansion-panels class="mb-6">
              <v-expansion-panel>
                <v-expansion-panel-header class="primary--text" expand-icon="mdi-menu-down">
                  <h3>{{ tarea.nombre }}</h3>
                </v-expansion-panel-header>
                <v-expansion-panel-content>
                  <v-card-title>              
                    <!-- buscador tabla -->
                    <v-text-field v-model="search" append-icon="mdi-magnify" label="Search" single-line hide-details></v-text-field>
                    <!-- -------------- -->
                    <v-spacer></v-spacer>
                    <v-btn class="mx-2" fab dark small color="primary" @click="addTrabajoRealizado(tarea.idTrabajo)">
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
                              <v-text-field v-model="model.pedido" label="Pedido*"></v-text-field>            
                            </div>
                            <div class="col-sm-6">            
                              <v-text-field v-model="model.pares" label="Pares*" ></v-text-field>            
                            </div>
                          </div>
                        </v-card-text>
                        <v-card-actions>
                          <v-spacer></v-spacer>
                          <v-btn color="red darken-1" text @click="cancelarButtonClick()">Cancelar</v-btn>
                          <v-btn color="success darken-1" text @click="guardarButtonClick()">Guardar</v-btn>
                        </v-card-actions>
                      </v-card>
                    </v-dialog>
                    <!-- ------------------------- -->   

                  </v-card-title>
                   <!-- tabla -->
                  <v-data-table :headers="headers" :items="tarea.tareasRealizadas" :search="search" @click:row="rowClick">
                    <template v-slot:[`item.opciones`]= "row">
                      <v-btn icon color="primary" @click="edit($event, row, tarea.idTrabajo)">
                        <v-icon>mdi-pencil</v-icon>
                      </v-btn> 
                      <v-btn icon color="primary" @click="remove($event, row)">
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
      <v-dialog v-model="showModal" width="300px">
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
            <v-btn color="success darken-1" text>Guardar</v-btn>
          </v-card-actions>
        </v-card>
      </v-dialog>
      <!-- ------------------------- -->


    </div>    
</template> 

<script>

import axios from "axios";

export default {
    name: 'trabajosRealizados',    
    components: { },         
    data() {
      return { 
        trabajoAgregar: null,
        informacionEmpleado: null,

        showModalAgregarTarea: false,
        dialog: false,  
        toastrTimeOut: 6000, 
        textToastr: null,
        showToastr: false,

        showModal: false,
        isEditMode: false,

        model: {
          empleadoSeleccionado: null,
          pedido: null,
          pares: null,  
          tareaSeleccionada: null,        
        },        

        search: '',
        headers: [
          { text: 'Pedido', value: 'idPedido' },
          { text: 'Pares', value: 'paresRealizados' },
          { text: 'Acciones', value: 'opciones' },
        ],

        tareasRealizadas: [ ],
        tareas: [ ],
        empleados: [ ],

        tareasAgregadas: [ ],             
      };
    }, 

    watch: {
      informacionEmpleado(val){
        debugger;
        this.tareasRealizadas = val.tareasRealizadas;
        let trabajos = this.tareasRealizadas.map(tr => tr.idTrabajo);
        let trabajosSinDuplicar = [];
        let objetoTrabajos = [];

        trabajos.forEach(t => {
          if(!(t in objetoTrabajos)){
            objetoTrabajos[t] = true;
            trabajosSinDuplicar.push(t);
          }
        })
        
        this.searchTareas(trabajosSinDuplicar);
      }
    },

    created () {       
      this.loadEmpleados();
      this.loadTareas();
    },

    methods: {
      guardarTareaClick(){
        debugger;
        let datosTareaAgregar = this.tareas.find(t => {
          return t.value === this.model.tareaSeleccionada;  
        });
        this.tareasAgregadas.push({idTrabajo: datosTareaAgregar.value, nombre: datosTareaAgregar.text, tareasRealizadas: { }});
      },

      edit (event, row, idTrabajo){
        debugger;
        if(event){
          event.stopPropagation();          
        }
        
        this.trabajoAgregar = idTrabajo;
        this.dialog = true;
        this.isEditMode = true;
        
        axios.get('https://localhost:44379/api/TareasRealizadas/' + row.item.idTareaRealizada)
          .then(response => {
            this.model.pedido = response.data.idPedido;
            this.model.pares = response.data.paresRealizados;            
          });
      },

      addTrabajoRealizado(idTrabajo){
        debugger;
        this.trabajoAgregar = idTrabajo;
        this.model.pedido = null;
        this.model.pares = null;
        this.isEditMode = false;  
        this.dialog = true;      
      },

      remove(event, row){
        if(event){
          event.stopPropagation();          
        }
        debugger;
        axios.delete('https://localhost:44379/api/TareasRealizadas/' + row.item.idTareaRealizada)
          .then(response => {
            this.changeEmpleado();
            this.textToastr = "Trabajo realizado borrado satisfactoriamente"
            this.showToastr = true;
          });

      },

      searchTareas(tareas){
        let trabajos = [];
        tareas.forEach(t => {
          axios.get('https://localhost:44379/api/Trabajos/' + t)
          .then(response => {
            trabajos.push(response.data);
            this.tareasAgregadas = trabajos;
          });
        });        
      },

      loadEmpleados(){
        axios.get('https://localhost:44379/api/Empleados')
          .then(response => {
            if(response.data){
              this.empleados = response.data.map(e => {
                return { value: e.idEmpleado, text: e.nombre + " " + e.apellidos };
              });
            }
          });
      },

      loadTareas(){
        axios.get('https://localhost:44379/api/Trabajos')
          .then(response => {            
            if(response.data){
              this.tareas = response.data.map(e => {
                return { value: e.idTrabajo, text: e.nombre };
              });
            }
          });
      },

      changeEmpleado (){
         axios.get('https://localhost:44379/api/Empleados/' + this.model.empleadoSeleccionado)
          .then(response => {
            if(response.data){              
              debugger;
              this.informacionEmpleado = response.data;
              this.tareasAgregadas = response.data.tareasRealizadas;
            }              
          });
      },

      rowClick (row){
        debugger;
        this.edit(null, {item: row});
      },

      anyadirEmpleado (){
        this.isEditMode = false;
        this.showModal = true;
      },

      cancelarButtonClick (){   
        this.showModal = false;
      },

      guardarButtonClick (){
        debugger;
        
        let datosEnviar = {
          idEmpleado: this.model.empleadoSeleccionado,          
          paresRealizados: parseInt(this.model.pares),
          idPedido: parseInt(this.model.pedido),
          idTrabajo: parseInt(this.trabajoAgregar),
        }

        this.trabajoAgregar = null;

        if(!this.isEditMode){          
          axios.post('https://localhost:44379/api/TareasRealizadas/', datosEnviar)
            .then(response => {
              if(response.data){
                this.dialog = false;
                this.textToastr = "Trabajo realizado incluido satisfactoriamente"
                this.showToastr = true;
                this.changeEmpleado();
              }
            });
        }
        else{
          axios.put('https://localhost:44379/api/TareasRealizadas/', datosEnviar)
          .then(response => {
            if(response.data){
              this.dialog = false;
              this.textToastr = "Trabajo realizado modificado satisfactoriamente"
              this.showToastr = true;
              this.changeEmpleado();
            }
          });
        }
        this.showModal = false; 
        this.showToastr = true;                
      }
    }       
  };
</script>


