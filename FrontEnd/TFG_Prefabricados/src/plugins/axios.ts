import axios, { AxiosStatic } from 'axios';
import store from '../store';
import Vue from 'vue';


const service = axios.create({
    baseURL: store.state.API_URL,
    timeout: 60000,
    headers: { Pragma: 'no-cache' }
  });

  service.interceptors.request.use((config) => {
  // https://gist.github.com/srph/38f67a10e991b6cb2d83
    if (store.state.userTokens) config.headers.Authorization = `Bearer ${store.state.userTokens}`;
    return config;
  });

  // Add a 401 response interceptor
  /* service.interceptors.response.use(
    (response) => re
    sponse,
    (error) => {
    // if (error.response.status === 401) store.dispatch('logout');
      throw error;
    }
  ); */

  
  let vueConfig = {
      install (Vue :any) {
        
        Vue.prototype.$axios = service;  
    }
}
    declare module 'vue/types/vue' {
        interface Vue {
        axios: AxiosStatic;
        }
    }
    // Vue.axios= service;
  Vue.use(vueConfig)
  

  export default service