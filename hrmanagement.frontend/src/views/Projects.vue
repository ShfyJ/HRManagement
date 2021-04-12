<!--<template>
  <div>
    <h1 class="subheading grey--text">Tashkiliy tuzilma</h1>
  </div>
</template>-->
<template>
<v-card>
<v-card-title>
      <v-spacer></v-spacer>
      <v-text-field 
          v-model="search"
          append-icon="mdi-magnify"
          label="Qidirish"
          single-line
          hide-details
      ></v-text-field>
    </v-card-title>
  <v-data-table
    :headers="headers"
    :items="desserts"
    sort-by="calories"
    class="elevation-1"
    :search="search" 
    fixed-header 
    height="600"
  >
  
    <template v-slot:top>
      <v-toolbar
        flat
      >
        <v-toolbar-title>Tuzilma nomi</v-toolbar-title>
        <v-divider
          class="mx-4"
          inset
          vertical
        ></v-divider>
        <v-spacer></v-spacer>
          <v-btn
          @click="addTuzilma" color="success" dark class="mb-2 mr-2" v-on="on" text
            ><v-icon left>mdi-plus</v-icon>Bo'linma qoshish</v-btn
          >
          <v-btn
          @click="addLavozim" color="success" dark class="mb-2 mr-2" v-on="on" text
            ><v-icon left>mdi-plus</v-icon>Lavozim qo'shish</v-btn
          >
          <v-btn
          @click="addCategory" color="success" dark class="mb-2 mr-2" v-on="on" text
            ><v-icon left>mdi-plus</v-icon>Korxona qo'shish</v-btn
          >
          <v-btn
          @click="dialog2 = true"
          color="success" dark class="mb-2 mr-2" v-on="on" text
          >
          <v-icon left>mdi-fullscreen</v-icon>{{$t('extended_view')}}
          </v-btn>
          <v-dialog
            v-model="dialog2"
            fullscreen
            hide-overlay
            transition="dialog-bottom-transition"
            scrollable
          >
        <v-card tile>
          <v-toolbar
            flat
            dark
            color="red"
            class="mb-n15"  
          >
            <v-btn
              icon
              dark
              @click="dialog2 = false"
            >
              <v-icon>mdi-close</v-icon>
            </v-btn>
            <v-spacer></v-spacer>
          </v-toolbar>
      <v-data-table overflow-x scroll  :headers="headers" :items="desserts" :search="search" fixed-header height="600">
      <template v-slot:top>
        <v-toolbar  flat color="white">
          <v-toolbar-title>
            Xodimlar ro'yhati
          </v-toolbar-title>
          <v-divider class="mx-4" inset vertical=""></v-divider>
          <v-spacer></v-spacer>
        </v-toolbar>
      </template>
      <template justify-center
        v-slot:item.calories="{ item }">
        <v-avatar class="d-flex p-2" size="40px" small ><img :src="item.calories"/></v-avatar>
      </template>
      <template v-slot:no-data>
        <v-btn color="primary" @click="initialize"> Reset</v-btn>
      </template>
    </v-data-table>
    <div style="flex: 1 1 auto;"></div>    
  </v-card>
