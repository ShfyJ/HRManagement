<template>
        <v-card class="rounded-xl mt-5 ">
                <v-toolbar align="center" flat>
                    <v-toolbar-title>Yaqin qarindoshlari</v-toolbar-title>
                </v-toolbar>
                        <v-row justify="center">
                        <v-col
                            cols="12"
                            md="12"
                        >
                        <v-container>
                            <v-data-table
                                    :headers="headers"
                                    :items="desserts"
                                >
                                    <template v-slot:top>
                                    <v-toolbar
                                        flat
                                    >
                                        <v-dialog
                                        v-model="dialog"
                                        max-width="1200px"
                                        persistent
                                        >
                                        <template v-slot:activator="{ on, attrs }">
                                            <v-btn
                                            color="primary"
                                            dark
                                            class="mb-2"
                                            v-bind="attrs"
                                            v-on="on"
                                            >
                                            Qarindoshlar qo'shish
                                            </v-btn>
                                        </template>
                                        <v-card>
                                            <v-card-title>
                                            <span class="headline">{{ formTitle }}</span>
                                            </v-card-title>

                                            <v-card-text>
                                            <v-container>
                                                    <v-col>
                                                        <v-row class="mr-5 ml-5">
                                                            <v-col
                                                                cols="12"
                                                                sm="6"
                                                                md="4"
                                                            >
                                                            <v-select
                                                            :items="items"
                                                            label="Qarindoshligi"
                                                            
                                                            v-model="editedItem.qarindoshligi"
                                                            ></v-select>
                                                            </v-col>
                                                            <v-col
                                                                cols="12"
                                                                sm="6"
                                                                md="4"
                                                            >
                                                                <v-text-field
                                                                v-model="editedItem.fio_ota_ona"
                                                                label="фамилияси, исми ва отасининг исми"
                                                                ></v-text-field>
                                                            </v-col>
                                                            <v-col
                                                            cols="12"
                                                            sm="6"
                                                            md="4"
                                                        >
                                                            <v-menu
                                                            v-model="menu2"
                                                            :close-on-content-click="false"
                                                            :nudge-right="40"
                                                            transition="scale-transition"
                                                            offset-y
                                                            min-width="auto"
                                                        >
                                                            <template v-slot:activator="{ on, attrs }">
                                                            <v-text-field
                                                                v-model="date"
                                                                label="туғилган йили"
                                                                prepend-icon="mdi-calendar"
                                                                readonly
                                                                v-bind="attrs"
                                                                v-on="on"
                                                            ></v-text-field>
                                                            </template>
                                                            <v-date-picker
                                                            v-model="date"
                                                            @input="menu2 = false"
                                                            ></v-date-picker>
                                                        </v-menu>
                                                        </v-col>
                                                        </v-row>
                                                        <v-row>
                                                        <v-toolbar  :elevation="2"  flat>
                                                          <v-toolbar-title class="flex text-center">
                                                            Tug'ilgan joyi
                                                          </v-toolbar-title>
                                                          </v-toolbar>
                                                        </v-row>
                                                        
                                                        <v-row>
                                                        <v-col     
                                                            cols="12"
                                                            sm="6"
                                                            md="3">
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
                                                        <v-col                                                                       
                                                            cols="12"
                                                            sm="6"
                                                            md="3">
                                                            <v-select
                                                            v-model="current_country"
                                                            :items="countries"
                                                            menu-props="auto"
                                                            label="Viloyat"
                                                            hide-details
                                                            single-line
                                                            ></v-select>
                                                        </v-col>
                                                        <v-col                                                                       
                                                            cols="12"
                                                            sm="6"
                                                            md="3">
                                                            <v-select
                                                            v-model="current_country"
                                                            :items="countries"
                                                            menu-props="auto"
                                                            label="Tuman/shahar"
                                                            hide-details
                                                            single-line
                                                            ></v-select>
                                                        </v-col>
                                                        <v-col                                                                       
                                                            cols="12"
                                                            sm="6"
                                                            md="3">
                                                            <v-select
                                                            v-model="current_country"
                                                            :items="countries"
                                                            menu-props="auto"
                                                            label="Manzil"
                                                            hide-details
                                                            single-line
                                                            ></v-select>
                                                        </v-col>
                                                        </v-row>
                                                        <v-row>
                                                        <v-toolbar :elevation="2"  flat>
                                                          <v-toolbar-title class="flex text-center">
                                                            Ish joyi va lavozimi
                                                          </v-toolbar-title>
                                                          </v-toolbar>
                                                        </v-row>
                                                        <v-row>
                                                        <v-col
                                                            cols="12"
                                                            sm="6"
                                                            md="4"
                                                        >
                                                            <v-menu
                                                            v-model="menu3"
                                                            :close-on-content-click="false"
                                                            :nudge-right="40"
                                                            transition="scale-transition"
                                                            offset-y
                                                            min-width="auto"
                                                        >
                                                            <template v-slot:activator="{ on, attrs }">
                                                            <v-text-field
                                                                v-model="date"
                                                                label="Sanadan"
                                                                prepend-icon="mdi-calendar"
                                                                readonly
                                                                v-bind="attrs"
                                                                v-on="on"
                                                            ></v-text-field>
                                                            </template>
                                                            <v-date-picker
                                                            v-model="date"
                                                            @input="menu3 = false"
                                                            ></v-date-picker>
                                                        </v-menu>
                                                

                                                        </v-col>
                                                        <v-col                                                                       
                                                            cols="12"
                                                            sm="6"
                                                            md="4">
                                                            <v-select
                                                            v-model="current_country"
                                                            :items="countries"
                                                            menu-props="auto"
                                                            label="Hozirda"
                                                            hide-details
                                                            single-line
                                                            ></v-select>
                                                        </v-col>

                                                        <v-col
                                                            cols="12"
                                                            sm="6"
                                                            md="4"
                                                        >
                                                            <v-text-field
                                                            v-model="editedItem.ish_joyi"
                                                            label="иш жойи ва лавозими"
                                                            ></v-text-field>
                                                        </v-col>
                                                        </v-row>
                                                        <v-row>
                                                        <v-toolbar :elevation="2"  flat>
                                                          <v-toolbar-title class="flex text-center">
                                                            Yashash joyi
                                                          </v-toolbar-title>
                                                          </v-toolbar>
                                                        </v-row>
                                                        <v-row>
                                                        <v-col                                                                       
                                                            cols="12"
                                                            sm="6"
                                                            md="3">
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
                                                        <v-col                                                                       
                                                            cols="12"
                                                            sm="6"
                                                            md="3">
                                                            <v-select
                                                            v-model="current_country"
                                                            :items="countries"
                                                            menu-props="auto"
                                                            label="Viloyat"
                                                            hide-details
                                                            single-line
                                                            ></v-select>
                                                        </v-col>
                                                        <v-col                                                                       
                                                            cols="12"
                                                            sm="6"
                                                            md="3">
                                                            <v-select
                                                            v-model="current_country"
                                                            :items="countries"
                                                            menu-props="auto"
                                                            label="Tuman/shahar"
                                                            hide-details
                                                            single-line
                                                            ></v-select>
                                                        </v-col>
                                                        <v-col                                                                       
                                                            cols="12"
                                                            sm="6"
                                                            md="3">
                                                            <v-select
                                                            v-model="current_country"
                                                            :items="countries"
                                                            menu-props="auto"
                                                            label="Manzil"
                                                            hide-details
                                                            single-line
                                                            ></v-select>
                                                        </v-col>
                                                        </v-row>
                                                    </v-col>

                                                
                                                <v-col
                                                    cols="12"
                                                    sm="6"
                                                    md="4"
                                                >
                                                    <v-text-field
                                                    v-model="editedItem.turar_joyi"
                                                    label="турар жойи"
                                                    ></v-text-field>
                                                </v-col>
                                                
                                            </v-container>
                                            </v-card-text>

                                            <v-card-actions>
                                            <v-spacer></v-spacer>
                                            <v-btn
                                                color="blue darken-1"
                                                text
                                                @click="close"
                                            >
                                                Cancel
                                            </v-btn>
                                            <v-btn
                                                color="blue darken-1"
                                                text
                                                @click="save"
                                            >
                                                Save
                                            </v-btn>
                                            </v-card-actions>
                                        </v-card>
                                        </v-dialog>
                                        <v-dialog v-model="dialogDelete" max-width="500px">
                                        <v-card>
                                            <v-card-title class="headline">Are you sure you want to delete this item?</v-card-title>
                                            <v-card-actions>
                                            <v-spacer></v-spacer>
                                            <v-btn color="blue darken-1" text @click="closeDelete">Cancel</v-btn>
                                            <v-btn color="blue darken-1" text @click="deleteItemConfirm">OK</v-btn>
                                            <v-spacer></v-spacer>
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
                                    <v-icon
                                        small
                                        @click="deleteItem(item)"
                                    >
                                        mdi-delete
                                    </v-icon>
                                    </template>
                                    <template v-slot:no-data>
                                    <v-btn
                                        color="primary"
                                        @click="initialize"
                                    >
                                        Reset
                                    </v-btn>
                                    </template>
                                </v-data-table>
                        </v-container>
                        </v-col>
                        </v-row>
                    
        </v-card>
