<template>
<v-card>
<v-card-title>
      <v-spacer></v-spacer>
      <v-text-field 
          v-model="search"
          append-icon="mdi-magnify"
          :label="$t('search')"
          single-line
          hide-details
      ></v-text-field>
</v-card-title>
    
  <v-data-table
    :headers="headers"
    :items="desserts"
    sort-by="calories"
    class="elevation-1 myTitle"
    :search="search" 
    fixed-header 
    height="600"
  >
    <template v-slot:top>
      <v-toolbar
        flat
      >
        <v-toolbar-title class="dataTable">{{ $t('list_of_users') }}</v-toolbar-title>
        <v-divider
          class="mx-4"
          inset
          vertical
        ></v-divider>
        <v-spacer></v-spacer>
        <v-btn
            class="nf-bor-radius white--text"
            color="grey lighten-1"
            large
            dark
            v-on="on"
            text
          >
            <v-icon left>mdi-arrow-collapse-down</v-icon>
            <download-excel
              :data="desserts"
              :fields="xls_fields"
              :name="'users_info' + '.xls'"
              class="download_excel_btn"
            >
              Excell
            </download-excel>
          </v-btn>
          <v-btn
            class="nf-bor-radius white--text"
            color="grey lighten-1"
            large
            dark
            v-on="on"
            text
            @click="downloadPDF"
          >
            <v-icon left>mdi-arrow-collapse-down</v-icon>
            Download pdf
          </v-btn>
              <table id="pdf">
  
              </table>


          <v-btn
          @click="addCategory" color="success" dark class="mb-2 mr-2" v-on="on" text
            ><v-icon left>mdi-plus</v-icon>{{$t('add_user')}}</v-btn
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
            color="blue"
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
      <v-data-table class="dataTable" overflow-x scroll  :headers="headers" :items="desserts" :search="search" fixed-header height="600">
      <template v-slot:top>
        <v-toolbar  flat color="white">
          <v-toolbar-title>
            Xodimlar ro'yhati
          </v-toolbar-title>
          <v-divider class="mx-4" inset vertical=""></v-divider>
          <v-spacer></v-spacer>
          <v-btn
            class="nf-bor-radius white--text"
            color="grey lighten-1"
            large
            dark
            v-on="on"
            text
          >
            <v-icon left>mdi-arrow-collapse-down</v-icon>
            <download-excel
              :data="desserts"
              :fields="xls_fields"
              :name="'users_info' + '.xls'"
              class="download_excel_btn"
            >
              Excell
            </download-excel>
          </v-btn>
        </v-toolbar>
      </template>
      <template justify-center
        v-slot:item.calories="{ item }">
        <v-avatar class="d-flex p-2 " size="40px" small ><img  :src="item.calories"/></v-avatar>
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
                      v-model="editedItem.fat"
                      label="F.I.SH"
                    ></v-text-field>
                  </v-col>
                  <v-col
                    cols="12"
                    sm="6"
                    md="4"
                  >
                    <v-text-field
                      v-model="editedItem.ushbu_sanadan"
                      label="Ushbu sanadan"
                    ></v-text-field>
                  </v-col>
                  <v-col
                    cols="12"
                    sm="6"
                    md="4"
                  >
                    <v-text-field
                      v-model="editedItem.carbs"
                      label="Joriy Lavozimi"
                    ></v-text-field>
                  </v-col>
                  <v-col
                    cols="12"
                    sm="6"
                    md="4"
                  >
                    <v-text-field
                      v-model="editedItem.age"
                      label="Yoshi"
                    ></v-text-field>
                  </v-col>
                  <v-col
                    cols="12"
                    sm="6"
                    md="8"
                  >
                    <v-text-field
                      v-model="editedItem.mutahasislik"
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
        v-slot:item.calories="{ item }">
        <img  :class="`rounded-circle`" class="mt-1 mb-1 zoom" height="50px" :src="item.calories"/>
      </template>
      <template justify-center
        v-slot:item.age="{ item }">
        <td class="myTitle">{{ item.age }}</td>
      </template>
      <template justify-center
        v-slot:item.fat="{ item }">
        <router-link style="text-decoration: none; color: inherit;" :to="`/team/${ item.fat}/umumiy_malumot`" :key="item.fat"><td class="myTitle">{{ item.fat }}</td>
        </router-link>
      </template>
      <template justify-center
        v-slot:item.name="{ item }">
        <td class="myTitle">{{ item.name }}</td>
      </template>
      <template justify-center
        v-slot:item.ushbu_sanadan="{ item }">
        <td class="myTitle">{{ item.ushbu_sanadan }}</td>
      </template>
            <template justify-center
        v-slot:item.carbs="{ item }">
        <td class="myTitle">{{ item.carbs }}</td>
      </template>
      <template justify-center
        v-slot:item.tarmoqda="{ item }">
        <td class="myTitle">{{ item.tarmoqda }}</td>
      </template>
      <template justify-center
        v-slot:item.staj="{ item }">
        <td class="myTitle">{{ item.staj }}</td>
      </template>
            <template justify-center
        v-slot:item.mutahasislik="{ item }">
        <td class="myTitle">{{ item.mutahasislik }}</td>
      </template>
    <template v-slot:no-data>
