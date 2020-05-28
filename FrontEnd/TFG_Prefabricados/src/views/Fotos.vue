<template>
  <div>    
    <div class="row ml-5 mr-5 mb-7">
      <v-card class="col-sm-12" elevation="5">
        <v-card-title class="headline">Galería de fotos</v-card-title>
        <v-divider></v-divider>      
        
        <div class="row">
          <div class="col-sm-12">
            <v-alert border="top" color="success" dark>{{ textoAlerta }}</v-alert>
            <v-alert outlined color="error">
              <div>{{ textoAlerta }}</div>
             </v-alert>
          </div>
          <div class="col-sm-4 text-center">
            <v-text-field v-model="number" label="Number"></v-text-field>
              <v-btn depressed small color="primary" v-on:click="foto1Click">Foto 1</v-btn>
          </div>
          <div class="col-sm-4 text-center">
              <v-btn rounded  small color="primary" v-on:click="foto2Click">Foto 2</v-btn>
          </div>
          <div class="col-sm-4 text-center">
            <v-btn class="ma-2" tile outlined color="primary">
              <v-icon left>mdi-camera</v-icon> Foto 3
            </v-btn>
          </div>            
        </div>              
      </v-card>
    </div>              

    <div v-if="mostrarFoto" class="row ml-5 mr-5 mb-7">
      <v-card class="col-sm-12" elevation="5">          
        <div class="row">            
          <div class="col-sm-12 text-center">
            <Foto ></Foto>
        </div>
        </div>          
      </v-card>
    </div>       
  </div>
</template> 

<script>
  import Foto from '@/components/Foto.vue';
import store from '../store';

  export default {
    name: 'Fotos',      
    data() {
      return { 
        token: 'eyJhbGciOiJSUzI1NiIsImtpZCI6IkJnTm95Qi1aSEhwcDJBNkhJMVF4emciLCJ0eXAiOiJhdCtqd3QifQ.eyJuYmYiOjE1ODA3NTQwNzYsImV4cCI6MTU4MDc1NzY3NiwiaXNzIjoiaHR0cHM6Ly9sb2NhbGhvc3Q6NDQzMDkiLCJhdWQiOiJBcGkiLCJjbGllbnRfaWQiOiJQcmVmYWJyaWNhZG9zIiwic2NvcGUiOlsiQXBpIl19.IpFGfbZlruibLPagEe3kXfMz6LjJb4fnjKrdUBMOOKQsInEkLggZUoAxRqrmxl8xeWUponHFvXODFxgy65QH8FRvFpo9dM3Dqzw8KOIXn1lTVkcQg8W2WyGTYnKH_LZSh3Il1C6xte_bcJOXOb1N3nZdwk9FGgfIAqAcdxfuC2RSv5VCsLDT1kJelzpVsmLEjrJz_E872_m_d1RFXKePoqOOk-_rmFy_BAKwjwXxss0oDLqU9cAANDyxwFciEUc53nxcYWXGv36ZwVuxnt9sfYElFyc4VNRQ2Sns2GKdbRw84ihAAmQ0boNllCnmlErLdiDRyPKljNDwML_MTQSf7w',
        config: {
          headers: {            
            Authorization: `Bearer ${this.token}`,
          }
        },
        urlApi: store.state.API_URL,
        number: 9999, 
        textoAlerta: "este es un texto de prueba para ver como se va a quedar esta mierda",
      };
    },
    components: {
      Foto,
    },    
    computed: {
      mostrarFoto: function() {
        if(this.$route.params.id){
          return true;
        }
        else{
          return false;
        }          
      },
    },
    created: function(){
      this.loadApiData();
    },   
    methods: {
      loadApiData: function(){
        debugger;
        this.axios.get(`${store.state.API_URL}/api/Prueba`, this.config)
        .then(response =>{
          debugger;
        });
      },

      foto1Click: function(){
        this.tituloPagina = "asdfasd";
        this.$router.push('/fotos/1')
      },

      foto2Click: function(){
        this.$router.push('/fotos/2')
      },

      foto3Click: function(){
        this.$router.push('/fotos/3')
      },
    },
  };
</script>