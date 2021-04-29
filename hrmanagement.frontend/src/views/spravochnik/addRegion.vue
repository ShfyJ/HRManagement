<template>
    <div>
        <v-card class="mt-5" :elevation="4">
                <v-toolbar align="center" flat>
                    <v-toolbar-title>Region qo'shish</v-toolbar-title>
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
                                        v-model="addRegion"
                                        label="Region qo'shish"
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
                            >
                            <template v-slot:top>
                            <v-toolbar
                                flat
                            >        
                                <v-dialog
                                v-model="dialog"
                                max-width="1000px"
                                >
                                <v-card>
                                    <v-card-title>
                                    <span class="headline">{{ formTitle }}</span>
                                    </v-card-title>

                                    <v-card-text>
                                    <v-container>
                                        <v-row>
                                        <v-col
                                            cols="12"
                                        >
                                            <v-text-field
                                            v-model="editedItem.regionName"
                                            label="Taxrirlash"
                                            ></v-text-field>
                                        </v-col>
                                        <v-col
                                            cols="12"
                                        >
                                            <v-select
                                                v-model="editedItem.countryId"
                                                :items="countries"
                                                label="Mamlakat tanlash"
                                                outlined
                                                item-text='countryName'
                                                item-value='countryId'
                                                ></v-select>
                                        </v-col>
                                        <v-col
                                            cols="12"
                                        >
                                            <v-checkbox
                                            v-model="editedItem.status"
                                            label="Status"
                                            color="red"
                                            hide-details
                                            ></v-checkbox>
                                        </v-col>
                                        </v-row>
                                    </v-container>
                                    </v-card-text>

                                    <v-card-actions>
                                    <v-spacer></v-spacer>
                                    <v-btn
                                        color="blue darken-1"
                                        text
                                        @click="close"
                                    >
                                        Rad qilish
                                    </v-btn>
                                    <v-btn
                                        color="blue darken-1"
                                        text
                                        @click="save"
                                    >
                                        Saqlash
                                    </v-btn>
                                    </v-card-actions>
                                </v-card>
                                </v-dialog>
                            </v-toolbar>
                            </template>
                            <template v-slot:item.actions="{ item }">
                                <v-icon
                                    small
                                    class="mr-2"
                                    @click="editItem(item)"
                                >
                                    mdi-pencil
                                </v-icon>
                                </template>
                            </v-data-table>
                    </v-container>
        </v-card>
    </div>
</template>


<script>
import axios from "axios"
  export default {
    data: () => ({
      addRegion: '',
      countries: [],
      selected_country: { countryName: '', countryId: null},
      search: '',
      getRegions: '',
      headers: [
          {
            text: 'Region ID',
            align: 'start',
            filterable: false,
            value: 'regionId',
          },
          { text: 'Region nomi', value: 'regionName' },
          {
            text: 'Mamlakat ID',
            align: 'start',
            filterable: false,
            value: 'country.countryId',
          },
          { text: 'Mamlakat nomi', value: "country.countryName" },
          { text: 'Taxrir', value: 'actions', sortable: false },

        ],
        desserts: [],
        editedIndex: -1,
        editedItem: {
            regionName: '',
            countryId:  null,
            status: false    
        },
    }),
computed: {
      formTitle () {
        return this.editedIndex === -1 ? 'New Item' : 'Taxrirlash'
      },
    },
    watch: {
      dialog (val) {
        val || this.close()
      },
      dialogDelete (val) {
        val || this.closeDelete()
      },
    },
    created () {
      this.initialize()
    },

        mounted(){
            axios
            .get('https://localhost:44343/Regions', {
                },{
                    "headers": {
                    "content-type": "application/json",
            },
            })
            .then(response =>{
                console.log(response.data)
                this.desserts=response.data

            });
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
  methods: {
      editItem (item) {
        this.editedIndex = this.desserts.indexOf(item)
        this.editedItem = Object.assign({}, item)
        this.dialog = true
        
    },

    close () {
        this.dialog = false
        this.$nextTick(() => {
          this.editedItem = Object.assign({}, this.defaultItem)
          this.editedIndex = -1
        })
      },
    
    
    closeDelete () {
        this.dialogDelete = false
        this.$nextTick(() => {
          this.editedItem = Object.assign({}, this.defaultItem)
          this.editedIndex = -1
        })
      },

      
      save () {
        if (this.editedIndex > -1) {
          Object.assign(this.desserts[this.editedIndex], this.editedItem)
          //this.desserts[this.editedIndex].country.countryId
            axios
            .put(`https://localhost:44343/Region/${this.desserts[this.editedIndex].regionId}`, {
                regionName:  this.editedItem.regionName,
                countryId: this.editedItem.countryId,
                status: this.editedItem.status,
            },{
                    "headers": {
                    "content-type": "application/json",
                },
                })
                .then(response =>{
                    console.log(response.data)
                });
        } else {
          this.desserts.push(this.editedItem)
        }
        this.close()
      },





    reset () {
            this.$refs.form.reset()
    },
    chiqish(){
      this.$router.push({ name: 'team' });
    },
    submit(){
    axios
      .post('https://localhost:44343/Region', {
        regionName:  this.addRegion,
        status: true,
        countryId: parseInt(this.selected_country.countryId),
    },
    {
      "headers": {
      "content-type": "application/json",
    },
    })
      .then(response => (console.log(response)));
      console.log(parseInt(this.selected_country.countryId))
    },


  },
  components: {
    
  },

  clear () {
        this.$v.$reset()
        this.addCountry = ''
      }
  }
</script>