<template>
    <div class=" row ml-5 mr-5 mb-7">          
      <v-card class="col-sm-12" elevation="5">    
        <v-card-title class="headline">Nominas</v-card-title>   
        <v-divider></v-divider>        
        <div class="row">
          <div class="col-sm-12">
            <v-card-title>
              <!-- botón añadir nómina -->
              <v-btn tile outlined color="primary" @click="anyadirEmpleado">
                <v-icon left>mdi-plus</v-icon> Crear Nómina
              </v-btn>   
              <!-- -----------------------  -->
              <v-spacer></v-spacer>
              <!-- buscador tabla -->
              <v-text-field v-model="search" append-icon="mdi-magnify" label="Search" single-line hide-details></v-text-field>
              <!-- -------------- -->
            </v-card-title>
            <!-- tabla -->
            <v-data-table :headers="headers" :items="rows" :search="search" @click:row="rowClick">
              <template v-slot:[`item.actions`]="{}">
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
      <v-dialog v-model="showModal" width="1500px">
        <template >
        </template>
        <v-card>
          <v-card-title>
            <span class="headline">Nómina</span>
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

export default {
    name: 'About',    
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
          { text: 'Codigo', value: 'codigo' },
          { text: 'Nombre', value: 'nombre' },
          { text: 'Apellidos', value: 'apellidos' },
          { text: 'DNI', value: 'dni' },
          { text: 'Email', value: 'email' },
          { text: 'Poblacion', value: 'poblacion' },
          { text: 'Provincia', value: 'provincia' },
          { text: 'Cod. Postal', value: 'codPostal' },
          { text: 'Dirección', value: 'direccion' },
          { text: 'Teléfono', value: 'telefono' },
          { text: 'opciones', value: 'opciones' },

        ],
        
        rows: [
          {
            codigo: 1,
            nombre: 'Sergio',
            apellidos: 'Hernández Navarro',
            dni: '15422259T',
            email: 'sergiohn89@gmail.com',
            poblacion: 'Villena',
            provincia: 'Alicante',
            codPostal: '03400',
            direccion: 'Cristobal amoros Nº:36 2º IZQ',
            telefono: '609104724',
          },
          {
            codigo: 2,
            nombre: 'Javier',
            apellidos: 'Hernández Navarro',
            dni: '15422258E',
            email: 'javierhn@gmail.com',
            poblacion: 'Villena',
            provincia: 'Alicante',
            codPostal: '03400',
            direccion: 'Cristobal amoros Nº:36 2º IZQ',
            telefono: '660519191',
          },
          {
            codigo: 3,
            nombre: 'Itziar',
            apellidos: 'Garcia Yates',
            dni: '56878634R',
            email: 'itziyates@gmail.com',
            poblacion: 'Monforte del cid',
            provincia: 'Alicante',
            codPostal: '03435',
            direccion: 'C/: Doctor Fléming Nº 7',
            telefono: '653986715',
          },
          {
            codigo: 4,
            nombre: 'Natalia',
            apellidos: 'Lara Ortega',
            dni: '15427496S',
            email: 'natalialaraortega@gmail.com',
            poblacion: 'Biar',
            provincia: 'Alicante',
            codPostal: '03410',
            direccion: 'Partida la yoma de más',
            telefono: '679504173',
          },
          {
            codigo: 5,
            nombre: 'Joaquina',
            apellidos: 'Navarro Espinosa',
            dni: '15663743T',
            email: 'joaquina.ne@gmail.com',
            poblacion: 'Villena',
            provincia: 'Alicante',
            codPostal: '03400',
            direccion: 'Cristobal amoros Nº:36 2º IZQ',
            telefono: '659504105',
          },
          {
            codigo: 6,
            nombre: 'Indalecio',
            apellidos: 'Hernández Más',
            dni: '74211474L',
            email: 'in.pre.an@gmail.com',
            poblacion: 'Villena',
            provincia: 'Alicante',
            codPostal: '03400',
            direccion: 'Poligono industrial El Rubial C:6 Pla:84',
            telefono: '659504105',
          },    
          {
            codigo: 7,
            nombre: 'Zuriñe',
            apellidos: 'Corbí García',
            dni: '65932547Z',
            email: 'zuricorviyates@gmail.com',
            poblacion: 'Monforte del Cid',
            provincia: 'Alicante',
            codPostal: '03670',
            direccion: 'Calle doctór fleming Nº 7',
            telefono: '615734042',
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
        this.model.apellidos = row.apellidos;
        this.model.nif = row.dni;
        this.model.email = row.email;
        this.model.poblacion = row.poblacion;
        this.model.provincia = row.provincia;
        this.model.codPostal = row.codPostal;
        this.model.direccion = row.direccion;
        this.model.telefono = row.telefono;
        this.model.iban = "ES80123451238761239861230987";
        debugger;
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
        debugger;
        
        if(!this.isEditMode){
          this.rows.push(
            {            
              codigo: this.rows.length + 1,
              nombre: this.model.nombre,
              apellidos: this.model.apellidos,
              dni: this.model.nif,
              email: this.model.email,
              poblacion: this.model.poblacion,
              provincia: this.model.provincia,
              codPostal: this.model.codPostal,
              direccion: this.model.direccion,
              telefono: this.model.telefono
            }          
          );
          this.textToastr = "Empleado creado satisfactoriamente" 
        }
        else{
          debugger;
          this.rows[this.model.codigo - 1].codigo = this.model.codigo;
          this.rows[this.model.codigo - 1].nombre = this.model.nombre;
          this.rows[this.model.codigo - 1].apellidos = this.model.apellidos;
          this.rows[this.model.codigo - 1].nif = this.model.nif;
          this.rows[this.model.codigo - 1].email = this.model.email;
          this.rows[this.model.codigo - 1].poblacion = this.model.poblacion;
          this.rows[this.model.codigo - 1].provincia = this.model.provincia;
          this.rows[this.model.codigo - 1].codPostal = this.model.codPostal;
          this.rows[this.model.codigo - 1].direccion = this.model.direccion;
          this.rows[this.model.codigo - 1].telefono = this.model.telefono;                   
          
          this.textToastr = "Empleado modificado satisfactoriamente";
        }
        this.showModal = false; 
        this.showToastr = true;                
      }
    }       
  };
</script>


