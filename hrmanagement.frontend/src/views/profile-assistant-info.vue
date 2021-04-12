<template>
  <v-card >
    <v-tabs
      v-model="tab"
      background-color="transparent"
      grow
    >
      <v-tab>
        <v-icon left>
          mdi-account
        </v-icon>
        Malumotlarni ozgartirish
      </v-tab>
      <v-tab>
        <v-icon left>
          mdi-lock
        </v-icon>
        Parolni ozgartirish
      </v-tab>
      <v-tab-item class="mt-10 ml-10">
      <v-layout row>
      <v-flex md3>
        <v-app>
          <v-container>
            <v-flex>
              <v-card class=" mb-5 ma-5 text-center mt-12" shaped elevation="10">
                <v-avatar class="mt-n7" size="60" elevation="10">
                  <img src="/img3.jpg" />
                </v-avatar>
                <v-card-title class="layout justify-center">Aziz Bohidjonov</v-card-title>
                <v-card-subtitle class="layout justify-center">Adminstrator</v-card-subtitle>

                  <p>{{this.picture}}</p> 
                <div >   
                <picture-input 
                  ref="pictureInput" 
                  v-model="picture"
                  @change="onChange" 
                  width="180" 
                  height="180" 
                  margin="20" 
                  accept="image/jpeg,image/png" 
                  size="8" 
                  radius="10"
                  buttonClass="btn"
                  :color="red"
                  :customStrings="{
                    upload: '<h1>Bummer!</h1>',
                    drag: 'Surat yuklash',
                    change: 'Suratni Ozgartirish', 
                    fileSize: 'The file size exceeds the limit'
                  }">
                </picture-input>
          </div>

                <!--<v-list-item three-line>
                  <v-list-item-avatar size="60" color="cyan darken-1">
                    <v-icon color="white">mdi-plus</v-icon>
                  </v-list-item-avatar>
                </v-list-item>-->
                <v-row>
                  <v-col class="mt-5">

                  </v-col>
                </v-row>
              </v-card>
            </v-flex>
          </v-container>
        </v-app>
      </v-flex>
      <v-flex md1>
              
      </v-flex>
      <v-flex md8>
        <v-app  class="rounded" >
        <v-container shaped elevation="10">
            <v-flex>
              <v-list class="mt-5">
                <v-list-item>
                  <v-list-item-title class="cyan--text text--darken-1">Asosiy Ma'lumot</v-list-item-title>
                  <!--<v-list-item-action>
                    <v-btn class="ma-2" tile outlined color="cyan darken-1">
                      <v-icon left>fas fa-eye</v-icon>See All
                    </v-btn>
                  </v-list-item-action>-->
                </v-list-item>
              </v-list>
            </v-flex>
            <v-flex>
              <v-row no-gutters>
                  <v-col cols="12" md="4" >
                   <v-row>
                     <v-col cols="12" md="10">
                       <v-list two-line subheader class="ml-n8">
                  <v-list-item>
                    <v-list-item-content>
                    <v-col
                    cols="12">
                              <v-text-field
                                v-model="message4"
                                label="text"
                                outlined
                                clearable
                              ></v-text-field>
                      </v-col>
                    </v-list-item-content>
                  </v-list-item>
                </v-list>
                     </v-col>
                   </v-row>
                  </v-col>
                  <v-col cols="12" md="4">
                    <v-row>
                      <v-col cols="12" md="10">
                        <v-list two-line subheader class="ml-n8">
                          <v-list-item>
                            <v-list-item-content>
                              <v-col
                                cols="12"
                                    >
                                      <v-text-field
                                        v-model="message4"
                                        label="text"
                                        outlined
                                        clearable
                                      ></v-text-field>
                              </v-col>
                            </v-list-item-content>
                          </v-list-item>
                        </v-list>
                    </v-col>
                  </v-row>
                  </v-col>
                  <v-col cols="12" md="4">
                    <v-row>
                    <v-col cols="12" md="10">
                      <v-list two-line subheader class="ml-n8">
                  <v-list-item>
                    <v-list-item-content>
                      <v-col
                      cols="12"
                            >
                              <v-text-field
                                v-model="message4"
                                label="text"
                                outlined
                                clearable
                              ></v-text-field>
                      </v-col>
                    </v-list-item-content>
                  </v-list-item>
                </v-list>
                     </v-col>
                   </v-row>
                  </v-col>
                  <v-col cols="12" md="4">
                    <v-row>
                    <v-col cols="12" md="10">
                      <v-list two-line subheader class="ml-n8">
                  <v-list-item>
                    <v-list-item-content>
                      <v-col
                      cols="12"
                            >
                              <v-text-field
                                v-model="message4"
                                label="text"
                                outlined
                                clearable
                              ></v-text-field>
                      </v-col>
                    </v-list-item-content>
                  </v-list-item>
                </v-list>
                     </v-col>
                   </v-row>
                  </v-col>
                  <v-col cols="12" md="4">
                    <v-row>
                    <v-col cols="12" md="10">
                      <v-list two-line subheader class="ml-n8">
                  <v-list-item>
                    <v-list-item-content>
                      <v-col
                      cols="12"
                            >
                              <v-text-field
                                v-model="message4"
                                label="text"
                                outlined
                                clearable
                              ></v-text-field>
                      </v-col>
                    </v-list-item-content>
                  </v-list-item>
                </v-list>
                     </v-col>
                   </v-row>
                  </v-col>
                  <v-col cols="12" md="4">
                    <v-row>
                    <v-col cols="12" md="10">
                      <v-list two-line subheader class="ml-n8">
                  <v-list-item>
                    <v-list-item-content>
                      <v-col
                      cols="12"
                            >
                              <v-text-field
                                v-model="message4"
                                label="text"
                                outlined
                                clearable
                              ></v-text-field>
                      </v-col>
                    </v-list-item-content>
                  </v-list-item>
                </v-list>
                     </v-col>
                   </v-row>
                  </v-col>
                  <v-col cols="12" md="4">
                    <v-row>
                    <v-col cols="12" md="10">
                      <v-list two-line subheader class="ml-n8">
                  <v-list-item>
                    <v-list-item-content>
                      <v-col
                      cols="12"
                            >
                              <v-text-field
                                v-model="message4"
                                label="text"
                                outlined
                                clearable
                              ></v-text-field>
                      </v-col>
                    </v-list-item-content>
                  </v-list-item>
                </v-list>
                     </v-col>
                   </v-row>
                  </v-col>
                  <v-col cols="12" md="4">
                    <v-row>
                    <v-col cols="12" md="10">
                      <v-list two-line subheader class="ml-n8">
                  <v-list-item>
                    <v-list-item-content>
                      <v-col
                      cols="12"
                            >
                              <v-text-field
                                v-model="message4"
                                label="text"
                                outlined
                                clearable
                              ></v-text-field>
                      </v-col>
                    </v-list-item-content>
                  </v-list-item>
                </v-list>
                     </v-col>
                   </v-row>
                  </v-col>
                  <v-col cols="12" md="4">
                    <v-row>
                    <v-col cols="12" md="10">
                      <v-list two-line subheader class="ml-n8">
                  <v-list-item>
                    <v-list-item-content>
                      <v-col
                      cols="12"
                            >
                              <v-text-field
                                v-model="message4"
                                label="text"
                                outlined
                                clearable
                              ></v-text-field>
                      </v-col>
                    </v-list-item-content>
                  </v-list-item>
                </v-list>
                     </v-col>
                   </v-row>
                  </v-col>
                  <v-col cols="12" md="4">
                    <v-row>
                    <v-col cols="12" md="10">
                      <v-list two-line subheader class="ml-n8">
                  <v-list-item>
                    <v-list-item-content>
                      <v-col
                      cols="12"
                            >
                              <v-text-field
                                v-model="message4"
                                label="text"
                                outlined
                                clearable
                              ></v-text-field>
                      </v-col>
                    </v-list-item-content>
                  </v-list-item>
                </v-list>
                     </v-col>
                   </v-row>
                  </v-col>
                  <v-col cols="12" md="4">
                    <v-row>
                    <v-col cols="12" md="10">
                      <v-list two-line subheader class="ml-n8">
                  <v-list-item>
                    <v-list-item-content>
                      <v-col
                      cols="12"
                            >
                              <v-text-field
                                v-model="message4"
                                label="text"
                                outlined
                                clearable
                              ></v-text-field>
                      </v-col>
                    </v-list-item-content>
                  </v-list-item>
                </v-list>
                     </v-col>
                   </v-row>
                  </v-col>
                  <v-col cols="12" md="4">
                    <v-row>
                    <v-col cols="12" md="10">
                      <v-list two-line subheader class="ml-n8">
                  <v-list-item>
                    <v-list-item-content>
                      <v-col
                      cols="12"
                            >
                              <v-text-field
                                v-model="message4"
                                label="text"
                                outlined
                                clearable
                              ></v-text-field>
                      </v-col>
                    </v-list-item-content>
                  </v-list-item>
                </v-list>
                     </v-col>
                   </v-row>
                  </v-col>
              </v-row>
            </v-flex>
             <v-flex>
            </v-flex>
          </v-container>
        </v-app>
      </v-flex>
    </v-layout>
        <!--<v-card flat>
            <v-form v-model="valid">
                <v-container class="col-lg-6 col-12 ">
                <v-row
                class="mt-8 justify-xl-center justify-lg-space-between justify-center">
                    <v-col
                    cols="12"
                    md="4"
                    >
                    <v-text-field
                        v-model="firstname"
                        :rules="nameRules"
                        
                        label="Ism"
                        required
                    ></v-text-field>
                    </v-col>

                    <v-col
                    cols="12"
                    md="4"
                    >
                    <v-text-field
                        v-model="Familiya"
                        :rules="nameRules"
                        
                        label="Familiya"
                        required
                    ></v-text-field>
                    </v-col>

                    <v-col
                    cols="12"
                    md="4"
                    >
                    <v-text-field
                        v-model="email"
                        label="Otasining ismi"
                        required
                    ></v-text-field>
                    </v-col>
                </v-row>
                </v-container>
                <v-container class="col-lg-6 col-12">
                <v-row>
                    <v-col
                    cols="12"
                    md="4"
                    >
                    <v-text-field
                        v-model="firstname"
                        :rules="nameRules"
                        
                        label="Lavozimi"
                        required
                    ></v-text-field>
                    </v-col>

                    <v-col
                    cols="12"
                    md="4"
                    >
                    <v-text-field
                        v-model="lastname"
                        :rules="nameRules"
                        
                        label="Bolinma"
                        required
                    ></v-text-field>
                    </v-col>

                    <v-col
                    cols="12"
                    md="4"
                    >
                    <v-text-field
                        v-model="email"
                        
                        label="Tashkilot"
                        required
                    ></v-text-field>
                    </v-col>
                </v-row>
                </v-container>
                <v-container class="col-lg-6 col-12">
                <v-row>
                    <v-col
                    cols="12"
                    md="4"
                    >
                    <v-text-field
                        v-model="firstname"
                        :rules="nameRules"
                        
                        label="Yashash manzili"
                        required
                    ></v-text-field>
                    </v-col>

                    <v-col
                    cols="12"
                    md="4"
                    >
                    <v-text-field
                        v-model="lastname"
                        :rules="nameRules"
                        label="Ish telefoni"
                        required
                    ></v-text-field>
                    </v-col>

                    <v-col
                    cols="12"
                    md="4"
                    >
                    <v-text-field
                        v-model="email"
                        
                        label="Mobil telefon"
                        required
                    ></v-text-field>
                    </v-col>
                </v-row>
                </v-container>
            </v-form>
        </v-card>-->
      </v-tab-item>
      <v-tab-item class="mb-10 mt-15" >
        <form >
        <v-row class="mt-3 justify-center">
          <v-col lg="7" xl="6">
            <p class="mb-3 uzbekneftegaz-profile-assistant-title">
              Parolni o'zgartirish
            </p>
            <p>Eski parol</p>
            <v-text-field
              dense
              required
              outlined
              :label="Старый"
              class="nf-bor-radius mt-2"
              v-model="oldPass"
            >
            </v-text-field>
            <p>Yangi parol</p>
            <v-text-field
              dense
              required
              outlined
              :label="Новый"
              class="nf-bor-radius mt-2"
              v-model="newPass"
            >
            </v-text-field>
            <p>Tasdiqlash</p>
            <v-text-field
              dense
              required
              outlined
              :label="Подтвердить"
              class="nf-bor-radius mt-2"
              v-model="confirmPass"
            >
            </v-text-field>
            <div class="text-right">
              <v-btn
                class="nf-bor-radius white--text"
                color="#00a5e2"
                large
                @click="submit"
              >
                Saqlash
              </v-btn>
            </div>
          </v-col>
        </v-row>
      </form>
        
      </v-tab-item>
    </v-tabs>

