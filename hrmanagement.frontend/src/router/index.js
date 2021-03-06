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
import Add_tashkilot from "../views/add_tashkilot.vue";
import AddTuzilma from '../views/add_tuzilma.vue'
import AddLavozim from '../views/add_lavozim.vue'
import UmumiyMalumot from '../views/umumiy_malumot.vue'
import MehnatFaoliyati from '../views/mehnat_faoliyati.vue'
import AddQarindosh from '../views/add_qarindosh.vue'
import PageNotFound from '../components/PageNotFound.vue'
import Malumoti from '../views/ma\'lumoti.vue'
import Tatil from '../views/add_tatil.vue'
import IntizomiyJazolar from '../views/intizomiy_jazolar.vue'
import YigmaJild from '../views/yig\'ma_jild.vue'
import HireEmployee from '../views/hire_employee.vue'
import AddReferenceBook from '../views/spravochnik/add_reference_book.vue'
import AddCountry from '../views/spravochnik/add_country.vue'
import AddRegion from '../views/spravochnik/addRegion.vue'
import AddDistrict from '../views/spravochnik/add_district.vue'
import AddLanguage from '../views/spravochnik/addLanguage.vue'
import AddNationality from '../views/spravochnik/add_nationality.vue'
import Partisanship from '../views/spravochnik/add_partisanships.vue'
import Relativity from '../views/spravochnik/add_relativity.vue'
import ScienceDegree from '../views/spravochnik/science_degree.vue'
import VacationType from '../views/spravochnik/add_vacation.vue'
import AddDepartment from '../views/tarkibiy_tuzilma/add_department.vue'
import section from '../views/tarkibiy_tuzilma/section.vue'


Vue.use(VueRouter);

const routes = [

  {
    path: "/",
    name: "dashboard",
    component: Dashboard
  },
  {
    path: "/page_not_found",
    alias: "*",
    component: PageNotFound
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
    path: "/projects/:id",
    component: Add_tashkilot,
  },
  {
    path: "/projects/:id/:id",
    component: AddDepartment,
  },
  {
    path: "/projects/:id/:id/:id",
    component: section,
  },
  {
    path: "/team",
    name: "team",
    component: Team
  },
  {
    path: "/team/:id",
    component: User_info,
    props: true,
    children: [
      { path: '/team/:id/umumiy_malumot', component: UmumiyMalumot, name: "umumiy_malumot"  },
      { path: '/team/:id/mehnat_faoliyati', component: MehnatFaoliyati, name: "mehnat_faoliyati"  },
      { path: '/team/:id/add_relatives', component: AddQarindosh, name: "add_relatives"  },
      { path: '/team/:id/add_tatil', component: Tatil, name: "add_tatil"  },
      { path: '/team/:id/malumoti', component: Malumoti, name: "malumoti"  },
      { path: '/team/:id/intizomiy_jazolar', component: IntizomiyJazolar, name: "intizomiy_jazolar"  },
      { path: '/team/:id/yigma_jild', component: YigmaJild, name: "yigma_jild"  }
    ]
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
    path: "/addTuzilma",
    name: "addTuzilma",
    component: AddTuzilma
  },
  {
    path: "/addLavozim",
    name: "addLavozim",
    component: AddLavozim
  },
  {
    path: "/add_reference_book",
    name: "add_reference_book",
    component: AddReferenceBook,
    children: [
      { path: '/add_reference_book/add_country', component: AddCountry, name: "add_country"  },
      { path: '/add_reference_book/add_region', component: AddRegion, name: "add_region"  },
      { path: '/add_reference_book/add_district', component: AddDistrict, name: "add_district"  },
      { path: '/add_reference_book/add_language', component: AddLanguage, name: "add_language"  },
      { path: '/add_reference_book/add_nationality', component: AddNationality, name: "add_nationality"  },
      { path: '/add_reference_book/add_partisanships', component: Partisanship, name: "add_partisanships"  },
      { path: '/add_reference_book/add_relativity', component: Relativity, name: "add_relativity"  },
      { path: '/add_reference_book/science_degree', component: ScienceDegree, name: "science_degree"  },
      { path: '/add_reference_book/add_vacation', component: VacationType, name: "add_vacation"  }
    ]
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
  {
    path: "/hire_employee",
    name: "hire_employee",
    component: HireEmployee,
  },

];

const router = new VueRouter({
  mode: "history",
  base: process.env.BASE_URL,
  routes
});

export default router;
