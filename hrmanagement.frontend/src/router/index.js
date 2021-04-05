import Vue from "vue";
import VueRouter from "vue-router";
import Projects from "../views/Projects.vue";
import Dashboard from "../views/Dashboard.vue";
import Team from "../views/Team.vue";
import Contact from "../views/Contact.vue";
import Login from '../components/Login.vue';
import AddUser from '../views/AddUser.vue'
import Dropdown from '../views/dropdown.vue'
import List_contact from '../views/list_contact.vue'
import Profile_assistant_info from '../views/profile-assistant-info.vue'
import User_info from "../views/user_info.vue";
Vue.use(VueRouter);

const routes = [
  {
    path: "/",
    name: "dashboard",
    component: Dashboard
  },
  {
    path: "/dropdown",
    name: "dashboard",
    component: Dropdown
  },
  {
    path: "/projects",
    name: "projects",
    component: Projects

    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    //component: () =>
    //import(/* webpackChunkName: "about" */ "../views/About.vue")
  },
  {
    path: "/team",
    name: "team",
    component: Team
  },
  {
    path: "/team/:id",
    component: User_info
  },
  {
    path: "/profile_assistant_info",
    name: "profile_assistant_info",
    component: Profile_assistant_info
  },
  {
    path: "/list_contact",
    name: "list_contact",
    component: List_contact,
    meta: {
      allowAnonymous: true
    },
    
  },
  {
    path: "/addUser",
    name: "addUser",
    component: AddUser
  },
  {
    path: '/login',
    name: 'Login',
    component: Login,
    meta: {
      allowAnonymous: true
    },
  },
  {
    path: "/contact",
    name: "contact",
    component: Contact,
  },

];

const router = new VueRouter({
  mode: "history",
  base: process.env.BASE_URL,
  routes
});

export default router;