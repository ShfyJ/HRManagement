<template>
<div>
        <v-card class="rounded-xl mt-5">
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

        <v-card class="rounded-xl mt-2">
                <v-toolbar align="center" flat>
                        <v-toolbar-title>Umumiy ma'lumot</v-toolbar-title>
                </v-toolbar>
                <v-container class="py-0">
                  <v-row class="ml-10 mr-10">
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
                  </v-row>
                  <v-row class="mt-n8 ml-10 mr-10">
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
                  value="Male"
                  ></v-radio>
                  <v-radio
                  label="Ayol"
                  value="Female"
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
                  </v-row>
                  <v-row class="mt-n3 ml-10 mr-10">
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
                  </v-row>
                  <v-row class="mt-n10 ml-10 mr-10">
                    
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
                  </v-row>
                  <v-row class="mt-n8 ml-10 mr-10">
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
                  </v-row>
                  <v-row class="mt-n8 ml-10 mr-10"> 
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

        <v-card class="rounded-xl mt-2">
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
</template>
<script>
import PictureInput from 'vue-picture-input'

export default {
  data(){
    return{
      id: this.$route.params['id'],
    }
  },

  components: {
    PictureInput
    },
}
</script>
