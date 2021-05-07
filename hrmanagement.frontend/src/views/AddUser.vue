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
        <v-form        
        ref="form"
        v-model="valid"
        lazy-validation
>
            <v-container class="py-0">
              <v-row>
                <v-col>
                <v-card>
                <v-toolbar align="center" flat>
                    <v-toolbar-title>Asosiy ma'lumot</v-toolbar-title>
                </v-toolbar>
                <v-container
                    id="user-profile"
                    fluid
                    tag="section"
                    class="mb-n1"
                >
                    <v-row justify="center" class="mb-n6 mt-n6">
                    <v-col
                        cols="12"
                        md="11"
                    >
                                <v-container class="py-0">
                                <v-row>
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
                                    md="4"
                                    >
                                    <v-text-field
                                      label="Ф.И.О.(қисқа):"
                                      class="purple-input"
                                      v-model="fio_qisqa"
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
                                        v-model="fi_qisqa"
                                        required
                                        :rules="nameRules"

                                    />
                                    </v-col>
                                  <v-col
                                    cols="12"
                                    md="4"
                                  >
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
                                              label="Tug'ilgan yili"
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
                                        drag: 'Surat yuklash',
                                        change: 'Suratni O\'zgartirish',
                                        fileType: 'Bunday formatni qabul qilmaydi'
                                    }">
                                    </picture-input>
                                </div>
                            </v-col>
                                </v-row>
                                </v-container>

                    </v-col>
                    <v-col
                        cols="12"
                        md="4"
                    >
                    </v-col>
                    </v-row>
                </v-container>
                </v-card>
                </v-col>

              </v-row>
              <v-row>
                <v-col>
                  <v-card class="mt-n2">
                <v-toolbar align="center" flat>
                        <v-toolbar-title>Umumiy ma'lumot</v-toolbar-title>
                </v-toolbar>
                <v-container class="py-0">
                  <v-row class="ml-10 mr-10">
                  <v-col cols="12" md="4">
                  <v-select
                            v-model="Uzbekistan.countryId"
                            :items="countries"
                            menu-props="auto"
                            label="Tug'ilgan joyi"
                            hide-details
                            prepend-icon="mdi-map"
                            single-line
                            item-text='countryName'
                            item-value='countryId'
                            rounded: true
                            @input="selectedCountry"
                            
                          ></v-select>
                  </v-col>
                  <v-col cols="12" md="4">
                    <v-select
                      v-model="tuman.regionId"
                      :items="tumanlar"
                      menu-props="auto"
                      label="Viloyati"
                      hide-details
                      single-line
                      item-text='regionName'
                      item-value='regionId'
                      @input="selectedTuman"
                    ></v-select>
                  </v-col>
                  <v-col
                    cols="12"
                    md="4"
                  >
                    <v-select
                      class="purple-input"
                      v-model="tuman_shaharlar"
                      :items="tuman_shahar"
                      menu-props="auto"
                      label="Tuman/Shahar"
                      hide-details
                      single-line
                      item-text='districtName'
                      item-value='disrictId'
                    ></v-select>
                  </v-col>
                  </v-row>
                  <v-row class="mt-n3 ml-10 mr-10">
                  <v-col
                  cols="12"
                  md="4"
                >
                <v-select
                v-model="millat.nationalityId"
                :items="millatlar"
                  menu-props="auto"
                  label="Millati"
                  hide-details
                  single-line
                  item-text='nationalityName'
                  item-value='nationalityId'
                  ></v-select>
                </v-col>
                <v-col
                  cols="12"
                  md="4">
                  <v-row class="mt-2" justify="center" >
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
                v-model="malumoti.edInformationId"
                :items="malumoti_inst"
                  menu-props="auto"
                  label="Ma'lumoti"
                  hide-details
                  single-line
                  item-text='edInformationName'
                  item-value='edInformationId'
                  ></v-select>
                </v-col>
                  </v-row>
                  <v-row class="mt-n3 ml-10 mr-10">
                  <v-col
                  cols="12"
                  md="3"
                >
                  <v-text-field
                    v-model="edOrganizationName"
                    label="Tamomlagan ..."
                    class="purple-input"
                  />
                </v-col>
                <v-col
                  cols="12"
                  md="3"
                >
                  <v-text-field
                    v-model="speciality"
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
                    v-model="language.languageId"
                    :items="languages"
                    label="Chet tillarini bilishi"
                    multiple
                    chips
                    item-text='languageName'
                    item-value='languageId'
                    >
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
                v-model="army.militaryServiceStatusId"
                :items="select_armyType"
                  menu-props="auto"
                  label="Xarbiy xizmatga borganligi"
                  hide-details
                  single-line
                  item-text='militaryServiceStatusName'
                  item-value='militaryServiceStatusId'
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
                v-model="nogironlik.disabilityId"
                :items="nogironligi"
                  menu-props="auto"
                  label="Nogironligi"
                  hide-details
                  single-line
                  item-text='disabilityName'
                  item-value='disabilityId'
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
                v-model="partiyaviylik.partisanshipId"
                :items="partiyaviyligi"
                  menu-props="auto"
                  label="Partiyaviyligi"
                  hide-details
                  single-line
                  item-text='partisanshipName'
                  item-value='partisanshipId'
                  ></v-select>
                </v-col>
                  </v-row>
                </v-container>
              </v-card>
                </v-col>
              </v-row>
              <v-row>
                <v-col>
                  <v-card>
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
                        <v-row class="mt-n4">
                        <v-col cols="12" md="2">
                        <v-select
                          v-model="current_country.countryId"
                          :items="countries"
                          menu-props="auto"
                          label="Mamlakat"
                          hide-details
                          prepend-icon="mdi-map"
                          single-line
                          item-text='countryName'
                          item-value='countryId'
                          @input="selectedCurrentCountryAddress"
                        ></v-select>
                        </v-col>
                        <v-col cols="12" md="2">
                        <v-select
                          v-model="current_tuman.regionId"
                          :items="tumanlar1"
                          menu-props="auto"
                          label="Viloyati"
                          hide-details
                          single-line
                          item-text='regionName'
                          item-value='regionId'
                          @input="selectedCurrentRegionyAddress"
                        ></v-select>
                        </v-col>
                        <v-col
                          cols="12"
                          md="2"
                        >
                          <v-select
                            class="purple-input"
                            v-model="currentDistrict.disrictId"
                            :items="tuman_shahar1"
                            menu-props="auto"
                            label="Tuman/Shahar"
                            hide-details
                            single-line
                            item-text='districtName'
                            item-value='disrictId'
                          ></v-select>
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

                        </v-col>
                        <v-col
                            cols="12"
                            md="4"
                        >
                        </v-col>
                        </v-row>
                    </v-container>
                  </v-card>
                </v-col>
              </v-row>

              <v-row>
                <v-col>
                  <v-card>
                    <v-toolbar align="center" flat>
                                <v-toolbar-title>Passport ma'lumotlar</v-toolbar-title>
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
                        <v-row class="mt-n4">
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
                    v-model="givenBy"
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

                        </v-col>
                        <v-col
                            cols="12"
                            md="4"
                        >
                        </v-col>
                        </v-row>
                    </v-container>
                  </v-card>
                </v-col>
              </v-row>

          <v-row class="mt-n1">
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
          <v-snackbar
            v-model="snackbar"
            :timeout="timeout"
            :value="true"
            absolute
            bottom
            height="15px"
            width="30px"
            :rounded="true"
            color="primary"
            outlined
          >
      {{ text }}
    </v-snackbar>
      </v-col>
    </v-row>
  </v-container>
