<template>
  <nav>
    <v-app-bar :elevation="5" color="#4da6ff" dark app>
      <v-app-bar-nav-icon 
          @click.stop="mini = !mini"> </v-app-bar-nav-icon>
      <v-toolbar-title class="text-uppercase">
        <span class="font-weight-light"></span>
        <img class="mr-3 mt-2 logo" :src="require('../assets/logo3.png')" height="120"   @click.stop="mini = !mini"/>
        <!--<span>{{$t("logo")}}</span>-->
      </v-toolbar-title>
      <v-spacer></v-spacer>
      <LocaleSwitcher/>
      <Kirish/>      
    </v-app-bar>
    <v-navigation-drawer 
      v-model="drawer"
      :mini-variant.sync="mini"
      permanent
      :width="300" 
      height="100%"
      dark app :elevation="5" color="#1a8cff" class="darken-0"
    >
      <v-list flat  class="mt-16 navbar_top">
        <v-list-item
          link
          class="mt-30 "
          :to="'/login'"
        >
          <v-list-item-icon class="myTitle">
            <v-icon>home-city</v-icon>
          </v-list-item-icon>
          <v-list-item-content>
            <v-list-item-title  class="myTitle">{{$t("main_menu")}}</v-list-item-title>
          </v-list-item-content>
        </v-list-item>

        <v-list-item
          class="mt-30"
        >
          <v-list-item-icon class="myTitle">
            <v-icon>mdi-account-search</v-icon>
          </v-list-item-icon>
          <v-card
            class="mx-auto"
            max-width="400"
            width="210"
          >
            <v-sheet  class="pa-4 dodger blue">
              <v-text-field
                v-model="search"
                :label="$t('search')"
                dark
                flat
                solo-inverted
                hide-details
                clearable
                clear-icon="mdi-close-circle-outline"
              ></v-text-field>
            </v-sheet>
            
            <v-card-text class="dodger blue">
              <v-treeview
                :items="items"
                :search="search"
                :filter="filter"
                rounded
                hoverable
                class="myTitle"
              >
                <template v-slot:prepend="{ item }">
                  <v-icon
                    v-if="item.children"
                    v-text="`mdi-${item.id === 1 ? 'book-open' : 'folder-network'}`"
                  ></v-icon>
                </template>
                <template  slot="label" slot-scope="props">
                        <router-link style="text-decoration: none; color: inherit;" :to="props.item.route" v-if="props.item.route">{{ props.item.name }}</router-link>
                        <span v-else>{{ props.item.name }}</span>
                    </template>
              </v-treeview>
            </v-card-text>
          </v-card>
        </v-list-item>

      </v-list>
    </v-navigation-drawer>
  </nav>




</template>
<script>
import LocaleSwitcher from "@/components/LocaleSwitcher";
import Kirish from "@/components/kirish";

export default {
  created:{
    setCookie(){
         // it sets the cookie called `username`
        this.$cookies.set("username","gowtham","1d");
        console.log(this.$cookies.get("username"))
    }
  },
  data: () => ({
    items: [
        {
          id: 1,
          name: 'Telefon kitobi',
          children: [
            {
              id: 201,
              name: 'Uzbekneftgaz',
              children: [
                {
                  id: 301,
                  name: 'Ikt',
                  children: [
                    {
                      id: 401,
                      name: 'ERP',
                      route: "/list_contact"
                    }]
                  
                },
                {
                  id: 302,
                  name: 'text',
                  route: "/login"
                },
                {
                  id: 303,
                  name: 'text1',
                  route: "/login"
                },
                {
                  id: 304,
                  name: 'text2',
                  route: "/login"
                },
                {
                  id: 305,
                  name: 'text3',
                  route: "/login"
                },
              ],
            },
            {
              id: 202,
              name: 'SHNGDU',
              children: [
                {
                  id: 306,
                  name: 'text4',
                  route: "/login"
                },
                {
                  id: 307,
                  name: 'text5',
                  route: "/login"
                },
              ],
            },
            {
              id: 203,
              name: 'NGPZ',
              children: [
                {
                  id: 308,
                  name: 'text6',
                  route: "/login"
                },
                {
                  id: 309,
                  name: 'text7',
                  route: "/login"
                },
                {
                  id: 310,
                  name: 'text8',
                  route: "/login"
                },
              ],
            },
          ],
        },
      ],
      open: [1, 2],
      search: null,
      caseSensitive: false,


//////a navigation drawer
    drawer: true,
    mini: false,
//////

  }),
  
  components: {
    LocaleSwitcher,
    Kirish,
  },
      computed: {
      filter () {
        return this.caseSensitive
          ? (item, search, textKey) => item[textKey].indexOf(search) > -1
          : undefined
      },
    },
};
</script>
<style scoped>
.data{
font-size: 25px !important;
}
.navbar_top{
  margin-top: 180px !important;
}

router-link{
    text-decoration: none;
}
.myTitle{
  font-size: 22px !important;
  font-family: 'Bookman', serif;
}
.logo{
  cursor: pointer
}

</style>