</v-dialog>
          
    <v-dialog
          v-model="dialog"
          max-width="1500px"
        >
          <v-card>
            <v-card-title>
              <span class="headline">Tahrirlash</span>
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
                      v-model="editedItem.tuzilma_nomi"
                      label="F.I.SH"
                    ></v-text-field>
                  </v-col>
                  <v-col
                    cols="12"
                    sm="6"
                    md="4"
                  >
                    <v-text-field
                      v-model="editedItem.shtat"
                      label="Ushbu sanadan"
                    ></v-text-field>
                  </v-col>
                  <v-col
                    cols="12"
                    sm="6"
                    md="4"
                  >
                    <v-text-field
                      v-model="editedItem.hodimlar_soni"
                      label="Joriy Lavozimi"
                    ></v-text-field>
                  </v-col>
                  <v-col
                    cols="12"
                    sm="6"
                    md="4"
                  >
                    <v-text-field
                      v-model="editedItem.foiz"
                      label="Yoshi"
                    ></v-text-field>
                  </v-col>
                  <v-col
                    cols="12"
                    sm="6"
                    md="8"
                  >
                    <v-text-field
                      v-model="editedItem.lavozim_soni"
                      label="Mutahasisligi"
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
                Chiqish
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
            <v-card-title class="headline">O'chirasizmi</v-card-title>
            <v-card-actions>
              <v-spacer></v-spacer>
              <v-btn color="blue darken-1" text @click="closeDelete">O'chirish</v-btn>
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
      <template justify-center
        v-slot:item.tuzilma_nomi="{ item }">
        <router-link style="text-decoration: none; color: inherit;" :to="`/projects/${ item.ID}`" :key="item.ID"><td class="myTitle">{{ item.tuzilma_nomi }}</td>
        </router-link>
      </template>
      <template justify-center
        v-slot:item.shtat="{ item }">
        <td class="myTitle">{{ item.shtat }}</td>
      </template>
      <template justify-center
        v-slot:item.ID="{ item }">
        <td class="myTitle">{{ item.ID }}</td>
      </template>
      <template justify-center
        v-slot:item.hodimlar_soni="{ item }">
        <td class="myTitle">{{ item.hodimlar_soni }}</td>
      </template>
      <template justify-center
        v-slot:item.foiz="{ item }">
        <td class="myTitle">{{ item.foiz }}</td>
      </template>
      <template justify-center
        v-slot:item.lavozim_soni="{ item }">
        <td class="myTitle">{{ item.lavozim_soni }}</td>
      </template>
      <template justify-center
        v-slot:item.foizda="{ item }">
        <td class="myTitle">{{ item.foizda }}</td>
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
</v-card>
</template>


<script>
  export default {
    data: () => ({
      dialog: false,
      dialog2: false,
      dialogDelete: false,
      search: "",
      headers: [
        {
          text: "ID",
          align: "start",
          sortable: false,
          value: "ID"
        },
        { text: "Tuzilma nomi", value: "tuzilma_nomi" },
        { text: "Jami shtatlar soni", value: "shtat" },
        { text: "Ishlayotgan hodimlar soni", value: "hodimlar_soni" },
        { text: "%", value: "foiz" },
        { text: "Vakant lavozimlar soni", value: "lavozim_soni" },
        { text: "%", value: "foizda" },
        { text: 'Actions', value: 'actions', sortable: false },
      ],
      desserts: [],

      editedIndex: -1,

      editedItem: {
        ID: '',
        tuzilma_nomi: '',
        shtat: '',
        hodimlar_soni: '',
        foiz:'',
        lavozim_soni:'',
        foizda:'',
        actions:'',
      },

      defaultItem: {
        ID: '',
        tuzilma_nomi: '',
        shtat: '',
        hodimlar_soni: '',
        foiz:'',
        lavozim_soni:'',
        foizda:'',
        actions:'',
      },
    }),

    computed: {
      formTitle () {
        return this.editedIndex === -1 ? 'Qo\'shish' : 'Tahrirlash'
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
      addTuzilma() {
      this.$router.push("addTuzilma")
      },
      addLavozim(){
        this.$router.push("addLavozim")
      },
      initialize () {
        this.desserts = [
        {
          ID: "1",
          tuzilma_nomi: "Uzbekneftgaz",
          shtat: "Jami shtatlar soni",
          hodimlar_soni: "Hodimlar soni",
          foiz: "23%",
          lavozim_soni: "5ta",
          foizda: "25%",
        },
        
      ]
      },
  
/// crud 
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
    ////// end crud
  }
</script>
<style scoped>
.myTitle{
  font-size: 20px !important; 
  font-family: 'Trocchi', serif;
}
</style>