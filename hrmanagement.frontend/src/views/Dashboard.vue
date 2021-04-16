<!--<template>
  <div>
    <h1 class="subheading grey--text">Asosiy menyu</h1>
  </div>
</template>
-->

<template>
  <v-container>
    <v-row class="fill-height pr-9 pl-9 pr-lg-4 pl-lg-4 pr-md-0 pl-md-0 mt-7">
      <!--<h1>Asosiy menu</h1>-->
          <v-col xl="12" lg="12" md="12" sm="12" class="nf-calendar">
            <v-card class="fill-height pa-5">
              <template>
                <div class="main-calendar-right">
                  <p class="main-calendar-right-title">
                    Kalendar
                  </p>
                </div>
                <v-row class="fill-height">
                  <v-col>
                    <v-sheet height="450">
                      <v-calendar
                        :now="today"
                        :value="today"
                        color="primary"
                      >
              </v-calendar>
                    </v-sheet>
                  </v-col>
                </v-row>
              </template>

            </v-card>
          </v-col>
        </v-row>


  </v-container>
</template>

<script>
export default {
  name: "HelloWorld",
  data: () => ({
      today: new Date().format('YYYY-MM-DD'),
      colors: ['#1867c0', '#fb8c00', '#000000'],
    }),
};
</script>
