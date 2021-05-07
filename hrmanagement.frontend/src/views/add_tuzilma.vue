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
            v-model="organizationNameInKrillUz"
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
            v-model="organizationNameInKrillUzShort"
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
            v-model="organizationNameInRu"
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
            v-model="organizationNameInRuShort"
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
            v-model="organizationNameInLatinUz"
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
            v-model="organizationNameInLatinUzShort"
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
        <v-btn @click="submit" color="primary">
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
import axios from "axios"

export default {
      data: () => ({
      organizationNameInLatinUz: '',
      organizationNameInKrillUz: '',
      organizationNameInRu: '',
      organizationNameInKrillUzShort: '',
      organizationNameInLatinUzShort: '',
      organizationNameInRuShort: '',

    }),
    methods:{
        chiqish(){
        this.$router.push({ name: 'projects' })
        },

        submit(){
        axios
          .post('https://localhost:44343/organization', {
            organizationNameInKrillUz:  this.organizationNameInKrillUz,
            organizationNameInLatinUz: this.organizationNameInLatinUz,
            organizationNameInRu: this.organizationNameInRu,
            organizationNameInEng: '',
            organizationNameInKrillUzShort: this.organizationNameInKrillUzShort,
            organizationNameInLatinUzShort: this.organizationNameInLatinUzShort,
            organizationNameInRuShort: this.organizationNameInRuShort,
            status: true
        },
        {
          "headers": {
          "content-type": "application/json",
        },
        })
          .then(response => (console.log(response)));
        },
    },
    }

</script>
