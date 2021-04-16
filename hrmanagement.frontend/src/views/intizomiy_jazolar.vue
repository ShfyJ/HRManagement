<template>
        <v-card class="rounded-xl mt-5 " :elevation="4">
                <v-toolbar align="center" flat>
                    <v-toolbar-title>Intizomiy jazolari</v-toolbar-title>
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
                                            <v-icon class="mr-3">mdi-alert-circle</v-icon>
                                                Jazo qo'shish
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
                                                        md="3"
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
                                                                v-model="editedItem.buyruq_sanasi"
                                                                label="Buyruq sanasi"
                                                                prepend-icon="mdi-calendar"
                                                                readonly
                                                                v-bind="attrs"
                                                                v-on="on"
                                                            ></v-text-field>
                                                            </template>
                                                            <v-date-picker
                                                            v-model="editedItem.buyr"
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
                                                    md="3"
                                                    >
                                                    <v-text-field
                                                        v-model="editedItem.buyruq_raqami"
                                                        :rules="nameRules"
                                                        label="Buyruq raqami"
                                                        required
                                                    ></v-text-field>
                                                </v-col>
                                                <v-col
                                                    cols="12"
                                                    sm="6"
                                                    md="3"
                                                >
                                                    <v-select
                                                    v-model="editedItem.jazo_turi"
                                                    :items="tatil_turi"
                                                    label="Jazoni tanlang"
                                                    ></v-select>
                                                </v-col>
                                                <v-col
                                                    cols="12"
                                                    sm="6"
                                                    md="3"
                                                >
                                                <v-file-input
                                                    v-model="files"
                                                    label="Fayl"
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
                                            <v-row >
                                            <v-col
                                                cols="12"
                                                md="12"
                                            >
                                                <v-textarea
                                                v-model="editedItem.qisqacha_sababi"
                                                filled
                                                auto-grow
                                                label="Qisqacha sababi"
                                                rows="4"
                                                row-height="30"
                                                shaped
                                                ></v-textarea>
                                            </v-col>
                                            </v-row>
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
      tatil_turi: ['Xayfsan', "Jarima", "Ishdan bo'shatish"],
      headers: [
        {
          text: 'No',
          align: 'start',
          sortable: false,
          value: 'id',
        },
        { text: "Buyruq sanasi va raqami", value: 'buyruq_sanasi', sortable: false  },
        { text: "Jazo_turi", value: 'jazo_turi', sortable: false  },
        { text: 'Qisqacha sababi', value: 'qisqacha_sababi', sortable: false  },
        { text: 'Actions', value: 'actions', sortable: false },
      ],
      desserts: [],
      editedIndex: -1,
      editedItem: {
        id: '',
        buyruq_sanasi: new Date().toISOString().substr(0, 10),
        buyruq_raqami: '',
        jazo_turi: '',
        qisqacha_sababi: '',
      },
      defaultItem: {
        id: '',
        buyruq_sanasi: new Date().toISOString().substr(0, 10),
        buyruq_raqami: '',
        jazo_turi: '',
        qisqacha_sababi: '',
      },
    }),

    computed: {
      formTitle () {
        return this.editedIndex === -1 ? "Intizomiy jazo qo'shish" : 'Tahrirlash'
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
            buyruq_sanasi: "2019-2020",
            jazo_turi: "Xayfsan",
            qisqacha_sababi: "yo'q",
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