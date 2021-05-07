<template>
    <div>
        <!--<h1> Info about {{id}}</h1>-->
        <v-card>
        <v-card-title class="justify-center myTitle">
        "O'ZBEKNEFTGAZ" AKTSIONERLIK JAMIYATINING
        </v-card-title>
        <v-card-title class="justify-center mt-n7 myTitle">
        "O'ZBEKNEFTGAZ" AKTSIYADORLIK JAMIYATI TO'G'RISIDA MA'LUMOT
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
                              v-slot:item.groupName="{ item }">
                              <td>{{ item.groupName }}</td>
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
                                            v-model="editedItem.groupName"
                                            label="Guruh"
                                            ></v-text-field>
                                        </v-col>
                                        <v-col
                                            cols="12"
                                        >
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
            id: this.$route.params['id'],
            items: [],
            search: '',
            headers: [
            {
              text: 'No',
              align: 'start',
              sortable: false,
              value: 'groupId',
            },
            { text: 'Tuzilma nomi', value: 'groupName' },
            { text: 'Status', value: 'status' },
            { text: 'Taxrir', value: 'actions', sortable: false },
        ],
        desserts: [],
        editedIndex: -1,
        editedItem: {
            groupName: '',
            status: true    
        },
        defaultItem: {
            groupId : 0,
            groupName: '',
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
            .get(`https://localhost:44343/GroupsBySection/${this.$route.params['id']}`, {
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
            .put(`https://localhost:44343/Group${this.$route.params['id']}`, {
                groupName:  this.editedItem.groupName,
                sectionId: this.$route.params['id'],
                departmentId: parseInt(window.location.pathname.split('/').slice(3)[0]),
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
            .post(`https://localhost:44343/Group`, {
                groupName:  this.editedItem.groupName,
                sectionId: this.$route.params['id'],
                departmentId: parseInt(window.location.pathname.split('/').slice(3)[0]),
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
  },
  clear () {
        this.$v.$reset()
        this.addCountry = ''
      }
  }
</script>