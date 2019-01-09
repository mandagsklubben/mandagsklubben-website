import Vue from 'vue'
import App from './App.vue'
import axios from 'axios'
import VueAxios from 'vue-axios'
import '@/assets/styles/tailwind.pcss'

Vue.config.productionTip = false
Vue.use(VueAxios, axios)
Vue.use(require('vue-moment'));

new Vue({
  render: h => h(App),
}).$mount('#app')
