<!--<template>
  <div>
    <h1 class="subheading grey--text">Asosiy menyu</h1>
  </div>
</template>
-->

<template>
    <v-row class="fill-height pr-11 pl-11 pr-lg-4 pl-lg-4 pr-md-0 pl-md-0 mt-7">
      <!--<h1>Asosiy menu</h1>-->
          <v-col xl="12" lg="12" md="12" sm="12" class="nf-calendar">
                    <v-card class=" mt-5 mb-15" :elevation="4">
                <v-toolbar align="center" flat>
                    <v-toolbar-title>Kalendar</v-toolbar-title>
                </v-toolbar>
            <v-container
                id="user-profile"
                fluid
                tag="section"
            >
                <v-row justify="center" class="mb-15">
                <v-col
                    cols="12"
                    md="11"
                >
                    <base-material-card>
                      <template>
                        <v-row class="fill-height">
                          <v-col>
                            <v-sheet height="600" :elevation="1">
                              <v-calendar
                                :now="today"
                                :value="today"
                                color="primary"
                                ref="calendar"
                                :weekdays="[1, 2, 3, 4, 5, 6, 0]" 
                              >
                      </v-calendar>
                            </v-sheet>
                          </v-col>
                        </v-row>
                        <v-row>
                          <v-btn
                            class="mx-2"
                            fab
                            dark
                            small
                            color="primary"
                          >
                            <v-icon dark>
                              mdi-chevron-left
                            </v-icon>
                          </v-btn>
                          <v-btn
                            class="mx-2"
                            fab
                            dark
                            small
                            color="primary"
                          >
                            <v-icon dark>
                              mdi-chevron-right
                            </v-icon>
                          </v-btn>
                        </v-row>
                      </template>
                    </base-material-card>
                </v-col>          
                </v-row>
            </v-container>
        </v-card>
          </v-col>
        </v-row>
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
