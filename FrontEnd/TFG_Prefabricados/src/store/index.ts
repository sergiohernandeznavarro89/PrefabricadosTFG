import Vue from 'vue';
import Vuex from 'vuex'

Vue.use(Vuex);

const store = new Vuex.Store({
    state: {
        API_URL: 'https://localhost:44379',
        userTokens: null
    },
    getters: { },
    actions: { 
        // LOGIN: ({commit}, user) =>{
        //     this.axios.post('', user).then(resp => {
        //         commit('AUTH_SUCCESS', resp.data.token)
        //     })
        // }
    },
    mutations: {
        // AUTH_SUCCESS: (state, token) => {
        //     if (token && token !== 'undefined') {
        //         state.userTokens = token
        //     } 
        // },
     },
});

export default store;
