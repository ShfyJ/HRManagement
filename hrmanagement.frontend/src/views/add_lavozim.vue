<template>
  <v-container
    id="user-profile"
    fluid
    tag="section"
  >
    <v-row justify="center" class="mt-8">
      <v-col
        cols="12"
        md="12"
      >
        <base-material-card>

        <v-toolbar-title>Lavozim qo'shish</v-toolbar-title>
        <v-divider
          class="mx-4"
          inset
          vertical
        ></v-divider>
  <v-form>
    <v-container >
      <v-row>
        <v-col
          cols="12"
          sm="6"
          md="6"
        >
        <v-select
          :items="items1"
          label="лавозим тури:"
          outlined
        ></v-select>
        </v-col>

        <v-col
          cols="12"
          sm="6"
          md="6"
        >
        <v-select
          :items="items2"
          label="лавозим даражаси:"
          outlined
        ></v-select>
        </v-col>

        <v-col
          cols="12"
          sm="6"
          md="6"
        >
          <v-text-field
            label="тартиб рақами:"
            outlined
            value="10"
            
          ></v-text-field>
        </v-col>

        <v-col
          cols="12"
          sm="6"
          md="6"
        >
            <v-checkbox
            v-model="selected"
            label="ёрдамчи персонал"
            value="Aziz"
            ></v-checkbox>
        </v-col>


      </v-row>
        <v-btn color="primary">
            Saqlash
        </v-btn>
        <v-btn @click="chiqish" class="ml-2" color="error">
            Chqish
        </v-btn>
    </v-container>

  </v-form>

        </base-material-card>
      </v-col>
      <v-col
        cols="12"
        md="4"
      >
      </v-col>
    </v-row>
  </v-container>
</template>
<script>
export default {
    data: () => ({
        items1: ['Rais', 'Raisning birinchi o\'rinbosari', 'Rais o\'rinbosari', 'Rahbar', 'Rahbar o\'rinbosari'],
        items2: ['Boshqaruv apparat rahbariyati', 'Boshqaruv apparat mutahasisi', 'Texnik xodimlar', 'Ishlab chiqarish xodimlari', 'Xizmat korsatuvchi xodimlar'],
    }),
    methods:{
        chiqish(){
        this.$router.push({ name: 'projects' });
    },
    }
}
</script>
<!--

      data:() => ({
select: { state: 'Florida', abbr: 'FL' },
        items: [
          { state: 'Florida', abbr: 'FL' },
          { state: 'Georgia', abbr: 'GA' },
          { state: 'Nebraska', abbr: 'NE' },
          { state: 'California', abbr: 'CA' },
          { state: 'New York', abbr: 'NY' },
        ],
    dialog: false,
    content: "",
    date: new Date().toDateString.substr(0, 10),
    dateFormatted: this.formatDate(new Date().toISOString().substr(0, 10)),
    menu1: false,
    
    rules: [
        value => !value || value.size < 2000000 || 'Avatar size should be less than 2 MB!',
    ],

    email: '',
    files: [],
  }),-->