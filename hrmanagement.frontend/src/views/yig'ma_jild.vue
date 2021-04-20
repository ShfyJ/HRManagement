
<template>
        <v-card class="rounded-xl mt-5 " :elevation="4">
                <v-toolbar align="center" flat>
                    <v-toolbar-title>Nusxalar</v-toolbar-title>
                </v-toolbar>
                        <v-row justify="center">
                        <v-col
                            cols="12"
                            md="12"
                        >
                        <v-container>
                            <div>
                                <v-row justify="center">
                                        <v-col cols="12" md="2">
                                   
                        <v-file-input
                            v-model="passport_nusxasi"
                            label="Pasport nusxasi"
                            
                            prepend-icon="mdi-file-word"
                        >
                            <template v-slot:selection="{ text }">
                            <v-chip
                                small
                                label
                                color="primary"
                            >
                                {{ text }}
                            </v-chip>
                            </template>
                        </v-file-input>
                                        </v-col>
                                        <v-col cols="12" md="2">
                        <v-file-input
                            v-model="diplom_nusxasi"
                            label="Diplom nusxasi"
                            
                            prepend-icon="mdi-file-word"
                        >
                            <template v-slot:selection="{ text }">
                            <v-chip
                                small
                                label
                                color="primary"
                            >
                                {{ text }}
                            </v-chip>
                            </template>
                        </v-file-input>
                                        </v-col>
                                        <v-col cols="12" md="2">
                        <v-file-input
                            v-model="mexnat_daftarchasi"
                            label="Mexnat daftarchasi"
                            
                            prepend-icon="mdi-file-word"
                        >
                            <template v-slot:selection="{ text }">
                            <v-chip
                                small
                                label
                                color="primary"
                            >
                                {{ text }}
                            </v-chip>
                            </template>
                        </v-file-input>
                                        </v-col>
                                        <v-col cols="12" md="2">
                        <v-file-input
                            v-model="stir_nusxasi"
                            label="STIR nusxasi"
                            
                            prepend-icon="mdi-file-word"
                        >
                            <template v-slot:selection="{ text }">
                            <v-chip
                                small
                                label
                                color="primary"
                            >
                                {{ text }}
                            </v-chip>
                            </template>
                        </v-file-input>
                                        </v-col>
                                        <v-col cols="12" md="2">
                        <v-file-input
                            v-model="buyruq_nusxasi"
                            label="Buyruq nusxasi"
                            
                            prepend-icon="mdi-file-word"
                        >
                            <template v-slot:selection="{ text }">
                            <v-chip
                                small
                                label
                                color="primary"
                            >
                                {{ text }}
                            </v-chip>
                            </template>
                        </v-file-input>
                                        </v-col>
                                        </v-row>

                            </div>
                        </v-container>
                        </v-col>
                        </v-row>   
        </v-card>
</template>
<script>
export default {
    data: ()=>({
        passport_nusxasi: [],
        diplom_nusxasi: [],
        mexnat_daftarchasi:[],
        stir_nusxasi:[],
        buyruq_nusxasi: [],
    })

}
</script>
   