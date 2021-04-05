<template>
<div>
  <template v-if="!$route.meta.allowAnonymous">
  <v-app style="background-color: #f5f5f5" >
    <Navbar />
    <v-content class="ma-4">
      <router-view> </router-view>
    </v-content>
    <Footer />
  </v-app>
  </template>
  <template v-else>
      <v-app style="background-color: #f5f5f5">
    <LoginNavbar />
    <v-content class="ma-4">
      <router-view> </router-view>
    </v-content>
    <Footer />
  </v-app>
      <!--<transition>
        <keep-alive>
            <router-view> </router-view>
        </keep-alive>
      </transition>-->
    </template>
</div>
</template>
<script>
import Navbar from "@/components/Navbar";
import Footer from "@/components/Footer";
import LoginNavbar from "@/components/Login_navbar";


export default {
  name: "App",
  components: {
    Navbar,
    Footer,
    LoginNavbar
    
  }
};
</script>
