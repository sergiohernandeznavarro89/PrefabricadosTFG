<template>
  <v-app style="background: #D7CCC8">
    <div v-if="!$store.state.userTokens"> 
      <div class="flex-center">
        <v-card class="col-sm-4" elevation="5">        
          <div>          
            <h2 class="text-center">Login</h2>          
            <v-divider></v-divider>
            <div class="row">
              <div class="col-sm-6 offset-3">
                <v-text-field v-model="user.name" label="Usuario"></v-text-field>
              </div>
            </div>
            <div class="row">
              <div class="col-sm-6 offset-3">                
                <v-text-field v-model="user.password" label="Contraseña"></v-text-field>
              </div>
            </div>
            <div class="row">
              <div class="col-sm-12 text-center">
                <v-btn tile outlined color="accent" v-on:click="loginClick">Login</v-btn>
              </div>        
            </div>
          </div>                
        </v-card>        
      </div>      
    </div>

    <div class="row" v-else>      
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
            <v-switch color="primary" label="Tema oscuro" v-model="darkTheme"></v-switch>
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
        <template v-slot:append>
        <div class="pa-2">
          <div class="col-sm-12 text-center">
            <v-btn block color="error" outlined v-on:click="showLogOutDialog = true">
              <v-icon left>mdi-exit-to-app</v-icon> Logout
            </v-btn>
          </div>
        </div>
      </template>     
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

<!-- Alert cambiar tema -->
      <v-row justify="center">        
        <v-dialog v-model="showThemeDialog" max-width="290" >
          <v-card>
            <v-card-title class="headline">¿Cambiar tema?</v-card-title>
            <v-divider></v-divider>
            <v-card-text>
              <v-container>
                ¿Está seguro de que desea cambiar el tema de la aplicación?
              </v-container>              
            </v-card-text>
            <v-card-actions>
              <v-spacer></v-spacer>
                <v-btn color="error" text @click="cancelarCambioTema">Cancelar</v-btn>
                <v-btn color="accent" text @click="cambiarTema">Aceptar</v-btn>
            </v-card-actions>
          </v-card>
        </v-dialog>
      </v-row>
<!-- =============== -->
<!-- Alert cerrar sesión -->
      <v-row justify="center">        
        <v-dialog v-model="showLogOutDialog" max-width="290" >
          <v-card>
            <v-card-title class="headline">¿Cerrar sesión?</v-card-title>
            <v-divider></v-divider>
            <v-card-text>
              <v-container>
                ¿Está seguro de que desea cerrar la sesión?
              </v-container>              
            </v-card-text>
            <v-card-actions>
              <v-spacer></v-spacer>
                <v-btn color="error" text @click="showLogOutDialog = false">Cancelar</v-btn>
                <v-btn color="accent" text @click="logoutClick">Aceptar</v-btn>
            </v-card-actions>
          </v-card>
        </v-dialog>
      </v-row>
<!-- =============== -->







    </div>
  </v-app>
</template>

<script lang="es">

export default{
  name: 'App',

  data () {
    return {
      user: {
        name: null,
        password: null,
      },    
      showThemeDialog: false, 
      showLogOutDialog: false,
      darkTheme: false,
      pulsadoBotonCancelarCambioTema: false,
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
  watch: {
    darkTheme: function(){
      this.pulsadoBotonCancelarCambioTema ? this.pulsadoBotonCancelarCambioTema = false : this.showThemeDialog = true;
    }
  },
  methods: {
    loginClick: function(){
      this.$store.state.userTokens = "ÑLKASJDFÑLKJASDFÑLKJSADFFSDJGIFGLÑHJ";
      // this.$store.dispatch('LOGIN', this.user)
    },
    logoutClick: function(){
      this.showLogOutDialog = false;
      this.$store.state.userTokens = null;      
      // this.$store.dispatch('LOGIN', this.user)
    },
    menuClick: function(path){
      if(this.$router.currentRoute.fullPath !== path)
        this.$router.push({path: path});
    },
    cambiarTema: function(){            
      this.$vuetify.theme.dark = this.darkTheme;
      this.showThemeDialog = false;
    },
    cancelarCambioTema: function(){
      this.pulsadoBotonCancelarCambioTema = true;
      this.showThemeDialog = false;  
      this.darkTheme= !this.darkTheme;          
    }
  },
};
</script>

<style>  
  @import "./css/core.css";
</style>
