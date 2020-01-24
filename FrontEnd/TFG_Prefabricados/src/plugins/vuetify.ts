import Vue from 'vue';
import Vuetify from 'vuetify/lib';
import colors from 'vuetify/lib/util/colors'

Vue.use(Vuetify);

export default new Vuetify({
    iconfont: 'md',
    theme: {
        //dark: true,
        themes: {
          light: {
            primary: "#009688",
            secondary: "#424242",
            accent: "#19c0a0",
            error: '#FF5252',
            info: '#2196F3',
            success: '#4CAF50',
            warning: '#FFC107',
          },
          dark: {
            primary: "#009688",
            secondary: "#424242",
            accent: "#19c0a0",
            error: '#FF5252',
            info: '#2196F3',
            success: '#4CAF50',
            warning: '#FFC107',
          },
        },
      },
});
