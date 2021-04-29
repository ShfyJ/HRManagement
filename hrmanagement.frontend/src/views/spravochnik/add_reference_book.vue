<template>
<div>
    <v-row class="ml-2 mb-n5 mt-n6">
        <v-col cols="12" sm="3">
          <div class="mt-5">
            <v-card  :elevation="4">
                       <v-toolbar align="center" flat>
                         <v-toolbar-title>Menyu</v-toolbar-title>
                         <v-spacer></v-spacer>
                       </v-toolbar>
                       <v-app-bar flat color="rgba(0,0,0,0)">
                         <v-icon right class="mr-5">
                           mdi-map
                         </v-icon>
                         <strong>Mamlakat qo'shish</strong>
                         <v-spacer></v-spacer>
                         <v-btn text color="cyan">
                           <router-link style="text-decoration: none"  :to="{ name: 'add_country'}" >
                             <v-icon right class="mr-5">
                           mdi-plus
                         </v-icon>
                         </router-link>
                         </v-btn>
                       </v-app-bar>
                       <v-app-bar flat color="rgba(0,0,0,0)">
                         <v-icon right class="mr-5">
                           mdi-map-marker-circle
                         </v-icon>
                         <strong>Region qo'shish</strong>
                         <v-spacer></v-spacer>
                         <v-btn text color="cyan">
                           <router-link style="text-decoration: none"  :to="{ name: 'add_region'}" >
                           <v-icon right class="mr-5">
                              mdi-plus
                         </v-icon>
                         </router-link>
                        </v-btn>
                       </v-app-bar>
                       <v-app-bar flat color="rgba(0,0,0,0)">
                         <v-icon right class="mr-5">
                           mdi-map-marker
                         </v-icon>
                         <strong>Tuman qo'shish</strong>
                         <v-spacer></v-spacer>
                         <v-btn text color="cyan">
                           <router-link style="text-decoration: none"  :to="{ name: 'add_district'}" >
                           <v-icon right class="mr-5">
                           mdi-plus
                         </v-icon>
                         </router-link>
                         </v-btn>
                       </v-app-bar>
                       <v-app-bar flat color="rgba(0,0,0,0)">
                         <v-icon right class="mr-5">
                           mdi-translate
                         </v-icon>
                         <strong>Til qo'shish</strong>
                         <v-spacer></v-spacer>
                         <v-btn text color="cyan">
                           <router-link style="text-decoration: none"  :to="{ name: 'add_language'}" >
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
                         <strong>Millat qo'shish</strong>
                         <v-spacer></v-spacer>
                         <v-btn text color="cyan">
                           <router-link style="text-decoration: none"  :to="{ name: 'add_nationality'}" >
                           <v-icon right class="mr-5">
                           mdi-plus
                         </v-icon>
                         </router-link>
                         </v-btn>
                       </v-app-bar>
                       <v-app-bar flat color="rgba(0,0,0,0)">
                         <v-icon right class="mr-5">
                           mdi-gavel
                         </v-icon>
                         <strong>Pariyaviylik qo'shish</strong>
                         <v-spacer></v-spacer>
                         <v-btn text color="cyan">
                           <router-link style="text-decoration: none"  :to="{ name: 'add_partisanships'}" >
                           <v-icon right class="mr-5">
                           mdi-plus
                         </v-icon>
                         </router-link>
                         </v-btn>
                       </v-app-bar>
                       <v-app-bar flat color="rgba(0,0,0,0)">
                         <v-icon right class="mr-5">
                           mdi-human-male-female
                         </v-icon>
                         <strong>Qarindosh qo'shish</strong>
                         <v-spacer></v-spacer>
                         <v-btn text color="cyan">
                           <router-link style="text-decoration: none"  :to="{ name: 'add_relativity'}" >
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
                         <strong>Ilmiy unvon qo'shish</strong>
                         <v-spacer></v-spacer>
                         <v-btn text color="cyan">
                           <router-link style="text-decoration: none"  :to="{ name: 'science_degree'}" >
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
                         <strong>Ta'til turi qo'shish</strong>
                         <v-spacer></v-spacer>
                         <v-btn text color="cyan">
                           <router-link style="text-decoration: none"  :to="{ name: 'add_vacation'}" >
                           <v-icon right class="mr-5">
                           mdi-plus
                         </v-icon>
                           </router-link>
                         </v-btn>
                       </v-app-bar>
                     </v-card>
          </div>
        </v-col>
        <v-col cols="12" sm="9">
          <div>
            <transition name="fade" mode="out-in">
            <router-view></router-view>
            </transition>
          </div>
        </v-col>
    </v-row>
</div>
</template>