</v-card>
</template>
<script>
import PictureInput from 'vue-picture-input'

const gradients = [
    ['#222'],
    ['#42b3f4'],
    ['red', 'orange', 'yellow'],
    ['purple', 'violet'],
    ['#00c6ff', '#F0F', '#FF0'],
    ['#f72047', '#ffd200', '#1feaea'],
  ]
export default {
  data: () => ({
      width: 2,
      radius: 10,
      padding: 8,
      lineCap: 'round',
      gradient: gradients[5],
      value: [0, 2, 5, 9, 5, 10, 3, 5, 0, 0, 1, 8, 2, 9, 0],
      gradientDirection: 'top',
      gradients,
      fill: false,
      type: 'trend',
      autoLineWidth: false,
      arrayEvents: null,
      date2: new Date().toISOString().substr(0, 10),
  }),
  computed: {
    theme() {
      return this.$vuetify.theme.dark ? "dark" : "light";
    }
  },
    components: {
    PictureInput
  },
  mounted () {
      this.arrayEvents = [...Array(6)].map(() => {
        const day = Math.floor(Math.random() * 30)
        const d = new Date()
        d.setDate(day)
        return d.toISOString().substr(0, 10)
      })
    },
    methods: {
      functionEvents (date) {
        const [,, day] = date.split('-')
        if ([12, 17, 28].includes(parseInt(day, 10))) return true
        if ([1, 19, 22].includes(parseInt(day, 10))) return ['red', '#00f']
        return false
      },
    },
};
</script>
<style scoped>
.rounded {
  border-top-left-radius: 50px;
  border-bottom-left-radius: 50px;
}
</style>
<!--
<script>
  export default {
    data () {
      return {
      }
    },
  }
</script>

<style>
/* Helper classes */
.basil {
  background-color: #FFFBE6 !important;
}
.basil--text {
  color: #356859 !important;
}
</style>

-->