<h4>No Data</h4>
    </template>
  </v-data-table>
</v-card>
</template>

<script src="https://cdnjs.cloudflare.com/ajax/libs/jspdf-autotable/3.5.14/jspdf.plugin.autotable.js"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/jspdf-autotable/3.5.14/jspdf.plugin.autotable.min.js"></script>

<script>
import jsPDF from 'jspdf'
import 'jspdf-autotable'
  export default {
    name: 'pdf',
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
          value: "name"
        },
        { text: "Fotosurat", sortable: false, value: "calories" },
        { text: "F.I.SH", value: "fat" },
        { text: "Ushbu sanadan", value: "ushbu_sanadan" },
        { text: "Joriy Lavozimi", value: "carbs" },
        { text: "Yoshi", value: "age" },
        { text: "Tarmoqda", value: "tarmoqda" },
        { text: "Umumiy staji", value: "staj" },
        { text: "Mutahasisligi", value: "mutahasislik" },
        { text: 'Actions', value: 'actions', sortable: false },
      ],
      desserts: [],

      editedIndex: -1,

      editedItem: {
        name: '',
        calories: '',
        ushbu_sanadan: '',
        carbs: '',
        age:'',
        tarmoqda:'',
        staj:'',
        mutahasislik:'',
        actions:'',
      },

      defaultItem: {
        name: '',
        calories: '',
        ushbu_sanadan: '',
        carbs: '',
        age:'',
        tarmoqda:'',
        staj:'',
        mutahasislik:'',
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
    downloadPDF(){
      var pdf=new jsPDF();
      pdf.autoTable({html: '#pdf'})
      pdf.autoTable({
        theme: 'plain',
        pageBreak: 'auto', // 'auto', 'avoid' or 'always'
        tableWidth: 'auto',
        head: [['ID', 'F.I.SH', 'Ushbu sanadan', 'Joriy Lavozimi', 'Yoshi', 'Tarmoqda', 'Umumiy staji', 'Mutahasisligi']],
        body: [
          ['1', 'Aziz Bohidjonov', '02.06.2020','1-toifali mutaxasis', '23','9oy 3kun', '28y 1o 1k', 'Muhandis'],
          ['2', 'Aziz Bohidjonov', '02.06.2020','1-toifali mutaxasis', '23','9oy 3kun', '28y 1o 1k', 'Muhandis'],
        ],
      })
      pdf.save('info.pdf');
    },


      addCategory() {
      this.$router.push("addUser")
      },
      initialize () {
        this.desserts = [
        {
          name: "1",
          calories: "/img3.jpg",
          fat: "Aziz Bohidjonov",
          ushbu_sanadan: "02.06.2020",
          carbs: "1-toifali mutaxasis",
          age: "23",
          tarmoqda: "9oy 3kun",
          staj: "28й 1о 1к",
          mutahasislik: "электр алоқа муҳандиси	"
        },
        {
          name: "2",
          calories: "/img4.jpg",
          fat: "Dilmurod ubaydullayev",
          ushbu_sanadan: "02.06.2020",
          carbs: "Yetakchi mutahasis",
          age: "22",
          tarmoqda: "8oy 20kun",
          staj: "36й 11о 25к",
          mutahasislik: "геология, минералогия, патрология	"
        },
        {
          name: "3",
          calories: "/img2.jpg",
          fat: "Jamshid Bohidjonov",
          ushbu_sanadan: "02.06.2020",
          carbs: "1-toifali mutaxasis",
          age: "24",
          tarmoqda: "5oy 3kun",
          staj: "25й 4о 10к",
          mutahasislik: "автомобиллар ва автомобиллар хўжалиги	"
        },
        {
          name: "4",
          calories: "/img3.jpg",
          fat: "Aziz Bohidjonov",
          ushbu_sanadan: "02.06.2020",
          carbs: "1-toifali mutaxasis",
          age: "23",
          tarmoqda: "9oy 3kun",
          staj: "28й 1о 1к",
          mutahasislik: "электр алоқа муҳандиси	"
        },
        {
          name: "5",
          calories: "/img4.jpg",
          fat: "Dilmurod ubaydullayev",
          ushbu_sanadan: "02.06.2020",
          carbs: "Yetakchi mutahasis",
          age: "22",
          tarmoqda: "8oy 20kun",
          staj: "36й 11о 25к",
          mutahasislik: "геология, минералогия, патрология	"
        },
        {
          name: "6",
          calories: "/img2.jpg",
          fat: "Jamshid Bohidjonov",
          ushbu_sanadan: "02.06.2020",
          carbs: "1-toifali mutaxasis",
          age: "24",
          tarmoqda: "5oy 3kun",
          staj: "25й 4о 10к",
          mutahasislik: "автомобиллар ва автомобиллар хўжалиги	"
        },
        {
          name: "7",
          calories: "/img3.jpg",
          fat: "Aziz Bohidjonov",
          ushbu_sanadan: "02.06.2020",
          carbs: "1-toifali mutaxasis",
          age: "23",
          tarmoqda: "9oy 3kun",
          staj: "28й 1о 1к",
          mutahasislik: "электр алоқа муҳандиси	"
        },
        {
          name: "8",
          calories: "/img4.jpg",
          fat: "Dilmurod ubaydullayev",
          ushbu_sanadan: "02.06.2020",
          carbs: "Yetakchi mutahasis",
          age: "22",
          tarmoqda: "8oy 20kun",
          staj: "36й 11о 25к",
          mutahasislik: "геология, минералогия, патрология	"
        },
        {
          name: "9",
          calories: "/img2.jpg",
          fat: "Jamshid Bohidjonov",
          ushbu_sanadan: "02.06.2020",
          carbs: "1-toifali mutaxasis",
          age: "24",
          tarmoqda: "5oy 3kun",
          staj: "25й 4о 10к",
          mutahasislik: "автомобиллар ва автомобиллар хўжалиги	"
        },
        {
          name: "10",
          calories: "/img3.jpg",
          fat: "Aziz Bohidjonov",
          ushbu_sanadan: "02.06.2020",
          carbs: "1-toifali mutaxasis",
          age: "23",
          tarmoqda: "9oy 3kun",
          staj: "28й 1о 1к",
          mutahasislik: "электр алоқа муҳандиси	"
        },
        {
          name: "11",
          calories: "/img4.jpg",
          fat: "Dilmurod ubaydullayev",
          ushbu_sanadan: "02.06.2020",
          carbs: "Yetakchi mutahasis",
          age: "22",
          tarmoqda: "8oy 20kun",
          staj: "36й 11о 25к",
          mutahasislik: "геология, минералогия, патрология	"
        },
        {
          name: "12",
          calories: "/img2.jpg",
          fat: "Jamshid Bohidjonov",
          ushbu_sanadan: "02.06.2020",
          carbs: "1-toifali mutaxasis",
          age: "24",
          tarmoqda: "5oy 3kun",
          staj: "25й 4о 10к",
          mutahasislik: "автомобиллар ва автомобиллар хўжалиги	"
        }
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
.dataTable {
   font-size: 25px !important;
}
.zoom {
  transition: transform .2s;
}

.zoom:hover {
  -ms-transform: scale(1.5); /* IE 9 */
  -webkit-transform: scale(1.5); /* Safari 3-8 */
  transform: scale(1.71); 
}
.myTitle{
  font-size: 20px !important; 
  font-family: 'Trocchi', serif;
}
</style>