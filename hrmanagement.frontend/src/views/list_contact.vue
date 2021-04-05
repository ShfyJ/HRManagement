<template>
  <v-card>
    <v-card-title>
      {{$t('phone_numbers_of_employees')}}
      <v-spacer></v-spacer>
      <v-text-field
        v-model="search"
        append-icon="mdi-magnify"
        :label="$t('search')"
        single-line
        hide-details
      ></v-text-field>
    </v-card-title>
    <v-data-table :headers="headers" :items="desserts" :search="search">
      <template v-slot:top>
        <v-toolbar flat color="white">
          <v-toolbar-title>
            {{$t('list_of_users')}}
          </v-toolbar-title>
          <v-divider class="mx-6" inset vertical=""></v-divider>
          <v-spacer></v-spacer>
        </v-toolbar>
          <div  class="mt-8">
          </div>
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
<style scoped>
.zoom {
  transition: transform .2s;
}

.zoom:hover {
  -ms-transform: scale(1.5); /* IE 9 */
  -webkit-transform: scale(1.5); /* Safari 3-8 */
  transform: scale(1.3); 
}
.myTitle{
  font-size: 22px !important;
  font-family: 'Bookman', serif;
}
</style>
<!--
<template>
<div>
<v-row class="mt-15">
<v-card
    class="mx-auto"
    max-width="400"
  >
    <v-card-text>
      <v-row align="center">
          <v-col md="4" >
          </v-col>
        <v-col md="4" >
          <v-avatar class="mt-3 mb-3" size="100px">
          <v-img
            src="/img4.jpg"
            alt="Sunny image"            
          ></v-img>
          </v-avatar>
        </v-col>
          <v-col md="4" >
          </v-col>
      </v-row>
    </v-card-text>
    
    <v-list-item two-line>
      <v-list-item-content align="center">
        <v-list-item-title class="headline">
          Aziz Bohidjonov
        </v-list-item-title>
        <v-list-item-subtitle>1-toifali mutahasis</v-list-item-subtitle>
      </v-list-item-content>
    </v-list-item>

    <v-list class="transparent">
      <v-list-item
        v-for="item in contact"
        :key="item.day"
      >
        <v-list-item-title>{{ item.day }}</v-list-item-title>
        <v-list-item-subtitle class="text-right">
          {{ item.temp }}
        </v-list-item-subtitle>
      </v-list-item>
    </v-list>
  </v-card>
</v-row>
</div>
</template>
-->
<!--
<script>
  export default {
    data () {
      return {
        contact: [
          { day: 'Ichki',  temp: '+998935386448' },
          { day: 'Mobil',  temp: '+998935386448' },
          { day: 'Shahar',    temp: '+998935386448' },
        ],
      }
    },
  }
</script>


<style scoped>
</style>
-->