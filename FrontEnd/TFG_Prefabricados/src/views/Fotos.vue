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
            <v-btn class="ma-2" tile outlined color="primary" v-on:click="foto3Click">
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

  export default {    
    name: 'Fotos',      
    data() {
      return { 
        urlApi: this.$store.state.API_URL,
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
    created: function(){ },   
    
    methods: {      
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