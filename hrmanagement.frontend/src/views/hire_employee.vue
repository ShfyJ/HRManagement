<template>
        <v-card class="rounded-xl mt-5 " :elevation="4">
                <v-toolbar align="center" flat>
                    <v-toolbar-title>Bo'lim nomi</v-toolbar-title>
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
                                        max-width="1000px"
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
                                            <v-icon class="mr-3">mdi-store-24-hour</v-icon>
                                                Mehnat faoliyati qo'shish
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
                                                    <!--<v-text-field
                                                    v-model="editedItem.sanadan"
                                                    label="санадан"
                                                    ></v-text-field>-->

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
                                                            label="Sanadan"
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
                                                    sm="6"
                                                    md="4"
                                                >
                                                <!--
                                                    <v-text-field
                                                    v-model="editedItem.sanagacha"
                                                    label="санагача"
                                                    ></v-text-field>-->
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
                                                          label="Sanagacha"
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
                                                <v-col
                                                    cols="12"
                                                    sm="6"
                                                    md="4"
                                                >
                                                    <v-text-field
                                                    v-model="editedItem.tashkilot_nomi"
                                                    label="Tashkilot nomi"
                                                    ></v-text-field>
                                                </v-col>
                                                <v-col
                                                    cols="12"
                                                    sm="6"
                                                    md="4"
                                                >
                                                    <v-text-field
                                                    v-model="editedItem.lavozim_nomi"
                                                    label="Lavozim nomi"
                                                    ></v-text-field>
                                                </v-col>
                                                <v-col
                                                    cols="12"
                                                    sm="6"
                                                    md="4"
                                                >
                                                    <v-text-field
                                                    v-model="editedItem.lavozim_nomi"
                                                    label="Lavozim to'liq nomi"
                                                    ></v-text-field>
                                                </v-col>
                                                <v-col
                                                    cols="12"
                                                    sm="6"
                                                    md="4"
                                                >
                                                  <v-select
                                                    :items="items"
                                                    label="Lavozim turi"
                                                    
                                                  ></v-select>
                                                </v-col>
                                                <!--<v-col
                                                    cols="12"
                                                    sm="6"
                                                    md="4"
                                                >
                                                    <v-text-field
                                                    v-model="editedItem.staji"
                                                    label="стажи"
                                                    ></v-text-field>
                                                </v-col>-->
                                                <v-col
                                                    cols="12"
                                                    sm="6"
                                                    md="4"
                                                >
                                                <v-checkbox
                                                  v-model="checkbox1"
                                                  :label="`Tarmoq stajiga kiradi: ${checkbox1.toString()}`"
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
                                        mdi-plus
                                    </v-icon>
                                    <v-icon
                                        small
                                        @click="deleteItem(item)"
                                    >
                                        mdi-minus
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
                        <v-col
                            cols="12"
                            md="4"
                        >
                        </v-col>
                        </v-row>
                    
        </v-card>
</template>


<script>
  export default {
    data: () => ({
      date: new Date().toISOString().substr(0, 10),
      menu: false,

      date1: new Date().toISOString().substr(0, 10),
      menu1: false,

      items: ['Mutaxasis', 'Bo\'linma rahbari', 'Tashkilot rahbari', 'Talaba'],

      checkbox1: false,

      dialog: false,
      dialogDelete: false,
      headers: [
        {
          text: 'ID',
          align: 'start',
          sortable: false,
          value: 'ID',
        },
        { text: 'Lavozim', value: 'lavozim', sortable: false, },
        { text: 'Stavka	', value: 'stavka', sortable: false, },
        { text: 'F.I.O	', value: 'fio', sortable: false, },
        { text: 'Actions', value: 'actions', sortable: false },
      ],
      desserts: [],
      editedIndex: -1,
      editedItem: {
        ID: '',
        lavozim: "",
        stavka: "",
        fio: "",
      },
      defaultItem: {
        ID: '',
        lavozim: "",
        stavka: "",
        fio: "",
      },
    }),

    computed: {
      formTitle () {
        return this.editedIndex === -1 ? 'Mehnat faoliyati qo\'shish' : 'Tahrirlash'
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
            ID: '88',
            lavozim: 'Bo\'lim boshlig\'i',
            stavka: "Stavka",
            fio: 'Vakant',
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