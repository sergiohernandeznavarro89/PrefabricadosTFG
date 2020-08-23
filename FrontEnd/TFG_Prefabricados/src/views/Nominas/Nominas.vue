<template>
    <div class=" row ml-5 mr-5 mb-7">          
      <v-card class="col-sm-12" elevation="5">    
        <v-card-title class="headline">Nominas</v-card-title>   
        <v-divider></v-divider>        
        <div class="row">
          <div class="col-sm-12">
            <v-card-title>
              <!-- botón añadir nómina -->
              <v-btn tile outlined color="primary" @click="crearNominaClick">
                <v-icon left>mdi-plus</v-icon> Crear Nómina
              </v-btn>   
              <!-- -----------------------  -->
              <v-spacer></v-spacer>
              <!-- buscador tabla -->
              <v-text-field v-model="search" append-icon="mdi-magnify" label="Search" single-line hide-details></v-text-field>
              <!-- -------------- -->
            </v-card-title>
            <!-- tabla -->
            <v-data-table :headers="headers" :items="rowsNominas" :search="search" @click:row="rowNominasClick">
              <template v-slot:[`item.opciones`]= "row">
                <v-btn icon color="primary" @click="ver($event, row)">
                  <v-icon>mdi-eye</v-icon>
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
            <span class="headline">Nómina</span>
          </v-card-title>
          <v-card-text>
            <v-alert text color="info" class="col-sm-6 offset-3">
              <div v-show=!isEditMode>
                <p class="font-weight-bold text-center"> Indica el trabajador para el que deseas generar nómina para agosto de 2020 </p>  
                <div class="col-sm-12">            
                  <v-select :items="empleados" item-text="text" item-value="value" v-model="model.empleadoSeleccionado" label="Seleccionar Empleado" @change="changeEmpleado" dense></v-select>
                </div>  
                <p v-show="model.empleadoSeleccionado" class="font-weight-bold text-center">IMPORTE: {{ model.importe }} €</p>
              </div>       
              <div v-show=isEditMode>
                <p class="font-weight-bold text-center"> Nómina: 1, Empleado: Sergio Hernández Navarro, desde: 01/01/2020 hasta: 31/01/2020 </p>  
                <p class="font-weight-bold text-center">IMPORTE: {{ model.importe }} €</p>                
              </div>              
            </v-alert>
            
            <!-- TARJETA -->
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
                      </v-card-title>
                      <!-- tabla -->
                      <v-data-table :headers="headersNominaIndividual" :items="tarea.tareasRealizadas" :search="search">                        
                      </v-data-table>
                      <!-- ------------ -->
                    </v-expansion-panel-content>
                  </v-expansion-panel>
                </v-expansion-panels>
              </div>                     
            </div>
            <!-- ----------------------- -->

          </v-card-text>
          <v-card-actions>
            <v-spacer></v-spacer>
            <v-btn color="red darken-1" text @click="cancelarButtonClick">Cancelar</v-btn>
            <v-btn v-show="!isEditMode" color="success darken-1" text @click="guardarButtonClick">Crear Nómina</v-btn>
          </v-card-actions>
        </v-card>
      </v-dialog>
      <!-- ------------------------- -->


    </div>    
</template> 

<script>
import addEditEmpleado from '@/components/Nominas/Empleados/AddEditEmpleado.vue';

export default {
    name: 'About',    
    components: {
      addEditEmpleado,
    },         
    data() {
      return {   
        tareasAgregadas: [ ],

        toastrTimeOut: 6000, 
        textToastr: null,
        showToastr: false,

        showModal: false,
        isEditMode: false,

        empleados: [ ],

        model: {
          importe: null,
          empleadoSeleccionado: null
        },        

        search: '',
        headersNominaIndividual: [
          { text: 'Pedido', value: 'idPedido' },
          { text: 'Pares', value: 'paresRealizados' },
        ],

        headers: [
          { text: 'Codigo', value: 'codigo' },
          { text: 'Empleado', value: 'empleado' },
          { text: 'Fecha Inicio', value: 'fechaInicio' },
          { text: 'Fecha Fin', value: 'fechaFin' },
          { text: 'Importe', value: 'importe' },
          { text: 'Opciones', value: 'opciones' },
        ],
        
        rowsNominas: [ ],
      };
    }, 

    methods: {
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

      loadNominas(){
        axios.get('https://localhost:44379/api/Nominas')
          .then(response => {
            if(response.data){
              this.rowsNominas = response.data;
            }
          });
      },

      changeEmpleado (){
        axios.get('https://localhost:44379/api/TrabajosRealizados?empleadoId=' + this.model.empleadoSeleccionado)
          .then(response => {
            if(response.data){
              this.tareasAgregadas = response.data;

              let importeTotal = 0;
              response.data.forEach(item => {
                let precio = item.precio;                                
                item.trabajosRealizados.forEach(trabajo => {
                  importeTotal = importeTotal + (trabajo.pares * precio);
                })
              })
              this.model.importe = importeTotal;
            }
          });
      },

      rowNominasClick (row){
        this.ver(null, {item: row});
      },

      ver (event, row){
        if(event){
          event.stopPropagation();          
        }
        this.showModal = true;
        this.isEditMode = true;
        
        axios.get('https://localhost:44379/api/Nominas/' + row.NominaId)
          .then(response => {
            if(response.data){
              this.tareasAgregadas = response.data.tareas;              
              this.model.importe = response.data.importe;
            }
          });
      },      

      crearNominaClick (){
        debugger;

        this.showModal = true;
        this.isEditMode = false;                
      },     

      cancelarButtonClick (){   
        this.showModal = false;
      },

      guardarButtonClick (){       
        this.model.trabajosRealizados.forEach(item => {
          let datosEnviar = {
            trabajoRealizado: item,
            empleadoId: this.model.empleadoSeleccionado,
            importe: this.model.importe,
            fechaInicio: "01-" + date.getMonth() + date.getYear(),
            fechaFin: "30-" + date.getMonth() + date.getYear(),
          };

          axios.post('https://localhost:44379/api/Nominas', datosEnviar)
            .then(response => {
              if(response.data){
                this.textToastr = "Nómina generada satisfactoriamente"         
                this.showModal = false;
                this.showToastr = true;
                this.loadNominas();                              
              }            
            });           
        });           
      }        
    }
};
</script>


