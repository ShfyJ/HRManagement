<template>
    <div>
        <!--<h1> Info about {{id}}</h1>-->
        <v-btn
            @click="back" 
            class="ma-2 btn btn-primary"
            outlined
            color="indigo"
    >
        Ortga
    </v-btn>
    <v-row>
      <v-col cols="12" md12>
        <div  md6>
        <v-list-item>
          <v-list-item-avatar size="50px">
            <v-img src="../../public/img3.jpg"></v-img>
          </v-list-item-avatar>
          <v-list-item-content>
            <v-list-item-title >Aziz Bohidjonov</v-list-item-title>
            <v-list-item-subtitle>Alisher o'g'li</v-list-item-subtitle>
          </v-list-item-content>
          <v-list-item-content class="text-right align-self-start">
            <v-list-item-title >Ikt departamenti Bo'lim nomi</v-list-item-title>
            <v-list-item-subtitle>Lavozimi</v-list-item-subtitle>
          </v-list-item-content>
        </v-list-item>
        </div>
        <v-divider ></v-divider>
      </v-col>
    </v-row>
    <v-row class="mb-n5">
        <v-col cols="12" sm="9">
          <div v-if="hide">
        <v-card class="rounded-xl ">
                <v-toolbar align="center" flat>
                    <v-toolbar-title>Asosiy ma'lumot</v-toolbar-title>
                </v-toolbar>
            <v-container
                id="user-profile"
                fluid
                tag="section"
            >
                <v-row justify="center">
                <v-col
                    cols="12"
                    md="11"
                >
                    <base-material-card>
                    <v-form        
                    ref="form"
                    v-model="valid"
                    lazy-validation
            >
                            <v-container class="py-0">
                            <v-row>
                                <!--<v-col
                                cols="12"
                                md="3"
                                >
                                <v-text-field
                                    class="purple-input"
                                    label="Passport Raqami"
                                    :rules="passportRules"
                                    v-model="passport"
                                    required
                                    

                                />
                                </v-col>
                                <v-col cols="12"
                                md="3">
                                <v-menu
                                ref="menu"
                                v-model="menu"
                                :close-on-content-click="false"
                                :return-value.sync="date"
                                transition="scale-transition"
                                offset-y
                                min-width="auto"
                                >
                                <template v-slot:activator="{ on, attrs }">
                                    <v-text-field
                                    v-model="date"
                                    label="Berilgan sanasi"
                                    prepend-icon="mdi-calendar"
                                    readonly
                                    v-bind="attrs"
                                    v-on="on"
                                    ></v-text-field>
                                </template>
                                <v-date-picker
                                    v-model="date"
                                    no-title
                                    scrollable
                                >
                                    <v-spacer></v-spacer>
                                    <v-btn
                                    text
                                    color="primary"
                                    @click="menu = false"
                                    >
                                    Cancel
                                    </v-btn>
                                    <v-btn
                                    text
                                    color="primary"
                                    @click="$refs.menu.save(date)"
                                    >
                                    OK
                                    </v-btn>
                                </v-date-picker>
                                </v-menu>
                                </v-col>
                                <v-col
                                cols="12"
                                md="3"
                                >
                                <v-text-field
                                    class="purple-input"
                                    label="Kim tomonidan berilgan"

                                />
                                </v-col>
                                -->
                                
                                <v-col cols="12"
                                md="9">
                                <v-row class="mt-n8"
                                >                     
                                <v-col
                                cols="12"
                                md="4"
                                >
                                <v-text-field
                                    label="Ismi"
                                    class="purple-input"
                                    v-model="name"
                                    required
                                    :rules="nameRules"

                                />
                                </v-col>

                                <v-col
                                cols="12"
                                md="4"
                                >
                                <v-text-field
                                    label="Familiyasi"
                                    class="purple-input"
                                    v-model="surname"
                                    required
                                    :rules="surnameRules"
                                />
                                </v-col>
                                <v-col
                                cols="12"
                                md="4"
                                >
                                <v-text-field
                                    label="Sharifi"
                                    class="purple-input"
                                    v-model="lastName"
                                    required
                                    :rules="lastNameRules"
                                />
                                </v-col>
                                </v-row>
                                <v-row class="mt-n10">
                                <v-col
                                cols="12"
                                md="6"
                                >
                                <v-text-field
                                    label="Ф.И.О.(қисқа):"
                                    class="purple-input"
                                    v-model="name"
                                    required
                                    :rules="nameRules"

                                />
                                </v-col>

                                <v-col
                                cols="12"
                                md="6"
                                >
                                <v-text-field
                                    label="Ф.И.(қисқа):"
                                    class="purple-input"
                                    v-model="name"
                                    required
                                    :rules="nameRules"

                                />
                                </v-col>
                                </v-row>
                                </v-col>
                            <v-col cols="12"
                                md="3">
                            <p>{{this.picture}}</p> 
                            <div class="hello mt-n12">   
                                
                                <picture-input 
                                ref="pictureInput" 
                                v-model="picture"
                                @change="onChange" 
                                width="160" 
                                height="160" 
                                margin="20" 
                                accept="image/jpeg,image/png" 
                                size="8" 
                                radius="10"
                                buttonClass="btn"
                                :customStrings="{
                                    upload: '<h1>Bummer!</h1>',
                                    drag: 'Surat yuklash'
                                }">
                                </picture-input>
                            </div>
                        </v-col>
                            </v-row>
                            </v-container>
                    </v-form>
                    </base-material-card>
                </v-col>
                <v-col
                    cols="12"
                    md="4"
                >
                </v-col>
                </v-row>
            </v-container>
        </v-card>

        <v-card class="rounded-xl mt-5 ">
                <v-toolbar align="center" flat>
                        <v-toolbar-title>Umumiy ma'lumot</v-toolbar-title>
                </v-toolbar>
            <v-container
                id="user-profile"
                fluid
                tag="section"
            >
                <v-row justify="center">
                <v-col
                    cols="12"
                    md="11"
                >
                    <base-material-card>
                    <v-form        
                    ref="form"
                    v-model="valid"
                    lazy-validation
            >
                            <v-container class="py-0">
                            <v-row class="mt-n8">

      <v-col cols="12" md="4">
      <v-select
                v-model="Uzbekistan"
                :items="countries"
                menu-props="auto"
                label="Tug'ilgan joyi"
                hide-details
                prepend-icon="mdi-map"
                single-line
              ></v-select>
      </v-col>
      <v-col cols="12" md="4">
        <v-select
          v-model="tuman"
          :items="tumanlar"
          menu-props="auto"
          label="Viloyati"
          hide-details
          single-line
        ></v-select>
      </v-col>
                <v-col
                  cols="12"
                  md="4"
                >
                  <v-text-field
                    label="Tuman/Shahar"
                    class="purple-input"
                  />
                </v-col>
                
                <v-col
                  cols="12"
                  md="4"
                >
                <v-select
                v-model="millat"
                :items="millatlar"
                  menu-props="auto"
                  label="MIllati"
                  hide-details
                  single-line
                  ></v-select>
                </v-col>
                <v-col
                  cols="12"
                  md="4">
                  <v-row justify="center" >
                  <v-radio-group
                  v-model="radios"
                  mandatory
                  row
                  label="Jinsi"
                  >
                  <v-radio
                  label="Erkak"
                  value="radio-1"
                  ></v-radio>
                  <v-radio
                  label="Ayol"
                  value="radio-2"
                  ></v-radio>
                  </v-radio-group>
                  </v-row>
                  </v-col>
                <v-col
                  cols="12"
                  md="4"
                >
                <v-select
                v-model="malumoti"
                :items="malumoti_inst"
                  menu-props="auto"
                  label="Ma'lumoti"
                  hide-details
                  single-line
                  ></v-select>
                </v-col>
                <!--<v-text-field
                    class="red-input"
                    label="Postal Code"
                    type="number"
                  />-->
                <v-col
                  cols="12"
                  md="3"
                >
                  <v-text-field
                    label="Tamomlagan ..."
                    class="purple-input"
                  />
                </v-col>
                <v-col
                  cols="12"
                  md="3"
                >
                  <v-text-field
                    label="Mutaxasisligi"
                    class="purple-input"
                  />
                </v-col>
                <v-col
                  cols="12"
                  md="3"
                >
                  <v-text-field
                    label="Ilmiy darajasi"
                    class="purple-input"
                  />
                </v-col>
                <v-col
                  cols="12"
                  md="3"
                >
                  <v-text-field
                    label="Ilmiy unvoni"
                    class="purple-input"
                  />
                </v-col>

                <v-col cols="12" md="4">
                <v-combobox
                clearable
                v-model="language"
                :items="languages"
                label="Chet tillarini bilishi"
                multiple
                chips
                >
          <template v-slot:selection="data">
            <v-chip
              :key="JSON.stringify(data.item)"
              v-bind="data.attrs"
              :input-value="data.selected"
              :disabled="data.disabled"
              @click:close="data.parent.selectItem(data.item)"
            >
              <v-avatar
                class="accent white--text"
                left
                v-text="data.item.slice(0, 1).toUpperCase()"
              ></v-avatar>
              {{ data.item }}
            </v-chip>
          </template>
        </v-combobox>
                </v-col>
                <v-col
                  cols="12"
                  md="8"
                >
                  <v-text-field 
                    label="Mukofotlari"
                    class="purple-input mt-3"
                  />
                </v-col>
                <v-col
                  cols="12"
                  md="4"
                >
                <v-select
                clearable
                v-model="army"
                :items="select_armyType"
                  menu-props="auto"
                  label="Xarbiy xizmatga borganligi"
                  hide-details
                  single-line
                  ></v-select>
                </v-col>
                <v-col
                  cols="12"
                  md="4"
                >
                  <v-text-field 
                    label="Xarbiy (maxsus) unvoni"
                    class="purple-input "
                  />
                </v-col>
                <v-col
                  cols="12"
                  md="4"
                >
                <v-select
                clearable
                v-model="nogironlik"
                :items="nogironligi"
                  menu-props="auto"
                  label="Nogironligi"
                  hide-details
                  single-line
                  ></v-select>
                </v-col>
                <v-col
                  cols="12"
                  md="6"
                >
                  <v-text-field
                    label="Kengash deputatligi ..."
                    class="purple-input"
                  />
                </v-col>
                <v-col
                  cols="12"
                  md="6"
                >
                <v-select
                clearable
                small-chips
                v-model="partiyaviylik"
                :items="partiyaviyligi"
                  menu-props="auto"
                  label="Partiyaviyligi"
                  hide-details
                  single-line
                  ></v-select>
                </v-col>
                </v-row>
                </v-container>
                </v-form>
                    </base-material-card>
                </v-col>
                <v-col
                    cols="12"
                    md="4"
                >
                </v-col>
                </v-row>
            </v-container>
        </v-card>

        <v-card class="rounded-xl mt-5">
            <v-toolbar align="center" flat>
                        <v-toolbar-title>Yashash joyi va aloqalar</v-toolbar-title>
            </v-toolbar>
            <v-container
                id="user-profile"
                fluid
                tag="section"
            >
                <v-row justify="center">
                <v-col
                    cols="12"
                    md="11"
                >
                    <base-material-card>
                        <v-row>
                <v-col cols="12" md="2">
                <v-select
                v-model="current_country"
                :items="countries"
                menu-props="auto"
                label="Mamlakat"
                hide-details
                prepend-icon="mdi-map"
                single-line
                ></v-select>
                </v-col>
                <v-col cols="12" md="2">
                <v-select
                v-model="current_tuman"
                :items="tumanlar"
                menu-props="auto"
                label="Viloyati"
                hide-details
                single-line
                ></v-select>
                </v-col>
                <v-col
                  cols="12"
                  md="2"
                >
                  <v-text-field
                    v-model="current_city"
                    label="Tuman/Shahar"
                    class="purple-input"
                  />
                </v-col>
                <v-col
                  cols="12"
                  md="2"
                >
                  <v-text-field
                    v-model="current_address"
                    label="Manzil"
                    class="purple-input"
                  />
                </v-col>
                <v-col
                cols="12"
                md="2"
                >
                <v-text-field
                v-model="email"
                :rules="[
                v => !!v || 'E-mail is required',
                v => /.+@.+/.test(v) || 'E-mail must be valid',
                ]"
                label="E-mail"
                required
                ></v-text-field>
                </v-col>
                <v-col
                  cols="12"
                  md="2"
                >
                  <v-text-field
                    phone
                    label="Raqam"
                    class="purple-input"
                    v-model="phone"
                    :rules="phoneRule"
                  />
                </v-col>
                        </v-row>
                    </base-material-card>
                </v-col>
                <v-col
                    cols="12"
                    md="4"
                >
                </v-col>
                </v-row>
            </v-container>
        </v-card>

        <v-card class="rounded-xl mt-5">
            <v-container
                id="user-profile"
                fluid
                tag="section"
            >
                <v-row justify="center">
                <v-col
                    cols="12"
                    md="11"
                >
                    <base-material-card>
                        <v-row>
                            <v-col
                  cols="12"
                  md="3"
                >
                  <v-text-field
                    class="purple-input"
                    label="Passport Raqami"
                    :rules="passportRules"
                    v-model="passport"
                    required
                    

                  />
                </v-col>
                <v-col cols="12"
                  md="3">
                <v-menu
                  ref="menu"
                  v-model="menu"
                  :close-on-content-click="false"
                  :return-value.sync="date"
                  transition="scale-transition"
                  offset-y
                  min-width="auto"
                  >
                  <template v-slot:activator="{ on, attrs }">
                    <v-text-field
                      v-model="date"
                      label="Berilgan sanasi"
                      prepend-icon="mdi-calendar"
                      readonly
                      v-bind="attrs"
                      v-on="on"
                    ></v-text-field>
                  </template>
                  <v-date-picker
                    v-model="date"
                    no-title
                    scrollable
                  >
                    <v-spacer></v-spacer>
                    <v-btn
                      text
                      color="primary"
                      @click="menu = false"
                    >
                      Cancel
                    </v-btn>
                    <v-btn
                      text
                      color="primary"
                      @click="$refs.menu.save(date)"
                    >
                      OK
                    </v-btn>
                  </v-date-picker>
                </v-menu>
                </v-col>
                <v-col
                  cols="12"
                  md="3"
                >
                  <v-text-field
                    class="purple-input"
                    label="Kim tomonidan berilgan"

                  />
                </v-col>
                <v-col>
                <v-menu
                    ref="menu1"
                    v-model="menu1"
                    :close-on-content-click="false"
                    :return-value.sync="date1"
                    transition="scale-transition"
                    offset-y
                    min-width="auto"
                >
                    <template v-slot:activator="{ on, attrs }">
                    <v-text-field
                        v-model="date1"
                        label="Amal qilishi"
                        prepend-icon="mdi-calendar"
                        readonly
                        v-bind="attrs"
                        v-on="on"
                    ></v-text-field>
                    </template>
                    <v-date-picker
                    v-model="date1"
                    no-title
                    scrollable
                    >
                    <v-spacer></v-spacer>
                    <v-btn
                        text
                        color="primary"
                        @click="menu1 = false"
                    >
                        Cancel
                    </v-btn>
                    <v-btn
                        text
                        color="primary"
                        @click="$refs.menu1.save(date1)"
                    >
                        OK
                    </v-btn>
                    </v-date-picker>
                </v-menu>
            </v-col>
                        </v-row>
                    </base-material-card>
                </v-col>
                <v-col
                    cols="12"
                    md="4"
                >
                </v-col>
                </v-row>
            </v-container>
        </v-card>
          </div>
          <div v-else>
            <router-view></router-view>
          </div>
        </v-col>
        <v-col cols="12" sm="3">
          <div class="mt-5">
            <v-card class="rounded-xl">
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
                         <v-btn text color="cyan"><v-icon right class="mr-5">
                           mdi-plus
                         </v-icon></v-btn>
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
                         <strong>Ta'tillar</strong>
                         <v-spacer></v-spacer>
                         <v-btn text color="cyan"><v-icon right class="mr-5">
                           mdi-plus
                         </v-icon></v-btn>
                       </v-app-bar>
                       <v-app-bar flat color="rgba(0,0,0,0)">
                         <v-icon right class="mr-5">
                           mdi-alert-circle
                         </v-icon>
                         <strong>Intizomiy jazolar</strong>
                         <v-spacer></v-spacer>
                         <v-btn text color="cyan"><v-icon right class="mr-5">
                           mdi-plus
                         </v-icon></v-btn>
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
                         <strong>Yig'ma jild</strong>
                         <v-spacer></v-spacer>
                        <v-btn text color="cyan"><v-icon right class="mr-5">
                           mdi-plus
                         </v-icon></v-btn>
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
            hide: false,
            headers: [
          {
            text: 'Dessert (100g serving)',
            align: 'start',
            value: 'name',
          },
          { text: 'Category', value: 'category' },
        ],
        desserts: [
          {
            name: 'Frozen Yogurt',
            category: 'Ice cream',
          },
          {
            name: 'Ice cream sandwich',
            category: 'Ice cream',
          },
          {
            name: 'Eclair',
            category: 'Cookie',
          },
          {
            name: 'Cupcake',
            category: 'Pastry',
          },
          {
            name: 'Gingerbread',
            category: 'Cookie',
          },
          {
            name: 'Jelly bean',
            category: 'Candy',
          },
          {
            name: 'Lollipop',
            category: 'Candy',
          },
          {
            name: 'Honeycomb',
            category: 'Toffee',
          },
          {
            name: 'Donut',
            category: 'Pastry',
          },
          {
            name: 'KitKat',
            category: 'Candy',
          },
        ],
        
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
</style>