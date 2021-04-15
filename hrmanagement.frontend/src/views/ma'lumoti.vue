<template>
        <v-card class="rounded-xl mt-5 " :elevation="4">
                <v-toolbar align="center" flat>
                    <v-toolbar-title>Ma'lumoti</v-toolbar-title>
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
                                    max-width="800px"
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
                                                Ma'lumot qo'shish
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
                                                sm="6"
                                                md="4"
                                            >
                                                <v-text-field
                                                v-model="editedItem.sanadan"
                                                label="Sanadan"
                                                ></v-text-field>
                                            </v-col>
                                            <v-col
                                                cols="12"
                                                sm="6"
                                                md="4"
                                            >
                                                <v-text-field
                                                v-model="editedItem.sanagacha"
                                                label="Sanagacha"
                                                ></v-text-field>
                                            </v-col>
                                            <v-col
                                                cols="12"
                                                sm="6"
                                                md="4"
                                            >
                                                <v-text-field
                                                v-model="editedItem.tamomlagan"
                                                label="tamomlagan"
                                                ></v-text-field>
                                            </v-col>
                                            <v-col
                                                cols="12"
                                                sm="6"
                                                md="4"
                                            >
                                                <v-text-field
                                                v-model="editedItem.mutaxasisligi"
                                                label="mutaxasisligi"
                                                ></v-text-field>
                                            </v-col>
                                            <v-col
                                                cols="12"
                                                sm="6"
                                                md="4"
                                            >
                                                <v-text-field
                                                v-model="editedItem.ilmiy_darajasi"
                                                label="ilmiy_darajasi"
                                                ></v-text-field>
                                            </v-col>
                                            <v-col
                                                cols="12"
                                                sm="6"
                                                md="4"
                                            >
                                                <v-text-field
                                                v-model="editedItem.mamlakat"
                                                label="mamlakat"
                                                ></v-text-field>
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
      dialog: false,
      dialogDelete: false,
      headers: [
        {
          text: 'No',
          align: 'start',
          sortable: false,
          value: 'id',
        },
        { text: 'Sanadan', value: 'sanadan', sortable: false  },
        { text: 'Sanagacha', value: 'sanagacha', sortable: false  },
        { text: 'Tamomlagan', value: 'tamomlagan', sortable: false  },
        { text: 'Mutaxasisligi', value: 'mutaxasisligi', sortable: false  },
        { text: 'Ilmiy darajasi', value: 'ilmiy_darajasi', sortable: false  },
        { text: 'Mamlakat', value: 'mamlakat', sortable: false  },
        { text: 'Actions', value: 'actions', sortable: false },
      ],
      desserts: [],
      editedIndex: -1,
      editedItem: {
        id: '',
        sanadan: '',
        sanagacha: '',
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
            sanadan: "02.09.1997",
            sanagacha: "18.06.2001",
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