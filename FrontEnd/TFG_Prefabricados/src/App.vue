<template>
  <v-app style="background: #D7CCC8">
    <div class="row">

      <!-- menú de la izquierda -->
      <v-navigation-drawer :clipped="clipped" v-model="drawer" enable-resize-watcher app>
        <v-list>
          <v-list-item @click.stop="drawer = !drawer">
            <v-list-item-avatar>
              <v-img src="https://randomuser.me/api/portraits/men/85.jpg"></v-img>
            </v-list-item-avatar>
            <v-list-item-content>
              <v-list-item-title>John Leider</v-list-item-title>
            </v-list-item-content>            
            <v-btn icon>
              <v-icon>mdi-chevron-left</v-icon>
            </v-btn>
          </v-list-item>
          <v-list-item>
            <v-switch color="primary" :change="cambiarTema()" label="Tema claro" v-model="darkTheme"></v-switch>
          </v-list-item>
        </v-list>
        <v-divider></v-divider>
        <v-list dense>
          <v-list-item class="menuLateral" v-for="item in items" :key="item.title" link v-on:click="menuClick(item.path)">
            <v-list-item-icon>
              <v-icon>{{ item.icon }}</v-icon>
            </v-list-item-icon>

            <v-list-item-content>
              <v-list-item-title>{{ item.title }}</v-list-item-title>
            </v-list-item-content>
          </v-list-item>
        </v-list>        
      </v-navigation-drawer>

      <!-- ======================== -->

      <!-- contenido de la página -->
      <v-content>        
        <v-container fluid>    
          <v-btn @click.stop="drawer = !drawer" v-if="!drawer" class="mt-7" fab small dark color="primary" absolute top left>
            <v-icon primary>mdi-chevron-right</v-icon>
          </v-btn>        
          <router-view></router-view>
        </v-container>
      </v-content>
      <!-- =================== -->
    </div>
  </v-app>
</template>

<script lang="es">

import Vue from 'vue';

export default Vue.extend({
  name: 'App',

  data () {
    return {
      darkTheme: false,
      drawer: true,
      clipped: false,
      items: [
        { title: 'Home', icon: 'mdi-home-city', path: '/' },
        { title: 'About', icon: 'mdi-account', path: '/about' },
        { title: 'Fotos', icon: 'mdi-account-group-outline', path: '/fotos' },
      ],
    }
    //
  },
  methods: {
    menuClick: function(path){
      if(this.$router.currentRoute.fullPath !== path)
        this.$router.push({path: path});
    },
    cambiarTema: function(){
      this.$vuetify.theme.dark = !this.darkTheme;
    },
  },
});
</script>

<style>  
  @import "./css/core.css";
</style>
