<!--<template>
    <v-card>
    <v-card-title>
      Bugungi tug'ilgan kunlar ro'yhati
    </v-card-title>
    <v-data-table fixed-header  :headers="headers" :items="desserts" :search="search" height="780">
      <template class="myTitle" v-slot:item.calories="{ item }">
      <v-badge
        avatar
        bottom
        bordered
        overlap
        class="badge"
      >
          <template  v-slot:badge>
          <v-avatar  >
            <v-img src="/img3.jpg"></v-img>
          </v-avatar>
        </template>
        <v-avatar class="mt-3 mb-3" size="90px"><img :src="item.calories"/></v-avatar>
        </v-badge>
      </template>
    </v-data-table>
  </v-card>
</template>

<script>
export default {
  data() {
    return {
      search: "",
      headers: [
        { text: "Photo", value: "calories" },
        { text: "F.I.SH", value: "fat" },
        { text: "Lavozimi", value: "carbs" },
      
      ],
      xls_fields: {
        ID: "name",
        "F.I.SH": "fat",
        Lavozimi: "carbs",
        Mobil: "iron"
      },
      desserts: [
        {
          name: "1",
          calories: "/img3.jpg",
          fat: "Aziz Bohidjonov",
          carbs: "1-toifali mutaxasis",
          protein: "+998712234211",
          iron: "+998935386448",
          mobil: "+998935386448"
        },
        {
          name: "2",
          calories: "/img2.jpg",
          fat: "Dilmurod ubaydullayev",
          carbs: "1-toifali mutaxasis",
          protein: "+998712646448",
          iron: "+998935662411",
          mobil: "+998935662411"
        },
        {
          name: "3",
          calories: "/img2.jpg",
          fat: "Jamshid Bohidjonov",
          carbs: "1-toifali mutaxasis",
          protein: "+998935662411",
          iron: "+998940003264",
          mobil: "+998940003264"
        },
        {
          name: "4",
          calories: "/img2.jpg",
          fat: "Jamshid Bohidjonov",
          carbs: "1-toifali mutaxasis",
          protein: "+998935662411",
          iron: "+998940003264",
          mobil: "+998940003264"
        },
        {
          name: "4",
          calories: "/img2.jpg",
          fat: "Jamshid Bohidjonov",
          carbs: "1-toifali mutaxasis",
          protein: "+998935662411",
          iron: "+998940003264",
          mobil: "+998940003264"
        },
        {
          name: "4",
          calories: "/img2.jpg",
          fat: "Jamshid Bohidjonov",
          carbs: "1-toifali mutaxasis",
          protein: "+998935662411",
          iron: "+998940003264",
          mobil: "+998940003264"
        },
        {
          name: "4",
          calories: "/img2.jpg",
          fat: "Jamshid Bohidjonov",
          carbs: "1-toifali mutaxasis",
          protein: "+998935662411",
          iron: "+998940003264",
          mobil: "+998940003264"
        },
        {
          name: "4",
          calories: "/img2.jpg",
          fat: "Jamshid Bohidjonov",
          carbs: "1-toifali mutaxasis",
          protein: "+998935662411",
          iron: "+998940003264",
          mobil: "+998940003264"
        },
        {
          name: "4",
          calories: "/img2.jpg",
          fat: "Jamshid Bohidjonov",
          carbs: "1-toifali mutaxasis",
          protein: "+998935662411",
          iron: "+998940003264",
          mobil: "+998940003264"
        },
        {
          name: "4",
          calories: "/img2.jpg",
          fat: "Jamshid Bohidjonov",
          carbs: "1-toifali mutaxasis",
          protein: "+998935662411",
          iron: "+998940003264",
          mobil: "+998940003264"
        },
        {
          name: "4",
          calories: "/img2.jpg",
          fat: "Jamshid Bohidjonov",
          carbs: "1-toifali mutaxasis",
          protein: "+998935662411",
          iron: "+998940003264",
          mobil: "+998940003264"
        },
        
      ]
    };
  }
};
</script>

<style scoped>
.badge{
  padding-top: -40px;
  size: 50px;
}
.myTitle{
  font-size: 20px !important;
  font-family: 'Bookman', serif;
}
</style>
-->
<!--
<style scoped lang="css">
  #login {
    height: 50%;
    width: 100%;
    position: absolute;
    top: 0;
    left: 0;
    content: "";
    z-index: 0;
  }
</style>
-->

<template>
  <v-card color="white">
    <v-card-title class="text-center justify-center py-6">
      <h4 class=" display-1 basil--text">
        {{ $t('list_of_birthdays')}} {{ moment(new Date()).lang("uz-latn").format('DD-MMMM ') }}
      </h4>
    </v-card-title>
    <v-tabs
      v-model="tab"
      background-color="transparent"
      color="#4da6ff"
      grow
    >
      <v-tab
        v-for="item in items"
        :key="item"
      >
        {{ item }}
      </v-tab>
    </v-tabs>

    <v-tabs-items v-model="tab">
      <v-tab-item
        v-for="item in items"
        :key="item"
      >
