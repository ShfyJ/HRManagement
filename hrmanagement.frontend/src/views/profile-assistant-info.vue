<template>
  <v-card>
    <v-tabs
      v-model="tab"
      background-color="transparent"
      grow
    >
      <v-tab>
        <v-icon left>
          mdi-account
        </v-icon>
        Malumotlarni ozgartirish
      </v-tab>
      <v-tab>
        <v-icon left>
          mdi-lock
        </v-icon>
        Parolni ozgartirish
      </v-tab>
      <v-tab-item>
        <v-card flat>
            <v-form v-model="valid">
                <v-container class="col-lg-6 col-12 ">
                <v-row
                class="mt-8 justify-xl-center justify-lg-space-between justify-center">
                    <v-col
                    cols="12"
                    md="4"
                    >
                    <v-text-field
                        v-model="firstname"
                        :rules="nameRules"
                        
                        label="Ism"
                        required
                    ></v-text-field>
                    </v-col>

                    <v-col
                    cols="12"
                    md="4"
                    >
                    <v-text-field
                        v-model="Familiya"
                        :rules="nameRules"
                        
                        label="Familiya"
                        required
                    ></v-text-field>
                    </v-col>

                    <v-col
                    cols="12"
                    md="4"
                    >
                    <v-text-field
                        v-model="email"
                        label="Otasining ismi"
                        required
                    ></v-text-field>
                    </v-col>
                </v-row>
                </v-container>
                <v-container class="col-lg-6 col-12">
                <v-row>
                    <v-col
                    cols="12"
                    md="4"
                    >
                    <v-text-field
                        v-model="firstname"
                        :rules="nameRules"
                        
                        label="Lavozimi"
                        required
                    ></v-text-field>
                    </v-col>

                    <v-col
                    cols="12"
                    md="4"
                    >
                    <v-text-field
                        v-model="lastname"
                        :rules="nameRules"
                        
                        label="Bolinma"
                        required
                    ></v-text-field>
                    </v-col>

                    <v-col
                    cols="12"
                    md="4"
                    >
                    <v-text-field
                        v-model="email"
                        
                        label="Tashkilot"
                        required
                    ></v-text-field>
                    </v-col>
                </v-row>
                </v-container>
                <v-container class="col-lg-6 col-12">
                <v-row>
                    <v-col
                    cols="12"
                    md="4"
                    >
                    <v-text-field
                        v-model="firstname"
                        :rules="nameRules"
                        
                        label="Yashash manzili"
                        required
                    ></v-text-field>
                    </v-col>

                    <v-col
                    cols="12"
                    md="4"
                    >
                    <v-text-field
                        v-model="lastname"
                        :rules="nameRules"
                        
                        label="Ish telefoni"
                        required
                    ></v-text-field>
                    </v-col>

                    <v-col
                    cols="12"
                    md="4"
                    >
                    <v-text-field
                        v-model="email"
                        
                        label="Mobil telefon"
                        required
                    ></v-text-field>
                    </v-col>
                </v-row>
                </v-container>
            </v-form>
        </v-card>
      </v-tab-item>
      <v-tab-item>
        <v-card >
          
        </v-card>
      </v-tab-item>
    </v-tabs>

</v-card>
</template>

<script>
  export default {
    data () {
      return {
      }
    },
  }
</script>

<style>
/* Helper classes */
.basil {
  background-color: #FFFBE6 !important;
}
.basil--text {
  color: #356859 !important;
}
</style>