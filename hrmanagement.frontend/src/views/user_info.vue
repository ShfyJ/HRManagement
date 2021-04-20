<template>
    <div>
        <!--<h1> Info about {{id}}</h1>-->
    <v-row>
      <v-col cols="12" md12>
        <div  md6>
        <v-list-item>
              <v-btn
                    @click="back" 
                    class="ma-2 btn btn-primary"
                    outlined
                    color="blue"
              >
                <v-icon>
                  mdi-chevron-left
                </v-icon>
              </v-btn>
          <v-list-item-avatar size="50px">
            <v-img src="../../public/img3.jpg"></v-img>
          </v-list-item-avatar>
          <v-row>
            <v-col cols="12" md="2">
                <v-list-item-content class="ml-5">
                <v-list-item-title >Aziz Bohidjonov</v-list-item-title>
                <v-list-item-subtitle>Alisher o'g'li</v-list-item-subtitle>
              </v-list-item-content>
            </v-col>
            <v-col class="ml-n16" cols="12" md="2">
                <v-list-item-content class="text-left align-self-start">
                <v-list-item-title >Ikt departamenti Bo'lim nomi</v-list-item-title>
                <v-list-item-subtitle>Lavozimi</v-list-item-subtitle>
              </v-list-item-content>
            </v-col>
          </v-row>
        </v-list-item>
        </div>
        <v-divider ></v-divider>
      </v-col>
    </v-row>
    <v-row class="mb-n5 mt-n6">
        <v-col cols="12" sm="10">
          <div>
            <transition name="fade" mode="out-in">
            <router-view></router-view>
            </transition>
          </div>
        </v-col>
        <v-col cols="12" sm="2">
          <div class="mt-5">
            <v-card class="rounded-xl" :elevation="4">
                       <v-toolbar align="center" flat>
                         <v-toolbar-title>Menyu</v-toolbar-title>
                         <v-spacer></v-spacer>
                       </v-toolbar>
                       <v-app-bar flat color="rgba(0,0,0,0)">
                         <v-icon right class="mr-5">
                           mdi-file-document-multiple
                         </v-icon>
                         <strong>Umumiy ma'lumot</strong>
                         <v-spacer></v-spacer>
                         <v-btn text color="cyan">
                           <router-link style="text-decoration: none"  :to="{ name: 'umumiy_malumot'}" >
                             <v-icon right class="mr-5">
                           mdi-plus
                         </v-icon>
                         </router-link>
                         </v-btn>
                       </v-app-bar>
                       <v-app-bar flat color="rgba(0,0,0,0)">
                         <v-icon right class="mr-5">
                           mdi-store-24-hour
                         </v-icon>
                         <strong>Mehnat faoliyati</strong>
                         <v-spacer></v-spacer>
                         <v-btn text color="cyan">
                           <router-link style="text-decoration: none"  :to="{ name: 'mehnat_faoliyati'}" >
                           <v-icon right class="mr-5">
                              mdi-plus
                         </v-icon>
                         </router-link>
                        </v-btn>
                       </v-app-bar>
                       <v-app-bar flat color="rgba(0,0,0,0)">
                         <v-icon right class="mr-5">
                           mdi-family-tree
                         </v-icon>
                         <strong>Qarindoshlar</strong>
                         <v-spacer></v-spacer>
                         <v-btn text color="cyan">
                           <router-link style="text-decoration: none"  :to="{ name: 'add_relatives'}" >
                           <v-icon right class="mr-5">
                           mdi-plus
                         </v-icon>
                         </router-link>
                         </v-btn>
                       </v-app-bar>
                       <v-app-bar flat color="rgba(0,0,0,0)">
                         <v-icon right class="mr-5">
                           mdi-cast-education
                         </v-icon>
                         <strong>Ma'lumoti</strong>
                         <v-spacer></v-spacer>
                         <v-btn text color="cyan">
                           <router-link style="text-decoration: none"  :to="{ name: 'malumoti'}" >
                           <v-icon right class="mr-5">
                           mdi-plus
                         </v-icon>
                           </router-link>
                           </v-btn>
                       </v-app-bar>
                       <v-app-bar flat color="rgba(0,0,0,0)">
                         <v-icon right class="mr-5">
                           mdi-airplane-takeoff
                         </v-icon>
                         <strong>Xizmat safari</strong>
                         <v-spacer></v-spacer>
                         <v-btn text color="cyan"><v-icon right class="mr-5">
                           mdi-plus
                         </v-icon></v-btn>
                       </v-app-bar>
                       <v-app-bar flat color="rgba(0,0,0,0)">
                         <v-icon right class="mr-5">
                           mdi-calendar
                         </v-icon>
                         <strong>Ta'til</strong>
                         <v-spacer></v-spacer>
                         <v-btn text color="cyan">
                           <router-link style="text-decoration: none"  :to="{ name: 'add_tatil'}" >
                           <v-icon right class="mr-5">
                           mdi-plus
                         </v-icon>
                         </router-link>
                         </v-btn>
                       </v-app-bar>
                       <v-app-bar flat color="rgba(0,0,0,0)">
                         <v-icon right class="mr-5">
                           mdi-alert-circle
                         </v-icon>
                         <strong>Intizomiy jazolar</strong>
                         <v-spacer></v-spacer>
                         <v-btn text color="cyan">
                           <router-link style="text-decoration: none"  :to="{ name: 'intizomiy_jazolar'}" >
                           <v-icon right class="mr-5">
                           mdi-plus
                         </v-icon>
                           </router-link>
                         </v-btn>
                       </v-app-bar>
                       <v-app-bar flat color="rgba(0,0,0,0)">
                         <v-icon right class="mr-5">
                           mdi-certificate
                         </v-icon>
                         <strong>Mukofotlash</strong>
                         <v-spacer></v-spacer>
                         <v-btn text color="cyan"><v-icon right class="mr-5">
                           mdi-plus
                         </v-icon></v-btn>
                       </v-app-bar>
                        <v-app-bar flat color="rgba(0,0,0,0)">
                         <v-icon right class="mr-5">
                           mdi-file-word
                         </v-icon>
                         <strong>Nusxalar</strong>
                         <v-spacer></v-spacer>
                        <v-btn text color="cyan">
                          <router-link style="text-decoration: none"  :to="{ name: 'yigma_jild'}" >
                          <v-icon right class="mr-5">
                           mdi-plus
                         </v-icon>
                          </router-link>
                         </v-btn>
                       </v-app-bar>
                     </v-card>
          </div>
        </v-col>
    </v-row>

    </div>
</template>
<script>

export default {
    data(){
        return{
            id: this.$route.params['id'],
            hide: this.$store.state.hide,


        
        }
    },
    watch:{
        $route(toRoute){
            this.id=toRoute.params['id']
        }
    },
    methods:{
        back(){
            this.$router.push({name: 'team'})
        }
    },

}
</script>
<style scoped>
.borderLeft{
border-radius: 50px 0px 50px 0px !important;
}
.borderRight{
  border-radius: 0px 50px 0px 50px !important;
}
.border{
  border: 2px solid white !important;
}

.fade-enter-active,
.fade-leave-active {
  transition-duration: 0.3s;
  transition-property: opacity;
  transition-timing-function: ease;
}

.fade-enter,
.fade-leave-active {
  opacity: 0
}
</style>