</template>


<script>
  export default {
    data: () => ({
      date: new Date().toISOString().substr(0, 10),
      menu2: false,
    items: ['Otasi', 'Onasi', 'Akasi', 'Ukasi'],
      dialog: false,
      dialogDelete: false,
      headers: [
        {
          text: 'Qarindoshligi',
          align: 'start',
          sortable: false,
          value: 'qarindoshligi',
        },
        { text: 'Familiyasi, ismi va otasining ismi', sortable: false, value: 'fio_ota_ona' },
        { text: 'Tug\'ilgan yili va joyi', sortable: false, value: 'date_of_birth' },
        { text: 'Ish joyi va lavozimi', sortable: false, value: 'ish_joyi' },
        { text: 'Turar joyi', sortable: false, value: 'turar_joyi' },
        { text: 'Actions', value: 'actions', sortable: false },
      ],
      desserts: [],
      editedIndex: -1,
      editedItem: {
        qarindoshligi: '',
        fio_ota_ona: '',
        date_of_birth: '',
        ish_joyi: '',
        turar_joyi: '',
      },
      defaultItem: {
        qarindoshligi: '',
        fio_ota_ona: '',
        date_of_birth: '',
        ish_joyi: '',
        turar_joyi: '',
      },
    }),

    computed: {
      formTitle () {
        return this.editedIndex === -1 ? 'Qarindosh qo\'shish' : 'Tahrirlash'
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

    methods: {
    initialize () {
        this.desserts = [
        {
            qarindoshligi: 'Otasi',
            fio_ota_ona: 'Маткулиев Хайитбой Маткулиевич',
            date_of_birth: "1948 йил, Хоразм вилояти,",
            ish_joyi: 'Тошкент тиббиёт академияси профессори, тиббиёт фанлари доктори',
            turar_joyi: 'Тошкент шаҳар, Олмазор тумани, Мухбир кўчаси, 2-уй, 19-хонадон',
            date_birth: "1948 йил",
            date_birth_country: "",
            date_birth_viloyat: "Хоразм вилояти",
            date_birth_tuman_shahar: "",
            date_birth_manzil: "",
            sanadan: "",
            hozirda: "",
            live_country: "",
            live_viloyat: "",
            live_tuman: "",
            live_manzil: ""
        },
        ]
    },

      editItem (item) {
        this.editedIndex = this.desserts.indexOf(item)
        this.editedItem = Object.assign({}, item)
        this.dialog = true
      },

      deleteItem (item) {
        this.editedIndex = this.desserts.indexOf(item)
        this.editedItem = Object.assign({}, item)
        this.dialogDelete = true
      },

      deleteItemConfirm () {
        this.desserts.splice(this.editedIndex, 1)
        this.closeDelete()
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
        } else {
          this.desserts.push(this.editedItem)
        }
        this.close()
      },
    },
  }
</script>