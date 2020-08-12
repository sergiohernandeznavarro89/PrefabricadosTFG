import Vue from 'vue';
import VueRouter from 'vue-router';
import Home from '../views/Home.vue';

Vue.use(VueRouter);

const routes = [
  {
    path: '/',
    name: 'home',
    component: Home,
  },
  // NOMINAS
  {
    path: '/nominas',
    name: 'nominas',    
    component: () => import(/* webpackChunkName: "about" */ '../views/Nominas/Nominas.vue'),
  },
  {
    path: '/empleados',
    name: 'empleados',    
    component: () => import(/* webpackChunkName: "about" */ '../views/Nominas/Empleados.vue'),
  },
  {
    path: '/tareas',
    name: 'tareas',    
    component: () => import(/* webpackChunkName: "about" */ '../views/Nominas/Tareas.vue'),
  },
  {
    path: '/trabajosRealizados',
    name: 'trabajosRealizados',    
    component: () => import(/* webpackChunkName: "about" */ '../views/Nominas/TrabajosRealizados.vue'),
  },  
  // ---------
  {
    path: '/fotos/:id?',
    name: 'fotos',
    component: () => import(/* webpackChunkName: "Fotos" */ '../views/Fotos.vue'),
  },
];

const router = new VueRouter({
  mode: 'history',
  base: process.env.BASE_URL,
  routes,
});

export default router;
