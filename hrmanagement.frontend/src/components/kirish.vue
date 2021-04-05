<template>
    <v-dialog
      v-model="dialog"
      persistent
      max-width="600px"
      transition="fab-transition"
    >
      <template v-slot:activator="{ on, attrs }">
        <v-btn text
            v-for="item in items"
            :key="item.title"
            v-bind="attrs"
            v-on="on"
      >
        <span>{{item.title}}</span>
        <v-icon right>exit_to_app</v-icon>
      </v-btn>
      </template>
      <v-card>
        <v-card-title>
          <span class="headline">{{$t("login")}}</span>
        </v-card-title>
        <v-card-text>
          <v-container>
            <v-row>
              <v-col cols="12">
                <v-text-field
                  append-icon="person"
                  name="login"
                  label="Login*"
                  persistent-hint
                  required
                  type="text"
                    v-model="userEmail"
                    :error="error"
                ></v-text-field>
              </v-col>
              <v-col cols="12">
                <v-text-field
                :type="hidePassword ? 'password' : 'text'"
                :append-icon="hidePassword ? 'visibility_off' : 'visibility'"
                name="password"
                  label="Parol*"
                  required
                    v-model="password"
                    :error="error"
                    @click:append="hidePassword = !hidePassword"
                    id="password"
                ></v-text-field>
              </v-col>
            </v-row>
          </v-container>
        </v-card-text>
        <v-card-actions>
          <v-spacer></v-spacer>
          <v-btn
            
            text
            block color="#1a8cff" @click="login" :loading="loading"
          >
            {{$t("login")}}
          </v-btn>
          
        </v-card-actions>
      </v-card>
      <v-snackbar
        v-model="showResult"
        :timeout="2000"
        top>
        {{ result }}
      </v-snackbar>
    </v-dialog>
</template>
<script>
export default {
    data: () => ({
    dialog: false,
// login va parol
      loading: false,
      userEmail: 'aaaa',
      password: '123456',
      hidePassword: true,
      error: false,
      showResult: false,
      result: '',
      rules: {
        required: value => !!value || 'Required.'
      },

      items: [
        {
          icon: 'exit_to_app',   
          title: 'Login',
          route: "/login"
        },
      ],
 }),
    methods: {
      //login method
    login() {
      if (!this.userEmail || !this.password) {
        this.result = "Email yoki parol bosh holatda bo'lishi mumkin emas!";
        this.showResult = true;
        return;
      }
      if (this.userEmail == "aaaa" && this.password == "123456") {
        this.$router.push({ name: 'dashboard' });
      }
      else {
        this.error = true;
        this.result = "Login yoki parol noto'g'ri kiritilgan!";
        this.showResult = true;
      }
    }
  }
}
</script>
<style scoped>
.border {
  border-left: 4px solid #0ba518;
}
</style>
