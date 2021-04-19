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

        <v-toolbar-title>Tarkibiy tuzilma qo'shish</v-toolbar-title>
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
          <v-text-field
            label="тўлиқ номи (ўзбек тилида)*:"
            outlined
          ></v-text-field>
        </v-col>

        <v-col
          cols="12"
          sm="6"
          md="6"
        >
          <v-text-field
            label="қисқа номи (ўзбек тилида)*:"
            outlined
          ></v-text-field>
        </v-col>

        <v-col
          cols="12"
          sm="6"
          md="6"
        >
          <v-text-field
            label="тўлиқ номи (рус тилида):"
            outlined
          ></v-text-field>
        </v-col>

        <v-col
          cols="12"
          sm="6"
          md="6"
        >
          <v-text-field
            label="қисқа номи (рус тилида):"
            outlined
          ></v-text-field>
        </v-col>
        <v-col
          cols="12"
          sm="6"
          md="6"
        >
          <v-text-field
            label="тўлиқ номи (лотин ёзувида):"
            outlined
          ></v-text-field>
        </v-col>
                <v-col
          cols="12"
          sm="6"
          md="6"
        >
          <v-text-field
            label="қисқа номи (лотин ёзувида):"
            outlined
          ></v-text-field>
        </v-col>
                        <v-col
          cols="12"
          sm="6"
          md="6"
        >
          <v-text-field
            label="рўйхатдаги тартиб рақами:"
            outlined
          ></v-text-field>
        </v-col>
                        <v-col
          cols="12"
          sm="6"
          md="6"
        >
          <v-text-field
            label="хат индекси:"
            outlined
          ></v-text-field>
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