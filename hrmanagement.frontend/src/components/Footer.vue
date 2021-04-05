<template>
  <v-footer :elevation="10" dark padless app inset>
    <v-card class="flex" flat tile color="#1a8cff">
      <v-card-text class="py-2 white--text text-center"
        >{{ new Date().getFullYear() }}-<strong>{{$t("kollektiv")}}</strong></v-card-text
      >
    </v-card>
  </v-footer>
</template>