<v-card>
  <v-card-title>
  </v-card-title>
    <v-data-table fixed-header  :headers="headersTranslate" :items="desserts" :search="search" height="780">
      <template v-slot:item.name="{ item }">
        <v-avatar :class="`rounded-t-xl rounded-b-xl`" class="mt-3 mb-3" size="90px"><img :src="item.name"/></v-avatar>
      </template>
      <template v-slot:item.calories="{ item }">
        <v-avatar :class="`rounded-t-xl rounded-b-xl`" class="mt-3 mb-3 zoom" size="90px"><img :src="item.calories"/></v-avatar>
      </template>
      <template justify-center
        v-slot:item.fat="{ item }">
        <td class="myTitle">{{ item.fat }}</td>
      </template>
      <template justify-center
        v-slot:item.carbs="{ item }">
        <td class="myTitle">{{ item.carbs }}</td>
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
        v-slot:item.protein="{ item }">
        <td class="myTitle">{{ item.protein }}</td>
      </template>
      <template justify-center
        v-slot:item.iron="{ item }">
        <td class="myTitle">{{ item.iron }}</td>
      </template>
            <template justify-center
        v-slot:item.mobil="{ item }">
        <td class="myTitle">{{ item.mobil }}</td>
      </template>
    </v-data-table>
  </v-card>
      </v-tab-item>
    </v-tabs-items>
  </v-card>
</template>
<script>
  export default {
    computed:{
      headersTranslate: function() {
        return [
          { text: this.$i18n.t("birthday"), value: "name" },
          { text: this.$i18n.t("Photo"), value: "calories" },
          {
            text: this.$i18n.t("fullname"),
            value: "fat"
          },
          {
            text: this.$i18n.t("department_name"),
            value: "protein"
          },
          { text: this.$i18n.t("lavozim_name"), value: "carbs" },
        ];
      }
    },
      created() {
          this.randomize()
        },
          methods: {
          randomize() {
            for (let i = this.desserts.length - 1; i > 0; i--) {
              let j = Math.floor(Math.random() * (i + 1));
              let temp = this.desserts[i];
              this.desserts[i] = this.desserts[j];
              this.desserts[j] = temp;
            }
            return this.desserts;
              }
        },
    data () {
      return {
        
      search: "",
      headers: [
        { text: "Tugilgan kun", value: "name" },
        { text: "Photo", value: "calories" },
        { text: "F.I.SH", value: "fat" },
        { text: "Departamenti", value: "protein" },
        { text: "Lavozimi", value: "carbs" },
      
      ],
      desserts: [
        {
          name: "/img2.jpg",
          calories: "/img3.jpg",
          fat: "Aziz Bohidjonov",
          carbs: "1-toifali mutaxasis",
          protein: "IKT",
          iron: "+998935386448",
          mobil: "+998935386448"
        },
        {
          name: "/img2.jpg",
          calories: "/img4.jpg",
          fat: "Dilmurod ubaydullayev",
          carbs: "1-toifali mutaxasis",
          protein: "IKT",
          iron: "+998935662411",
          mobil: "+998935662411"
        },
        {
          name: "/img2.jpg",
          calories: "/img2.jpg",
          fat: "Jamshid Bohidjonov",
          carbs: "1-toifali mutaxasis",
          protein: "IKT",
          iron: "+998940003264",
          mobil: "+998940003264"
        },
        {
          name: "/img2.jpg",
          calories: "/img3.jpg",
          fat: "Jamshid Bohidjonov",
          carbs: "1-toifali mutaxasis",
          protein: "IKT",
          iron: "+998940003264",
          mobil: "+998940003264"
        },
        {
          name: "/img2.jpg",
          calories: "/img4.jpg",
          fat: "Jamshid Bohidjonov",
          carbs: "1-toifali mutaxasis",
          protein: "IKT",
          iron: "+998940003264",
          mobil: "+998940003264"
        },
        {
          name: "/img2.jpg",
          calories: "/img4.jpg",
          fat: "Jamshid Bohidjonov",
          carbs: "1-toifali mutaxasis",
          protein: "IKT",
          iron: "+998940003264",
          mobil: "+998940003264"
        },
        {
          name: "/img2.jpg",
          calories: "/img3.jpg",
          fat: "Jamshid Bohidjonov",
          carbs: "1-toifali mutaxasis",
          protein: "IKT",
          iron: "+998940003264",
          mobil: "+998940003264"
        },
        {
          name: "/img2.jpg",
          calories: "/img2.jpg",
          fat: "Jamshid Bohidjonov",
          carbs: "1-toifali mutaxasis",
          protein: "IKT",
          iron: "+998940003264",
          mobil: "+998940003264"
        },
        {
          name: "/img2.jpg",
          calories: "/img2.jpg",
          fat: "Jamshid Bohidjonov",
          carbs: "1-toifali mutaxasis",
          protein: "IKT",
          iron: "+998940003264",
          mobil: "+998940003264"
        },
        {
          name: "/img2.jpg",
          calories: "/img2.jpg",
          fat: "Jamshid Bohidjonov",
          carbs: "1-toifali mutaxasis",
          protein: "IKT",
          iron: "+998940003264",
          mobil: "+998940003264"
        },
        {
          name: "/img2.jpg",
          calories: "/img2.jpg",
          fat: "Jamshid Bohidjonov",
          carbs: "1-toifali mutaxasis",
          protein: "IKT",
          iron: "+998940003264",
          mobil: "+998940003264"
        },
      ],
        tab: null,
        items: [
          'Bugungi', 'Ertangi', 'Ertadan keyingi',
        ],
      }
    },
  }
</script>
<style>
.basil {
  background-color: #FFFBE6 !important;
}
.basil--text {
  color: #356859 !important;
}
.badge{
  size: 100px;
}
.dataTable {
  font-size: 25px !important;
}
.zoom {
  transition: transform .2s;
}

.zoom:hover {
  -ms-transform: scale(1.5); /* IE 9 */
  -webkit-transform: scale(1.5); /* Safari 3-8 */
  transform: scale(1.5); 
}

.myTitle{
  font-size: 20px !important; 
  font-family: 'Trocchi', serif;
}
table.v-table thead th {
      font-size: 20px !important;

}

.v-data-table thead th{
  font-size: 18px !important;
  font-family: 'Trocchi', serif;
}
</style>