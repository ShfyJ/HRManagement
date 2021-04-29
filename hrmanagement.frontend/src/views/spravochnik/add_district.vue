<template>
<div>
        <v-card class="mt-5" :elevation="4">
                <v-toolbar align="center" flat>
                    <v-toolbar-title>Tuman qo'shish</v-toolbar-title>
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
                    <v-form        
                    ref="form"
                    v-model="valid"
                    lazy-validation
            >
                        <v-container class="py-0">
                            <v-row>
                                <v-col cols="12"
                                >
                                <v-row
                                >                     
                                    <v-col
                                    cols="12"
                                    >
                                    <v-text-field
                                        v-model="addDistrict"
                                        label="Tuman qo'shish"
                                        outlined
                                    ></v-text-field>
                                    </v-col>
                                </v-row>
                                </v-col>                     
                            </v-row>  
                            <v-row>
                                <v-col cols="12"
                                >
                                <v-row
                                >                     
                                <v-col
                                    class="d-flex"
                                    cols="12"
                                    sm="6"
                                >
                                    <v-select
                                    v-model="selected_country.countryId"
                                    :items="countries"
                                    label="Mamlakat tanlash"
                                    outlined
                                    item-text='countryName'
                                    item-value='countryId'
                                    @input="selectedCountry"
                                    ></v-select>
                                </v-col>
                                <v-col
                                    class="d-flex"
                                    cols="12"
                                    sm="6"
                                >
                                    <v-select
                                    v-model="selected_region.regionId"
                                    :items="regions"
                                    label="Region tanlash"
                                    outlined
                                    item-text='regionName'
                                    item-value='regionId'
                                    
                                    ></v-select>
                                </v-col>
                                </v-row>
                                </v-col>                     
                            </v-row>                                           
                            <v-row class="mt-n1">
                                <v-col
                                cols="12"
                                class="text-right"
                                >
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
                </v-col>  
                </v-row>
            </v-container>
        </v-card>
        <v-card class="mt-5" :elevation="4">
            <v-container>
                <v-card-title>
                    <v-text-field
                        v-model="search"
                        append-icon="mdi-magnify"
                        label="Search"
                        single-line
                        hide-details
                    ></v-text-field>
                    </v-card-title>
                    <v-data-table
                    :headers="headers"
                    :items="desserts"
                    :search="search"
                    ></v-data-table>
            </v-container>
        </v-card>



    </div>
</template>


<script>
import axios from "axios"
  export default {
    data: () => ({
      addDistrict: '',
      addRegion: '',
      countries: [],
      regions: [],
      selected_country: { countryName: '', countryId: null},
      selected_region: { regionName: '', regionId: null},
      search: '',
      getRegions: '',
      headers: [
          {
            text: 'Tuman ID',
            align: 'start',
            filterable: false,
            value: 'disrictId',
          },
          { text: 'Tuman nomi', value: 'districtName' },
          { text: 'Region nomi', value: "region.regionName" },
          { text: 'Mamlakat nomi', value: "region.country.countryName" },
        ],
        desserts: [],
    }),
    
    mounted(){
            axios
            .get('https://localhost:44343/Districts', {
                },{
                    "headers": {
                    "content-type": "application/json",
            },
            })
            .then(response =>{
                console.log(response.data)
                this.desserts=response.data
            });
        },
  methods: {
    selectedCountry(event){
      this.selected_region.regionId = event;
      axios
      .get(`https://localhost:44343/Regions/${this.selected_country.countryId}`, {
          },{
            "headers": {
            "content-type": "application/json",
      },
      })
      .then(response =>{
        this.regions=response.data
        console.log(this.regions)
      });
    },



    reset () {
            this.$refs.form.reset()
    },
    chiqish(){
      this.$router.push({ name: 'team' });
    },
    submit(){

    axios
      .post('https://localhost:44343/District', {
        districtName:  this.addDistrict,
        status: true,
        regionId: parseInt(this.selected_region.regionId),
    },
    {
      "headers": {
      "content-type": "application/json",
    },
    })
      .then(response => (console.log(response)));

    },


  },
  components: {
    
  },
    created() {
    axios
      .get('https://localhost:44343/Countries', {
          },
          {
            "headers": {
            "content-type": "application/json",
          },
      })
      .then(response =>{
        this.countries=response.data
      });
    },
  clear () {
        this.$v.$reset()
        this.addCountry = ''
      }
  }
</script>