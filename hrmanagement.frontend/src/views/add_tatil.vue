<template>
        <v-card class="rounded-xl mt-5 " :elevation="4">
                <v-toolbar align="center" flat>
                    <v-toolbar-title>Mehnat ta'tillari</v-toolbar-title>
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
                                    max-width="1100px"
                                    >
                                    <template v-slot:activator="{ on, attrs }">                                      
                                        <v-btn
                                            color="#47a3ff"
                                            rounded
                                            dark
                                            class="mb-2"
                                            v-bind="attrs"
                                            v-on="on"
                                            :elevation="4"
                                            >
                                            <v-icon class="mr-3">mdi-cast-education</v-icon>
                                                Ta'til qo'shish
                                            </v-btn>
                                    </template>
                                    <v-card>
                                        <v-card-title>
                                        <span class="headline">{{ formTitle }}</span>
                                        </v-card-title>

                                        <v-card-text>
                                        <v-container>
                                            <v-row>
                                                <v-col>
                                                   <v-row>
                                                    <v-col
                                                    cols="12"
                                                    sm="6"
                                                    md="4"
                                                    >

                                                    <v-text-field
                                                        v-model="firstname"
                                                        :rules="nameRules"
                                                        label="Ta'til davri"
                                                        required
                                                    ></v-text-field>
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
                                                            v-model="editedItem.sanadan"
                                                            label="Sanadan"
                                                            prepend-icon="mdi-calendar"
                                                            readonly
                                                            v-bind="attrs"
                                                            v-on="on"
                                                        ></v-text-field>
                                                        </template>
                                                        <v-date-picker
                                                        v-model="editedItem.sanadan"
                                                        no-title
                                                        scrollable
                                                        >
                                                        <v-spacer></v-spacer>
                                                        <v-btn
                                                            text
                                                            color="primary"
                                                            @click="menu = false"
                                                        >
                                                            Yopish
                                                        </v-btn>
                                                        <v-btn
                                                            text
                                                            color="primary"
                                                            @click="$refs.menu.save(editedItem.sanadan)"
                                                        >
                                                            Ok
                                                        </v-btn>
                                                        </v-date-picker>
                                                    </v-menu>
                                                </v-col>
                                                <v-col
                                                    cols="12"
                                                    sm="6"
                                                    md="4"
                                                >
                                                    <v-menu
                                                        ref="menu1"
                                                        v-model="menu1"
                                                        :close-on-content-click="false"
                                                        :return-value.sync="date"
                                                        transition="scale-transition"
                                                        offset-y
                                                        min-width="auto"
                                                    >
                                                        <template v-slot:activator="{ on, attrs }">
                                                        <v-text-field
                                                            v-model="editedItem.sanagacha"
                                                            label="Sanagacha"
                                                            prepend-icon="mdi-calendar"
                                                            readonly
                                                            v-bind="attrs"
                                                            v-on="on"
                                                        ></v-text-field>
                                                        </template>
                                                        <v-date-picker
                                                        v-model="editedItem.sanagacha"
                                                        no-title
                                                        scrollable
                                                        >
                                                        <v-spacer></v-spacer>
                                                        <v-btn
                                                            text
                                                            color="primary"
                                                            @click="menu1 = false"
                                                        >
                                                            Yopish
                                                        </v-btn>
                                                        <v-btn
                                                            text
                                                            color="primary"
                                                            @click="$refs.menu1.save(editedItem.sanagacha)"
                                                        >
                                                            Ok
                                                        </v-btn>
                                                        </v-date-picker>
                                                    </v-menu>
                                                </v-col>
                                                <v-col
                                                    cols="12"
                                                    sm="6"
                                                    md="4"
                                                >
                                                    <v-text-field
                                                    v-model="editedItem.tamomlagan"
                                                    label="Ta'lim muassasa nomi"
                                                    ></v-text-field>
                                                </v-col>
                                            </v-row>

                                            <v-row class="mt-n7">
                                            <v-col
                                                cols="12"
                                                sm="6"
                                                md="3"
                                            >
                                                <v-text-field
                                                v-model="editedItem.mutaxasisligi"
                                                label="Mutaxasisligi"
                                                ></v-text-field>
                                            </v-col>
                                            <v-col
                                                cols="12"
                                                sm="6"
                                                md="3"
                                            >
                                                <v-text-field
                                                v-model="editedItem.ilmiy_darajasi"
                                                label="Ilmiy_darajasi"
                                                ></v-text-field>
                                            </v-col>
                                            <v-col
                                                cols="12"
                                                sm="6"
                                                md="3"
                                            >
                                                <v-select
                                                :items="malumoti"
                                                label="Ma'lumoti"
                                                ></v-select>
                                            </v-col>
                                            <v-col
                                                cols="12"
                                                sm="6"
                                                md="3"
                                            >
                                            <v-file-input
                                                v-model="files"
                                                label="Diplom yoki sertifikat nusxasi"
                                                multiple
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
                                            <v-row>
                                                <v-toolbar  :elevation="2"  flat>
                                                    <v-toolbar-title class="flex text-center">
                                                            Joylashkan manzili
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
                                            <!--<v-col
                                                cols="12"
                                                sm="6"
                                                md="4"
                                            >
                                                <v-text-field
                                                v-model="editedItem.mamlakat"
                                                label="mamlakat"
                                                ></v-text-field>
                                            </v-col>-->
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
                                            Yopish
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
                                    <v-dialog v-model="dialogDelete" max-width="500px">
                                    <v-card>
                                        <v-card-title class="headline">Rostdan ham o'chirmoxchimisz?</v-card-title>
                                        <v-card-actions>
                                        <v-spacer></v-spacer>
                                        <v-btn color="blue darken-1" text @click="closeDelete">Yopish</v-btn>
                                        <v-btn color="blue darken-1" text @click="deleteItemConfirm">XA</v-btn>
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
      files: [],
      menu: false,
      menu1: false,
      dialog: false,
      dialogDelete: false,
      malumoti: ['Oliy', "O'rta-maxsus", "O'rta"],
      headers: [
        {
          text: 'No',
          align: 'start',
          sortable: false,
          value: 'id',
        },
        { text: "Ta'til davri", value: 'tatil_davri', sortable: false  },
        { text: "Ta'til turi", value: 'tatil_turi', sortable: false  },
        { text: 'Sanadan', value: 'sanadan', sortable: false  },
        { text: 'Sanagacha', value: 'sanagacha', sortable: false  },
        { text: 'Kun', value: 'kuni', sortable: false  },
        { text: 'Izoh', value: 'izoh', sortable: false  },
        { text: 'Actions', value: 'actions', sortable: false },
      ],
      desserts: [],
      editedIndex: -1,
      editedItem: {
        id: '',
        sanadan: new Date().toISOString().substr(0, 10),
        sanagacha: new Date().toISOString().substr(0, 10),
        tamomlagan: '',
        mutaxasisligi: '',
        ilmiy_darajasi: '',
        mamlakat: '',
      },
      defaultItem: {
        id: '',
        sanadan: '',
        sanagacha: '',
        tamomlagan: '',
        mutaxasisligi: '',
        ilmiy_darajasi: '',
        mamlakat: '',
      },
    }),

    computed: {
      formTitle () {
        return this.editedIndex === -1 ? "Ma'lumot qo'shish" : 'Tahrirlash'
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
            id: '1',
            sanadan: new Date().toISOString().substr(0, 10),
            sanagacha: new Date().toISOString().substr(0, 10),
            tamomlagan: "O'zbekiston davlat jahon tillari universiteti",
            mutaxasisligi: "Tarjimonlik (ingliz va nemis tillari)",
            ilmiy_darajasi: "yo'q",
            mamlakat: "O'zbekiston",
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