<template>
<div>
        <v-card class="mt-5" :elevation="4">
                <v-toolbar align="center" flat>
                    <v-toolbar-title>Millat qo'shish</v-toolbar-title>
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
                                        v-model="addNationality"
                                        label="Millat qo'shish"
                                        outlined
                                    ></v-text-field>
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
      addNationality: '',
      search: '',
      headers: [
          {
            text: 'ID',
            align: 'start',
            filterable: false,
            value: 'nationalityId',
          },
          { text: 'Millatlar', value: 'nationalityName' },
          { text: 'Taxrir', value: 'actions', sortable: false },
        ],
        desserts: [],
    }),
        mounted(){
            axios
            .get('https://localhost:44343/Nationalities', {
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
    reset () {
            this.$refs.form.reset()
    },
    chiqish(){
      this.$router.push({ name: 'team' });
    },
    submit(){
    axios
      .post('https://localhost:44343/Nationality', {
        nationalityName:  this.addNationality,
        status: true,
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

  clear () {
        this.$v.$reset()
        this.addCountry = ''
      }
  }
</script>