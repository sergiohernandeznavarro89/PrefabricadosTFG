<template>
<div>      
    <div class=" row ml-5 mr-5 mb-7">          
      <v-card class="col-sm-12" elevation="5">    
        <v-card-title class="headline">Home</v-card-title>   
        <v-divider></v-divider>
        <div class="row">
          <div class="col-sm-12">
            <v-img :src="require('../assets/logo.svg')" class="my-3" contain height="200"></v-img>
            <h1 class="text-center display-2 font-weight-bold mb-3"> Welcome to Home Page </h1>
          </div>
        </div>                
      </v-card>
    </div>                 
  </div>  
</template>

<script lang="ts">
import Vue from 'vue';

export default{
  name: 'Home',
};
</script>
