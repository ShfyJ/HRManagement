<template>
    <div>
        <!--<h1> Info about {{id}}</h1>-->
        <v-card>
        <v-card-title class="justify-center myTitle">
        "O'ZBEKNEFTGAZ" AKTSIONERLIK JAMIYATINING
        </v-card-title>
        <v-card-title class="justify-center mt-n7 myTitle">
        "O'ZBEKNEFTGAZ" AKTSIYADORLIK JAMIYATI TO'G'RISIDA MA'LUMOT
        </v-card-title>
        <v-card-title>
        <v-row>
          <v-col cols-12 md-4>

          </v-col>
          <v-col cols-12 md-4>

          </v-col>
          <v-col cols-12 md-4>
            <v-text-field
            v-model="search"
            append-icon="mdi-magnify"
            label="Search"
            single-line
            hide-details
        ></v-text-field>
          </v-col>
        </v-row>
        </v-card-title>
        <v-data-table
        :headers="headers"
        :items="desserts"
        :search="search"
        >
        <template justify-center
        v-slot:item.calories="{ item }">
        <router-link style="text-decoration: none; color: inherit;" :to="`/projects/${id}/${ item.id}`" :key="item.id"><td class="myTitle">{{ item.calories }}</td>
        </router-link>
      </template>
        </v-data-table>
    </v-card>
    <v-btn
            @click="back" 
            class="ma-2 btn btn-primary"
            outlined
            color="indigo"
    >
        Ortga
    </v-btn>
    </div>
</template>
<script>
export default {
    data(){
        return{
            id: this.$route.params['id'],
            search: '',
            headers: [
          {
            text: 'No',
            align: 'start',
            sortable: false,
            value: 'id',
          },
          { text: 'Tuzilma nomi', value: 'calories' },
          { text: 'Jami shtatlar soni', value: 'fat' },
          { text: 'Ishlayotgan xodimlar soni', value: 'carbs' },
          { text: '%', value: 'protein' },
          { text: 'Vakant lavozimlar soni', value: 'iron' },
          { text: '%', value: 'protein' },
        ],
        desserts: [
          {
            id: 1,
            calories: "Rahbariyat",
            fat: 6.0,
            carbs: 24,
            protein: 4.0,
            iron: '1%',
          },
          {
            id: 2,
            calories: "Boshqaruv Raisi Kompleksi",
            fat: 9.0,
            carbs: 37,
            protein: 4.3,
            iron: '1%',
          },
          {
            id: 3,
            calories: "Boshqaruv raisning istiqbolli rivojlantirish va inestitsiyalar bo'yicha birinchi o'rinbosari",
            fat: 16.0,
            carbs: 23,
            protein: 6.0,
            iron: '7%',
          }]

        }
    },
    watch:{
        $route(toRoute){
            this.id=toRoute.params['id']
        }
    },
    methods:{
        back(){
            this.$router.push({name: 'projects'})
        }
    }
}
</script>
