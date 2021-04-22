import Vue from "vue";
import App from "./App.vue";
import router from "./router";
import store from "./store";
import vuetify from "./plugins/vuetify";
import JsonExcel from "vue-json-excel";
import i18n from "./i18n";
import moment from 'moment'
import VueHtmlToPaper from 'vue-html-to-paper';
import VueCookies from 'vue-cookies';
import Notifications from 'vue-notification'
Vue.component("downloadExcel", JsonExcel);
Vue.prototype.moment = moment
Vue.config.productionTip = false;
Vue.use(VueHtmlToPaper);
Vue.use(VueCookies);
Vue.use(Notifications)

new Vue({
  router,
  store,
  vuetify,
  i18n,
  render: h => h(App)
}).$mount("#app");
