<template>
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
                <v-col
                  cols="12"
                  md="3"
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
                  md="3"
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
                  md="3"
                >
                  <v-text-field
                    label="Sharifi"
                    class="purple-input"
                    v-model="lastName"
                    required
                    :rules="lastNameRules"
                  />
                </v-col>
                <v-col  md="3">
                  <p>{{this.picture}}</p> 
                <div class="hello">   
                  
                <picture-input 
                  ref="pictureInput" 
                  v-model="picture"
                  @change="onChange" 
                  width="200" 
                  height="200" 
                  margin="16" 
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
            <!--<v-col>
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
                <v-col>
                <v-menu
        ref="menu2"
        v-model="menu2"
        :close-on-content-click="false"
        :return-value.sync="date2"
        transition="scale-transition"
        offset-y
        min-width="auto"
      >
        <template v-slot:activator="{ on, attrs }">
          <v-text-field
            v-model="date2"
            label="Berilgan sanasi"
            prepend-icon="mdi-calendar"
            readonly
            v-bind="attrs"
            v-on="on"
          ></v-text-field>
        </template>
        <v-date-picker
          v-model="date2"
          no-title
          scrollable
        >
          <v-spacer></v-spacer>
          <v-btn
            text
            color="primary"
            @click="menu2 = false"
          >
            Cancel
          </v-btn>
          <v-btn
            text
            color="primary"
            @click="$refs.menu2.save(date2)"
          >
            OK
          </v-btn>
        </v-date-picker>
      </v-menu>
            </v-col>-->

                <v-col
                  cols="12"
                  md="4"
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
                  md="4"
                >
                  <v-text-field
                    label="Ф.И.(қисқа):"
                    class="purple-input"
                    v-model="name"
                    required
                    :rules="nameRules"

                  />
                </v-col>


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
                <v-col cols="12"
                  md="4">
                <v-menu
                  ref="menu3"
                  v-model="menu3"
                  :close-on-content-click="false"
                  :return-value.sync="date"
                  transition="scale-transition"
                  offset-y
                  min-width="auto"
                  >
                  <template v-slot:activator="{ on, attrs }">
                    <v-text-field
                      v-model="date"
                      label="Ushbu sanadan buyon"
                      prepend-icon="mdi-calendar"
                      readonly
                      v-bind="attrs"
                      v-on="on"
                    ></v-text-field>
                  </template>
                  <v-date-picker
                    v-model="date3"
                    no-title
                    scrollable
                  >
                    <v-spacer></v-spacer>
                    <v-btn
                      text
                      color="primary"
                      @click="menu3 = false"
                    >
                      Cancel
                    </v-btn>
                    <v-btn
                      text
                      color="primary"
                      @click="$refs.menu3.save(date3)"
                    >
                      OK
                    </v-btn>
                  </v-date-picker>
                </v-menu>
            </v-col>
            <v-col cols="12" md="4">
              <v-combobox
              clearable
              v-model="select_lavozim"
              :items="items"
              label="Lavozimni tanlash"
              hide-selected
              ></v-combobox>
            </v-col>
            <v-col
                  cols="12"
                  md="4"
                >
                  <v-text-field
                    label="Lavozim"
                    class="purple-input"
                  />
                </v-col>
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
                <v-col
                  cols="12"
                  class="text-right"
                >
                </v-col>
                <v-col
                  cols="12"
                  class="text-right"
                >
                </v-col>
                <v-row justify="center">
                <v-col cols="12" md="2">
                  
  <v-file-input
    v-model="passport_nusxasi"
    label="Pasport nusxasi"
    
    prepend-icon="mdi-paperclip"
  >
    <template v-slot:selection="{ text }">
      <v-chip
        small
        label
        color="primary"
      >
        {{ text }}
      </v-chip>
    </template>
  </v-file-input>
                </v-col>
                <v-col cols="12" md="2">
  <v-file-input
    v-model="diplom_nusxasi"
    label="Diplom nusxasi"
    
    prepend-icon="mdi-paperclip"
  >
    <template v-slot:selection="{ text }">
      <v-chip
        small
        label
        color="primary"
      >
        {{ text }}
      </v-chip>
    </template>
  </v-file-input>
                </v-col>
                <v-col cols="12" md="2">
  <v-file-input
    v-model="mexnat_daftarchasi"
    label="Mexnat daftarchasi"
    
    prepend-icon="mdi-paperclip"
  >
    <template v-slot:selection="{ text }">
      <v-chip
        small
        label
        color="primary"
      >
        {{ text }}
      </v-chip>
    </template>
  </v-file-input>
                </v-col>
                <v-col cols="12" md="2">
  <v-file-input
    v-model="stir_nusxasi"
    label="STIR nusxasi"
    
    prepend-icon="mdi-paperclip"
  >
    <template v-slot:selection="{ text }">
      <v-chip
        small
        label
        color="primary"
      >
        {{ text }}
      </v-chip>
    </template>
  </v-file-input>
                </v-col>
                <v-col cols="12" md="2">
  <v-file-input
    v-model="buyruq_nusxasi"
    label="Buyruq nusxasi"
    
    prepend-icon="mdi-paperclip"
  >
    <template v-slot:selection="{ text }">
      <v-chip
        small
        label
        color="primary"
      >
        {{ text }}
      </v-chip>
    </template>
  </v-file-input>
                </v-col>
                </v-row>

                <!--<v-col cols="12">
                  <v-textarea
                    class="purple-input"
                    label="About Me"
                    value="Lorem ipsum dolor sit amet, consectetur adipiscing elit."
                  />
                </v-col>-->
                <v-col
                  cols="12"
                  class="text-right"
                >
                </v-col>
                <v-col
                  cols="12"
                  class="text-right"
                >
                <v-btn
                    @click="reset"
                    color="primary"
                    class="mr-2"
                  >
                    Tozalash
                  </v-btn>
                  <v-btn
                    color="success"
                    class="mr-2"
                    @click="submit"
                  >
                    Saqlash
                  </v-btn>
                  <v-btn
                    @click="chiqish"
                    color="danger"
                    class="mr-0"
                  >
                    Chiqish
                  </v-btn>
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
</template>

