<template>
    <div>
        <!--<h1> Info about {{id}}</h1>-->
        <v-card>
        <v-card-title class="justify-center myTitle">
        "O'ZBEKNEFTGAZ" AKTSIONERLIK JAMIYATINING
        </v-card-title>
        <v-card-title class="justify-center mt-n7 myTitle">
        {{this.items.organizationNameInKrillUz.toUpperCase()}} TO'G'RISIDA MA'LUMOT
        </v-card-title>
        <v-card-title>
        
        <v-row>
          <v-col cols-12 md-4>
          </v-col>
          <v-col cols-12 md-4>

          </v-col>
          <v-col cols-12 md-4>
            <v-text-field
            v-model="search"
            append-icon="mdi-magnify"
            label="Search"
            single-line
            hide-details
        ></v-text-field>
          </v-col>
        </v-row>
        </v-card-title>
                            <v-data-table
                            :headers="headers"
                            :items="desserts"
                            :search="search"
                            >
                            <template justify-center
                              v-slot:item.departmentName="{ item }">
                              <router-link style="text-decoration: none; color: inherit;" :to="`/projects/${id}/${ item.departmentId}`" :key="item.departmentId"><td>{{ item.departmentName }}</td>
                              </router-link>
                            </template>
                            <template v-slot:top>
                            <v-toolbar
                                flat
                            >        
                                <v-dialog
                                v-model="dialog"
                                max-width="1000px"
                                >
                                <template v-slot:activator="{ on, attrs }">
                                  <v-btn
                                    color="success"
                                    dark
                                    class="mb-2"
                                    v-bind="attrs"
                                    v-on="on"
                                    text
                                  ><v-icon left>mdi-plus</v-icon>
                                    Bo'linma qo'shish
                                  </v-btn>
                                </template>
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
                                            v-model="editedItem.departmentName"
                                            label="Bo'linma"
                                            ></v-text-field>
                                        </v-col>
                                        <v-row class="justify-center myTitle">
                                        <v-col
                                            cols="12"
                                            md="4"
                                            class="justify-center myTitle"
                                        >
                                        <v-checkbox
                                          v-model="checkbox"
                                          :label="`Departament`"
                                        ></v-checkbox>
                                        </v-col>
                                        <v-col
                                            cols="12"
                                            md="4"
                                        >
                                        <v-checkbox
                                          v-model="checkbox1"
                                          :label="`Mustaqil bo'lim`"
                                        ></v-checkbox>
                                        </v-col>
                                        </v-row>
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
                        </v-card>
                        <v-btn
                                @click="$router.go(-1)" 
                                class="ma-2 btn btn-primary"
                                outlined
                                color="indigo"
                        >
                            Ortga
                        </v-btn>
    </div>
</template>


<script>
import axios from "axios"
  export default {
        data(){
        return{
            checkbox: false,
            checkbox1: false,
            id: this.$route.params['id'],
            items: [],
            selected_organization: { organizationNameInKrillUz: '', organizationId: null},
            search: '',
            headers: [
            {
              text: 'No',
              align: 'start',
              sortable: false,
              value: 'departmentId',
            },
            { text: 'Tuzilma nomi', value: 'departmentName' },
            { text: 'Status', value: 'status' },
            { text: 'Taxrir', value: 'actions', sortable: false },

        ],
        desserts: [],
        editedIndex: -1,
        editedItem: {
            departmentName: '',
            status: true    
        },
        defaultItem: {
            departmentId : 0,
            departmentName: '',
            status: false
      },
      }
        
    },
    computed: {
      formTitle () {
        return this.editedIndex === -1 ? 'Qo\'shish' : 'Taxrirlash'
      },
    },
        watch: {
          $route(toRoute){
           this.id=toRoute.params['id']
          },
          dialog (val) {
            val || this.close()
          },
          dialogDelete (val) {
            val || this.closeDelete()
          },
        },
            mounted(){
            axios
            .get(`https://localhost:44343/Departments/${this.$route.params['id']}`, {
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
            .get(`https://localhost:44343/Organization/${this.$route.params['id']}`, {
                },{
                    "headers": {
                    "content-type": "application/json",
            },
            })
            .then(response =>{
                this.items=response.data
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
          console.log(this.desserts[this.editedIndex])
          axios
            .put(`https://localhost:44343/Country/${this.getCountry[this.editedIndex].countryId}`, {
                countryName:  this.editedItem.countryName,
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
          axios
            .post(`https://localhost:44343/Department`, {
                departmentName:  this.editedItem.departmentName,
                organizationId: this.$route.params['id'],
                isDepartment: this.checkbox,
                isIndependentSection: this.checkbox1,
                status: true,
            },{
                    "headers": {
                    "content-type": "application/json",
                },
                })
                .then(response =>{
                    console.log(response.data)
                });
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
      .post('https://localhost:44343/Country', {
        countryName:  this.addCountry,
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