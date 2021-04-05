<template>

  <v-card>
    <v-card-title>
      «Ўзбекнефтгаз» акционерлик жамияти ходимлари телефон рақамлари
      <v-spacer></v-spacer>
      <v-text-field
        v-model="search"
        append-icon="mdi-magnify"
        label="Qidirish"
        single-line
        hide-details
      ></v-text-field>
    </v-card-title>
    <v-data-table :headers="headers" :items="desserts" :search="search">
      <template v-slot:top>
        <v-toolbar flat color="white">
          <v-toolbar-title>
            Xodimlar ro'yhati
          </v-toolbar-title>
          <v-divider class="mx-6" inset vertical=""></v-divider>
          <v-spacer></v-spacer>
        </v-toolbar>
          <div  class="mt-8">

          </div>
      </template>
      <template v-slot:item.calories="{ item }">
        <v-avatar class="mt-3 mb-3" size="90px"><img :src="item.calories"/></v-avatar>
      </template>
      <template v-slot:no-data>
        <v-btn color="primary" @click="initialize"> Reset</v-btn>
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
        {
          text: "ID",
          align: "start",
          sortable: false,
          value: "name"
        },
        { text: "Photo", value: "calories" },
        { text: "F.I.SH", value: "fat" },
        { text: "Lavozimi", value: "carbs" },
        { text: "Ichki", value: "protein" },
        { text: "Mobil", value: "iron" },
        { text: "Shahar", value: "mobil" }
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
        }
      ]
    };
  }
};
</script>
