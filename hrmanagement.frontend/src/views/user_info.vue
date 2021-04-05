<template>
    <div>
        <h1> Info about {{id}}</h1>
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
            id: this.$route.params['id']
        }
    },
    watch:{
        $route(toRoute){
            this.id=toRoute.params['id']
        }
    },
    methods:{
        back(){
            this.$router.push({name: 'team'})
        }
    }
}
</script>