<script>
import PictureInput from 'vue-picture-input'

  export default {
    data: () => ({
      valid: true,
      passport: '',
      passportRules: [
        v => !!v || 'Passport raqami kiritilishi shart',
        v => (v && v.length >= 9) || 'Passport raqami 9 tadan kam bo\'lmasligi kerak',
      ],
      
      name:'',
      nameRules: [
        v => !!v || 'Ism kiritilishi shart',
      ],
      surname:'',
      surnameRules: [
        v => !!v || 'Familiya kiritilishi shart',
      ],
      lastName:'',
      lastNameRules: [
        v => !!v || 'Sharif kiritilishi shart',
      ],
      Uzbekistan:'',
      countries: [
                'Uzbekistan', 'Russia', 'American Samoa', 'Arizona',
                'Qozog\'iston', 'Tojikiston', 'Colorado', 'Connecticut',
                'Delaware', 'District of Columbia', 'Federated States of Micronesia',
                'Florida', 'Georgia', 'Guam', 'Hawaii', 'Idaho',
                'Illinois', 'Indiana', 'Iowa', 'Kansas', 'Kentucky',
                'Louisiana', 'Maine', 'Marshall Islands', 'Maryland',
                'Massachusetts', 'Michigan', 'Minnesota', 'Mississippi',
                'Missouri', 'Montana', 'Nebraska', 'Nevada',
                'New Hampshire', 'New Jersey', 'New Mexico', 'New York',
                'North Carolina', 'North Dakota', 'Northern Mariana Islands', 'Ohio',
                'Oklahoma', 'Oregon', 'Palau', 'Pennsylvania', 'Puerto Rico',
                'Rhode Island', 'South Carolina', 'South Dakota', 'Tennessee',
                'Texas', 'Utah', 'Vermont', 'Virgin Island', 'Virginia',
                'Washington', 'West Virginia', 'Wisconsin', 'Wyoming',
      ],
      tuman:'',
      tumanlar:  [
          'Toshkent', 'Namangan', 'Samarqand', 'Buxoro',
          'Xorazm', 'Surxondaryo', 'Navoi', 
        ],
        millat:'',
        millatlar: [
                'Rus', 'O\'zbek', 'Qozoq', 'Turkman',
                'Tatar', 'Qoraqalpoq', 'Qirg\'iz','Tojik','Koreys','Yaxudiy','Ozarbayjon','Gruzin','Arman'
        ],
        radios: null,
        malumoti:'',
        malumoti_inst: [
                'Oliy', 'O\'rta maxsus', 'O\'rta'
        ],
        language: '',
        languages: [
                'Rus tili',
                'Ingliz tili',
                'Arab tili',
                'Koreys tili',
                'Xitoy tili',
        ],
        army:'',
        select_armyType: [
                'Xizmatga majbur', 'Xizmatni o\'tagan', 'Rezervga o\'tkazilgan', 'Xizmatga majbur emas'],
        nogironlik:'',
        nogironligi: [
                '1-guruh', '2-guruh', '3-guruh','hisobga olinmagan'],
        partiyaviylik: '',
        partiyaviyligi: [
                'Yo\'q', 'UzLiDep azosi', 'UzXDP azosi','Milliy tiklanish demokratik partiyasi a\'zosi', 'Adolat sotsial demokratik partiyasi azosi','Ekologik partiyasi azosi'],
        select_lavozim: '',
        current_country: '',
        current_tuman: '',
        current_city: '',
        current_address: '',
        email: '',
        phone: '',
        phoneRule:[
                v => !!v || 'Phone is required',
                v => /^\s*(?:\+?(\d{1,3}))?[-. (]*(\d{3})[-. )]*(\d{3})[-. ]*(\d{4})(?: *x(\d+))?\s*$/.test(v) || 'Phone must be valid',
                ],
        picture: '',
        passport_nusxasi: [],
        diplom_nusxasi: [],
        mexnat_daftarchasi:[],
        stir_nusxasi:[],
        buyruq_nusxasi: [],



      date: new Date().toISOString().substr(0, 10),
      date1: new Date().toISOString().substr(0, 10),
      date2: new Date().toISOString().substr(0, 10),
      date3: new Date().toISOString().substr(0, 10),

      menu: false,
      menu1: false,
      menu2: false,
      menu3: false,
      modal: false,
    }),
  methods: {
    reset () {
            this.$refs.form.reset()
    },

    chiqish(){
      this.$router.push({ name: 'team' });
    },



      onChange (image) {
      console.log('New picture selected!')
      if (image) {
        console.log('Picture loaded.')
        this.image = image
      } else {
        console.log('FileReader API not supported: use the <form>, Luke!')
      }
    },

  },
  components: {
    PictureInput
  },
  computed: {
    

  },

      clear () {
        this.$v.$reset()
        this.name = ''
        this.email = ''
        this.select = null
        this.checkbox = false
      }
  }
</script>
<!--

      data:() => ({
select: { state: 'Florida', abbr: 'FL' },
        items: [
          { state: 'Florida', abbr: 'FL' },
          { state: 'Georgia', abbr: 'GA' },
          { state: 'Nebraska', abbr: 'NE' },
          { state: 'California', abbr: 'CA' },
          { state: 'New York', abbr: 'NY' },
        ],
    dialog: false,
    content: "",
    date: new Date().toDateString.substr(0, 10),
    dateFormatted: this.formatDate(new Date().toISOString().substr(0, 10)),
    menu1: false,
    
    rules: [
        value => !value || value.size < 2000000 || 'Avatar size should be less than 2 MB!',
    ],

    email: '',
    files: [],
  }),-->