</template>

<script>
import PictureInput from 'vue-picture-input'
import moment from 'moment'
import axios from "axios"
  export default {
    data: () => ({
      snackbar: false,
      text: 'Xodim muvaffaqiyatli qo\'shildi',
      timeout: 2000,
      valid: true,      
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
      fio_qisqa: '',
      fi_qisqa: '',
      Uzbekistan:{ countryName: '', countryId: null },
      countries: [],
      country:null,
      CurrentCountry:null,
      
      tuman:{ regionName: '', regionId: null },
      tumanlar:  [],
      tumanlar1:  [],
      tuman_id_for_districts: null,


      tuman_shaharlar:{ districtName: '', disrictId: null},
      tuman_shahar: [],
      tuman_shahar1: [],
        millat:{ nationalityName: '', nationalityId: null},
        millatlar: [],
        radios: null,
        malumoti:{ edInformationName: '', edInformationId: null},
        malumoti_inst: [],
        language: [{ languageName: '', languageId: null}],
        languages: [],
        army:{ militaryServiceStatusName: '', militaryServiceStatusId: null},
        select_armyType: [],
        nogironlik:{ disabilityName: '', disabilityId: null },
        nogironligi: [],
        partiyaviylik: { partisanshipName: '', partisanshipId: null },
        partiyaviyligi: [],
        select_lavozim: '',
        current_country: { countryName: '', countryId: null },
        current_tuman: { regionName: '', regionId: null },
        currentDistrict: { districtName: '', districtId: null },
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
        edOrganizationName:'',
        speciality: '',
        
        givenBy: '',
        expirationDate: '',
        givenDate: '',
        passport: '',
        passportRules: [
          v => !!v || 'Passport raqami kiritilishi shart',
          v => (v && v.length >= 9) || 'Passport raqami 9 tadan kam bo\'lmasligi kerak',
        ],



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
    
    selectedCurrentCountryAddress(event){
       this.CurrentCountry = event;
      axios
      .get(`https://localhost:44343/Regions/${this.CurrentCountry}`, {
          },{
            "headers": {
            "content-type": "application/json",
      },
      })
      .then(response =>{
        this.tumanlar1=response.data
      });
    },
    selectedCountry(event){
       this.country = event;
      axios
      .get(`https://localhost:44343/Regions/${this.country}`, {
          },{
            "headers": {
            "content-type": "application/json",
      },
      })
      .then(response =>{
        this.tumanlar=response.data
      });
    },

    selectedCurrentRegionyAddress(event){
      this.tuman_id_for_districts = event;

      axios
      .get(`https://localhost:44343/Districts/${this.tuman_id_for_districts}`, {
          },{
            "headers": {
            "content-type": "application/json",
      },
      })
      .then(response =>{
        this.tuman_shahar1=response.data
      });

      
    },


    selectedTuman(event){
      this.tuman_id_for_districts = event;

      axios
      .get(`https://localhost:44343/Districts/${this.tuman_id_for_districts}`, {
          },{
            "headers": {
            "content-type": "application/json",
      },
      })
      .then(response =>{
        this.tuman_shahar=response.data
      });

      
    },

    reset () {
            this.$refs.form.reset()
            this.$refs.pictureInput.removeImage()   
    },
    chiqish(){
      this.$router.push({ name: 'team' });
    },
    submit(){
      //this.reset()
      this.snackbar=true
      this.$notify({
        group: 'foo',
        type: 'success',
        title: 'Success',
        text: 'Xodim muvafaqiyatli qo\'shildi'

}); 
//this.date2+"T06:33:32.593Z"

      axios
      .post('https://localhost:44343/api/ApplicationUser/SignUP', {
  userName: this.name+this.passport,
  email: this.email,
  phoneNumber: this.phone,
  emailConfirmed: true,
  phoneNumberConfirmed: true,
  password: "User@123",
  firstName: this.name,
  middleName: this.surname,
  lastName: this.lastName,
  fiO_short: this.fio_qisqa,
  fI_short: this.fi_qisqa,
  gender: this.radios,
  birthDate: this.date2+"T06:33:32.593Z",
  photoUrl: "string",
  workbookURL: "string",
  stirUrl: "string",
  orderUrl: "string",
  isDismissed: false,
  createdOn: moment().format(),
  updatedOn: moment().format(),
  fullBirthAddress: "string",
  currentAddress: this.current_address,
  lockoutEnd: "2021-05-07T08:03:57.590Z",
  lockoutEnabled: true,
  languages: [
    {
      languageId: 0,
      languageName: "string",
      status: true,
      userId: "string",
      applicationUser: {
        id: "string",
        userName: "string",
        normalizedUserName: "string",
        email: "string",
        normalizedEmail: "string",
        emailConfirmed: true,
        passwordHash: "string",
        securityStamp: "string",
        concurrencyStamp: "string",
        phoneNumber: "string",
        phoneNumberConfirmed: true,
        twoFactorEnabled: true,
        lockoutEnd: "2021-05-07T08:03:57.590Z",
        lockoutEnabled: true,
        accessFailedCount: 0,
        firstName: "string",
        middleName: "string",
        lastName: "string",
        fiO_short: "string",
        fI_short: "string",
        gender: "string",
        birthDate: "2021-05-07T08:03:57.590Z",
        photoUrl: "string",
        workbookURL: "string",
        stirUrl: "string",
        orderUrl: "string",
        isDismissed: true,
        createdOn: "2021-05-07T08:03:57.590Z",
        updatedOn: "2021-05-07T08:03:57.590Z",
        educations: [
          {
            educationId: 0,
            edOrganizationName: "string",
            speciality: "string",
            diplomaUrl: "string",
            edOrgAddress: "string",
            enteredDate: "2021-05-07T08:03:57.592Z",
            graduatedDate: "2021-05-07T08:03:57.592Z",
            scienceDegreeId: 0,
            edInformationId: 0,
            edOrgCountryId: 0,
            edOrgDistrictId: 0,
            employeeId: "string",
            scienceDegree: {
              scienceDegreeId: 0,
              scienceDegreeName: "string",
              status: true
            },
            edInformation: {
              edInformationId: 0,
              edInformationName: "string",
              status: true
            },
            edOrgCountry: {
              countryId: 0,
              countryName: "string",
              status: true
            },
            edOrgDistrict: {
              disrictId: 0,
              districtName: "string",
              status: true,
              regionId: 0,
              region: {
                regionId: 0,
                regionName: "string",
                status: true,
                countryId: 0,
                country: {
                  countryId: 0,
                  countryName: "string",
                  status: true
                }
              }
            }
          }
        ],
        workingActivities: [
          {
            workingActivityId: 0,
            organizationName: "string",
            positionName: "string",
            positionNameInFull: "string",
            positionType: "string",
            isNetworkExperience: true,
            startDate: "2021-05-07T08:03:57.592Z",
            endDate: "2021-05-07T08:03:57.592Z",
            employeeId: "string"
          }
        ],
        languages: [
          null
        ],
        disciplinaryActions: [
          {
            employeeDisciplinaryActionId: 0,
            orderDateForAction: "2021-05-07T08:03:57.592Z",
            orderNumber: "string",
            orderFileUrl: "string",
            reasonForAction: "string",
            disciplinaryActionTypeId: 0,
            employeeId: "string",
            disciplinaryActionType: {
              disciplinaryActionTypeId: 0,
              disciplinaryActionName: "string",
              status: true
            }
          }
        ],
        vacations: [
          {
            employeeVacationId: 0,
            vacationPeriod: "string",
            vacationStartDate: "2021-05-07T08:03:57.592Z",
            vacationEndDate: "2021-05-07T08:03:57.592Z",
            applicationUrl: "string",
            comment: "string",
            vacationtypeId: 0,
            employeeId: "string",
            vacationtype: {
              vacationtypeId: 0,
              vacationTypeName: "string",
              status: true
            }
          }
        ],
        userBusinessTrips: [
          {
            employeeId: "string",
            businessTripId: 0,
            businessTrip: {
              businessTripId: 0,
              startDate: "2021-05-07T08:03:57.594Z",
              endTime: "2021-05-07T08:03:57.594Z",
              businessTripMission: "string",
              businessTripAddress: "string",
              businessTripProgramFileUrl: "string",
              comment: "string",
              businessTripCountryId: 0,
              businessTripDistrictId: 0,
              userBusinessTrips: [
                null
              ],
              businessTripCountry: {
                countryId: 0,
                countryName: "string",
                status: true
              },
              businessTripDistrict: {
                disrictId: 0,
                districtName: "string",
                status: true,
                regionId: 0,
                region: {
                  regionId: 0,
                  regionName: "string",
                  status: true,
                  countryId: 0,
                  country: {
                    countryId: 0,
                    countryName: "string",
                    status: true
                  }
                }
              }
            },
            isSubstitute: true
          }
        ],
        fullBirthAddress: "string",
        currentAddress: "string",
        passportId: 0,
        birthCountryId: 0,
        birthRegionId: 0,
        birthDistrictId: 0,
        currentCountryId: 0,
        currentRegionId: 0,
        currentDistrictId: 0,
        nationalityId: 0,
        partisanshipId: 0,
        deputyMembershipId: 0,
        militaryServiceStatusId: 0,
        militaryTitleId: 0,
        disabilityId: 0,
        sectionId: 0,
        groupId: 0,
        positionId: 0,
        position: {
          positionId: 0,
          positionTypeInKrillUz: "string",
          positionTypeInLatinUz: "string",
          positionTypeInRu: "string",
          positionTypeInEng: "string",
          status: true,
          sequenceNumber: 0,
          positionDegreeId: 0,
          positionDegree: {
            positionDegreeId: 0,
            positionDegreeName: "string",
            status: true
          }
        },
        section: {
          sectionId: 0,
          sectionName: "string",
          departmentId: 0,
          status: true,
          department: {
            departmentId: 0,
            departmentName: "string",
            isDepartment: true,
            isIndependentSection: true,
            organizationId: 0,
            status: true,
            organization: {
              organizationId: 0,
              organizationNameInKrillUz: "string",
              organizationNameInLatinUz: "string",
              organizationNameInRu: "string",
              organizationNameInEng: "string",
              organizationNameInKrillUzShort: "string",
              organizationNameInLatinUzShort: "string",
              organizationNameInRuShort: "string",
              organizationNameInEngShort: "string",
              status: true,
              departments: [
                null
              ]
            },
            sections: [
              null
            ],
            groups: [
              null
            ]
          },
          groups: [
            {
              groupId: 0,
              groupName: "string",
              sectionId: 0,
              departmentId: 0,
              status: true,
              department: {
                departmentId: 0,
                departmentName: "string",
                isDepartment: true,
                isIndependentSection: true,
                organizationId: 0,
                status: true,
                organization: {
                  organizationId: 0,
                  organizationNameInKrillUz: "string",
                  organizationNameInLatinUz: "string",
                  organizationNameInRu: "string",
                  organizationNameInEng: "string",
                  organizationNameInKrillUzShort: "string",
                  organizationNameInLatinUzShort: "string",
                  organizationNameInRuShort: "string",
                  organizationNameInEngShort: "string",
                  status: true,
                  departments: [
                    null
                  ]
                },
                sections: [
                  null
                ],
                groups: [
                  null
                ]
              }
            }
          ]
        },
        group: {
          groupId: 0,
          groupName: "string",
          sectionId: 0,
          departmentId: 0,
          status: true,
          department: {
            departmentId: 0,
            departmentName: "string",
            isDepartment: true,
            isIndependentSection: true,
            organizationId: 0,
            status: true,
            organization: {
              organizationId: 0,
              organizationNameInKrillUz: "string",
              organizationNameInLatinUz: "string",
              organizationNameInRu: "string",
              organizationNameInEng: "string",
              organizationNameInKrillUzShort: "string",
              organizationNameInLatinUzShort: "string",
              organizationNameInRuShort: "string",
              organizationNameInEngShort: "string",
              status: true,
              departments: [
                null
              ]
            },
            sections: [
              null
            ],
            groups: [
              null
            ]
          }
        },
        passport: {
          passportId: 0,
          passportSeries: "string",
          givenDate: "2021-05-07T08:03:57.595Z",
          expirationDate: "2021-05-07T08:03:57.595Z",
          givenBy: "string"
        },
        birthCountry: {
          countryId: 0,
          countryName: "string",
          status: true
        },
        birthRegion: {
          regionId: 0,
          regionName: "string",
          status: true,
          countryId: 0,
          country: {
            countryId: 0,
            countryName: "string",
            status: true
          }
        },
        birthDistrict: {
          disrictId: 0,
          districtName: "string",
          status: true,
          regionId: 0,
          region: {
            regionId: 0,
            regionName: "string",
            status: true,
            countryId: 0,
            country: {
              countryId: 0,
              countryName: "string",
              status: true
            }
          }
        },
        currentCountry: {
          countryId: 0,
          countryName: "string",
          status: true
        },
        currentRegion: {
          regionId: 0,
          regionName: "string",
          status: true,
          countryId: 0,
          country: {
            countryId: 0,
            countryName: "string",
            status: true
          }
        },
        currentDistrict: {
          disrictId: 0,
          districtName: "string",
          status: true,
          regionId: 0,
          region: {
            regionId: 0,
            regionName: "string",
            status: true,
            countryId: 0,
            country: {
              countryId: 0,
              countryName: "string",
              status: true
            }
          }
        },
        nationality: {
          nationalityId: 0,
          nationalityName: "string",
          status: true
        },
        partisanship: {
          partisanshipId: 0,
          partisanshipName: "string",
          status: true
        },
        deputyMembership: {
          deputyMembershipId: 0,
          deputyMembershipName: "string",
          status: true
        },
        militaryServiceStatus: {
          militaryServiceStatusId: 0,
          militaryServiceStatusName: "string",
          status: true
        },
        militaryTitle: {
          militaryTitleId: 0,
          militaryTitleName: "string",
          status: true
        },
        disability: {
          disabilityId: 0,
          disabilityName: "string",
          status: true
        },
        role: "string"
      }
    }
  ],
  passport: {
    passportSeries: this.passport,
    givenDate: this.date+"T06:33:32.593Z",
    expirationDate: this.date1+"T06:33:32.593Z",
    givenBy: this.givenBy
  },
  educations: [
    {
      edOrganizationName: this.edOrganizationName,
      speciality: this.speciality,
      diplomaUrl: "string",
      edOrgAddress: "string",
      enteredDate: "2021-05-07T08:03:57.595Z",
      graduatedDate: "2021-05-07T08:03:57.595Z",
      scienceDegreeId: 1,
      edInformationId: 1,
      edOrgCountryId: 1,
      edOrgDistrictId: 1,
      employeeId: "string"
    }
  ],
  birthCountryId: parseInt(this.Uzbekistan.countryId),
  birthRegionId: parseInt(this.tuman.regionId),
  birthDistrictId: parseInt(this.currentDistrict.districtId),
  currentCountryId: parseInt(this.current_country.countryId),
  currentRegionId: 1,
  currentDistrictId: parseInt(this.currentDistrict.districtId),
  nationalityId: parseInt(this.millat.nationalityId),
  partisanshipId: parseInt(this.partiyaviylik.partisanshipId),
  militaryServiceStatusId: parseInt(this.army.militaryServiceStatusId),
  militaryTitleId: 0,
  disabilityId: parseInt(this.nogironlik.disabilityId),
}
,{
      "headers": {
      "content-type": "application/json",
      },
    })
      .then(response => (console.log(response)));

    },

      onChange () {
      console.log('New picture selected!')
      if (this.$refs.pictureInput.file) {
        console.log('Picture loaded.')
        console.log(this.$refs.pictureInput.file.name)
        this.image = this.$refs.pictureInput.file.name
      } else {
        console.log('FileReader API not supported: use the <form>, Luke!')
      }
    },

  },
  components: {
    PictureInput
  },
  created() {
      axios
      .get('https://localhost:44343/Countries', {
          },{
            "headers": {
            "content-type": "application/json",
      },
      })
      .then(response =>{
        this.countries=response.data
      });

      axios
      .get('https://localhost:44343/Disabilities', {
          },
          {
            "headers": {
            "content-type": "application/json",
          },
      })
      .then(response =>{
        this.nogironligi=response.data
      });

      axios
      .get('https://localhost:44343/Nationalities', {
          },
          {
            "headers": {
            "content-type": "application/json",
          },
      })
      .then(response =>{
        this.millatlar=response.data
      });

      axios
      .get('https://localhost:44343/Languages', {
          },
          {
            "headers": {
            "content-type": "application/json",
          },
      })
      .then(response =>{
        this.languages=response.data
      });

      axios
      .get('https://localhost:44343/MilitaryServiceStatuses', {
          },
          {
            "headers": {
            "content-type": "application/json",
          },
      })
      .then(response =>{
        this.select_armyType=response.data
      });

      axios
      .get('https://localhost:44343/EdInfos', {
          },
          {
            "headers": {
            "content-type": "application/json",
          },
      })
      .then(response =>{
        this.malumoti_inst=response.data
      });

      axios
      .get('https://localhost:44343/Partisanships', {
          },
          {
            "headers": {
            "content-type": "application/json",
          },
      })
      .then(response =>{
        this.partiyaviyligi=response.data
      });

      
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
