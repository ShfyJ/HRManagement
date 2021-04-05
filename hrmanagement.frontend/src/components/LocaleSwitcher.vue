<template>
      <v-menu offset-y>
        <template v-slot:activator="{ on }">
          <v-btn text v-on="on">
            <v-icon left>expand_more</v-icon>
            
            <span>{{$i18n.locale}}</span>
          </v-btn>
        </template>
        <v-list flat> 
          <v-list-item
            v-for="locale in locales"
            :key="locale"
            @click="switchLocale(locale)"
            active-class="border"
          >
            <v-list-item-title>{{locale}}</v-list-item-title>
          </v-list-item>
        </v-list>
      </v-menu>
        
</template>
<script>
export default {
    name: 'LocaleSwitcher',
    methods:{
        switchLocale(locale){
            if(this.$i18n.locale !== locale){
                this.$i18n.locale=locale;
            }
        }
    },
    data(){
        return{
            locales: ['ru', 'uz']
        }
    }
}
</script>
<style scoped>
li {
    text-decoration: underline;
    color: #459CE7;
    cursor: pointer;
}
</style>