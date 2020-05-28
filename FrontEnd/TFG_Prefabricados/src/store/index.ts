import Vue from 'vue';
import Vuex from 'vuex'

Vue.use(Vuex);

export const store = new Vuex.Store({
    state: {
        API_URL: 'https://localhost:44379'
    },
    getters: { },
    actions: { },
    mutations: { },
});

export default store;
