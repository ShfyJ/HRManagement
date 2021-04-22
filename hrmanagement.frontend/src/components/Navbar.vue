<template>
  <nav>
    <v-app-bar :elevation="5" color="#4da6ff" dark app>
      <v-app-bar-nav-icon @click.stop="drawer = !drawer"> </v-app-bar-nav-icon>
      <v-toolbar-title class="text-uppercase">
        <span class="font-weight-light"></span>
        <img class="mr-3 mt-2" :src="require('../assets/logo3.png')" height="120"/>
      </v-toolbar-title>
      <v-spacer></v-spacer>
      <LocaleSwitcher/>
      <v-btn text 
        v-for="item in items"
            :key="item.title"
            router
            :to="item.route"
      >
        <span>{{item.title}}</span>
        <v-icon right>exit_to_app</v-icon>
      </v-btn>
    </v-app-bar>

    <v-navigation-drawer  :width="300" v-model="drawer" dark app color="#1a8cff" :elevation="10">
      <v-layout column align-center>
        <v-flex class="mt-5">
          <v-avatar style="cursor: pointer;" size="100"  @click.stop="drawer = !drawer" @click="profileChange" >
            <v-img  src="/img3.jpg"></v-img>
          </v-avatar>
          <p class="white--text subheading mt-7 text-center" >Aziz Bohidjonov</p>
        </v-flex>
      </v-layout>

      <v-list flat  class="mt-14">
        <v-list-item
          v-for="link in links"
          :key="link.text"
          router
          :to="link.route"
          active-class="border"
        >
          <v-list-item-action>
            <v-icon>
              {{ link.icon }}
            </v-icon>
          </v-list-item-action>
          <v-list-item-content>
            <v-list-item-title class="myTitle"> 
              {{ link.text }}
            </v-list-item-title>
          </v-list-item-content>
        </v-list-item>
        
        <v-list-group prepend-icon="mdi-book-open" color="white">
          <template v-slot:activator>
            <v-list-item-title class="myTitle">Shtatka</v-list-item-title>
          </template>
          <v-list-group no-action sub-group color="white">
            <template v-slot:activator>
              <v-list-item-content>
                <v-list-item-title>Uzbekneftgaz</v-list-item-title>
              </v-list-item-content>
            </template>
            
            <v-list-item
              v-for="admin in admins"
              :key="admin.text"
              router
              :to="admin.route"
              active-class="border"
            >
              <v-list-item-title>{{ admin.text }}</v-list-item-title>

              <v-list-item-icon>
                <v-icon>{{ admin.icon }}</v-icon>
              </v-list-item-icon>
            </v-list-item>
          </v-list-group>
          <v-list-group color="white" no-action sub-group>
            <template v-slot:activator>
              <v-list-item-content>
                <v-list-item-title>Sho'rtan</v-list-item-title>
              </v-list-item-content>
            </template>

            <v-list-item v-for="([title, icon], i) in cruds" :key="i" link>
              <v-list-item-title v-text="title"></v-list-item-title>
              <v-list-item-icon>
                <v-icon v-text="icon"></v-icon>
              </v-list-item-icon>
            </v-list-item>
          </v-list-group>
        </v-list-group>


                <v-list-group prepend-icon="mdi-account-plus" color="white">
          <template v-slot:activator>
            <v-list-item-title class="myTitle">Ishga olish</v-list-item-title>
          </template>
          <v-list-group no-action sub-group color="white">
            <template v-slot:activator>
              <v-list-item-content>
                <v-list-item-title>Uzbekneftgaz</v-list-item-title>
              </v-list-item-content>
            </template>
            
            <v-list-item
              v-for="admin in admins"
              :key="admin.text"
              router
              :to="admin.route"
              active-class="border"
            >
              <v-list-item-title>{{ admin.text }}</v-list-item-title>

              <v-list-item-icon>
                <v-icon>{{ admin.icon }}</v-icon>
              </v-list-item-icon>
            </v-list-item>
          </v-list-group>
          <v-list-group color="white" no-action sub-group>
            <template v-slot:activator>
              <v-list-item-content>
                <v-list-item-title>Sho'rtan</v-list-item-title>
              </v-list-item-content>
            </template>

            <v-list-item v-for="([title, icon], i) in cruds" :key="i" link>
              <v-list-item-title v-text="title"></v-list-item-title>
              <v-list-item-icon>
                <v-icon v-text="icon"></v-icon>
              </v-list-item-icon>
            </v-list-item>
          </v-list-group>
        </v-list-group>
      </v-list>
    </v-navigation-drawer>
  </nav>
</template>
<script>
import LocaleSwitcher from "@/components/LocaleSwitcher";

export default {
  methods: {
    profileChange(){
      this.$router.push({ name: 'profile_assistant_info' });
      
    }
  },

data: () => ({
    drawer: true,
    items: [
        {
          icon: 'exit_to_app',   
          title: 'Chiqish',
          route: "/login"
        },
      ],
    links: [
      { icon: "mdi-home", text: "Asosiy Menu", route: "/" },
      {
        icon: "mdi-sitemap",
        text: "Tarkibiy tuzilma",
        route: "/projects"
      },
      {
        icon: "mdi-account-multiple-outline",
        text: "Shaxsiy varaqalar",
        route: "/team"
      }
    ],
    admins: [
      { text: "Department1", icon: "mdi-right", route: "/hire_employee" },
      { text: "Department2", icon: "mdi-", route: "/contact1" }
    ],
    cruds: [
      ["Create", "mdi-plus-outline"],
      ["Read", "mdi-file-outline"],
      ["Update", "mdi-update"],
      ["Delete", "mdi-delete"]
    ],

  }),
  components: {
    LocaleSwitcher
  },
  
};
</script>
<style scoped>
.border {
  border-left: 4px solid #0ba518;
}
.myTitle{
  font-size: 22px !important;
  font-family: 'Trocchi', serif;
}
</style>
