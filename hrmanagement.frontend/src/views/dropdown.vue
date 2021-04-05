<!--<template >
<v-container >
  <v-card  class="mx-auto  " 
  >
    <v-row justify-right>
    <v-col md="3">
      <v-card-title>
      <v-text-field
        v-model="search"
        append-icon="mdi-magnify"
        label="Search"
        single-line
        hide-details
      ></v-text-field>
    </v-card-title>
    </v-col>
  </v-row>
  <v-row no-gutters justify-center>
    <v-col md="12">
      <div class="ml-5 mr-5 mt-7">
  <v-hover>
      <template v-slot:default="{ hover }">
<v-card
:elevation="hover ? 12 : 3"
    class="mx-auto"
    color="#f5f5f0"
  >
  <v-row>
<v-col cols="12"
  md="5">
<v-list-item>
    <v-list-item-avatar height="70" width="70">
    <v-img 
    class="subheading pt-4"
      src="img3.jpg"
      height="70"
    >
    </v-img>
      </v-list-item-avatar>
      <v-list-item-content>
        <v-list-item-title class="headline">Aziz Bohidjonov Alisher ugli</v-list-item-title>
        <v-list-item-subtitle>1-toifali mutaxasis</v-list-item-subtitle>
      </v-list-item-content>
    </v-list-item>
  </v-col>
    <v-col cols="12"
  md="1">
  </v-col>
  <v-col cols="12"
  md="2">
<v-list-item>
      <v-list-item-content>
        <v-list-item-title class="headline">Vnutrenniy</v-list-item-title>
        <v-list-item-subtitle>+998935386448</v-list-item-subtitle>
      </v-list-item-content>
    </v-list-item>
  </v-col>
    <v-col cols="12"
  md="2">
<v-list-item>
      <v-list-item-content>
        <v-list-item-title class="headline">Gorodskoy</v-list-item-title>
        <v-list-item-subtitle>+998935386448</v-list-item-subtitle>
      </v-list-item-content>
    </v-list-item>
  </v-col>
    <v-col cols="12"
  md="2">
<v-list-item>
      <v-list-item-content>
        <v-list-item-title class="headline">Mobil</v-list-item-title>
        <v-list-item-subtitle>+998935386448</v-list-item-subtitle>
      </v-list-item-content>
    </v-list-item>
  </v-col>
  </v-row>
  </v-card>
        </template>
    </v-hover>
</div>
    </v-col>
  </v-row>
  </v-card>
</v-container>
-->




  <!--<v-card
    class="mx-auto"
    
  >
    <v-toolbar
      color="red"
      dark
    >
      <v-app-bar-nav-icon></v-app-bar-nav-icon>

      <v-toolbar-title>Topics</v-toolbar-title>

      <v-spacer></v-spacer>

      <v-btn icon>
        <v-icon>mdi-dots-vertical</v-icon>
      </v-btn>
    </v-toolbar>

    <v-list>
      <v-list-group
        v-for="item in items"
        :key="item.title"
        v-model="item.active"
        :prepend-icon="item.action"
        no-action
      >
        <template v-slot:activator>
          <v-list-item-content>
            <v-list-item-title v-text="item.title"></v-list-item-title>
          </v-list-item-content>
        </template>

        <v-list-item
          v-for="child in item.items"
          :key="child.title"
        >
          <v-list-item-content>
            <v-list-item-title v-text="child.title"></v-list-item-title>
          </v-list-item-content>
        </v-list-item>
      </v-list-group>
    </v-list>
  </v-card>-->


<!--
</template>
<script>
  export default {
    data () {
      return {
        search: '',
        headers: [
          {
            text: 'Dessert (100g serving)',
            align: 'start',
            filterable: false,
            value: 'name',
          },
          { text: 'Calories', value: 'calories' },
          { text: 'Fat (g)', value: 'fat' },
          { text: 'Carbs (g)', value: 'carbs' },
          { text: 'Protein (g)', value: 'protein' },
          { text: 'Iron (%)', value: 'iron' },
        ],
        desserts: [
          {
            name: 'Frozen Yogurt',
            calories: 159,
            fat: 6.0,
            carbs: 24,
            protein: 4.0,
            iron: '1%',
          },
          {
            name: 'Ice cream sandwich',
            calories: 237,
            fat: 9.0,
            carbs: 37,
            protein: 4.3,
            iron: '1%',
          },
          {
            name: 'Eclair',
            calories: 262,
            fat: 16.0,
            carbs: 23,
            protein: 6.0,
            iron: '7%',
          },
          {
            name: 'Cupcake',
            calories: 305,
            fat: 3.7,
            carbs: 67,
            protein: 4.3,
            iron: '8%',
          },
          {
            name: 'Gingerbread',
            calories: 356,
            fat: 16.0,
            carbs: 49,
            protein: 3.9,
            iron: '16%',
          },
          {
            name: 'Jelly bean',
            calories: 375,
            fat: 0.0,
            carbs: 94,
            protein: 0.0,
            iron: '0%',
          },
          {
            name: 'Lollipop',
            calories: 392,
            fat: 0.2,
            carbs: 98,
            protein: 0,
            iron: '2%',
          },
          {
            name: 'Honeycomb',
            calories: 408,
            fat: 3.2,
            carbs: 87,
            protein: 6.5,
            iron: '45%',
          },
          {
            name: 'Donut',
            calories: 452,
            fat: 25.0,
            carbs: 51,
            protein: 4.9,
            iron: '22%',
          },
          {
            name: 'KitKat',
            calories: 518,
            fat: 26.0,
            carbs: 65,
            protein: 7,
            iron: '6%',
          },
        ],
      }
    },
  }
</script>
-->

<!--list contact -->



<!--
<template>
  <v-card>
    <v-card-title class="secondary white--text headline">
      User Directory
    </v-card-title>
    <v-layout
      justify-space-between
      pa-3>
      <v-flex xs5>
        <v-treeview
          :active.sync="active"
          :items="items"
          :load-children="fetchUsers"
          :open.sync="open"
          activatable
          active-class="primary--text"
          class="grey lighten-5"
          open-on-click
          transition>
          <v-icon
            v-if="!item.children"
            slot="prepend"
            slot-scope="{ item, active }"
            :color="active ? 'primary' : ''"
          >mdi-account</v-icon>
        </v-treeview>
      </v-flex>
      <v-flex
        d-flex
        text-xs-center>
        <v-scroll-y-transition mode="out-in">
          <div
            v-if="!selected"
            class="title grey--text text--lighten-1 font-weight-light"
            style="align-self: center;">
            Select a User
          </div>
          <v-card
            v-else
            :key="selected.id"
            class="pt-4 mx-auto"
            flat
            max-width="400">
            <v-card-text>
              <v-avatar
                v-if="avatar"
                size="88">
                <v-img
                  :src="`https://avataaars.io/${avatar}`"
                  class="mb-4"
                ></v-img>
              </v-avatar>
              <h3 class="headline mb-2">
                {{ selected.name }}
              </h3>
              <div class="blue--text mb-2">{{ selected.email }}</div>
              <div class="blue--text subheading font-weight-bold">{{ selected.username }}</div>
            </v-card-text>
            <v-divider></v-divider>
            <v-layout
              tag="v-card-text"
              text-xs-left
              wrap>
              <v-flex tag="strong" xs5 text-xs-right mr-3 mb-2>Company:</v-flex>
              <v-flex>{{ selected.company.name }}</v-flex>
              <v-flex tag="strong" xs5 text-xs-right mr-3 mb-2>Website:</v-flex>
              <v-flex>
                <a :href="`//${selected.website}`" target="_blank">{{ selected.website }}</a>
              </v-flex>
              <v-flex tag="strong" xs5 text-xs-right mr-3 mb-2>Phone:</v-flex>
              <v-flex>{{ selected.phone }}</v-flex>
            </v-layout>
          </v-card>
        </v-scroll-y-transition>
      </v-flex>
    </v-layout>
  </v-card>
</template>

<script>
  const avatars = [
    '?accessoriesType=Blank&avatarStyle=Circle&clotheColor=PastelGreen&clotheType=ShirtScoopNeck&eyeType=Wink&eyebrowType=UnibrowNatural&facialHairColor=Black&facialHairType=MoustacheMagnum&hairColor=Platinum&mouthType=Concerned&skinColor=Tanned&topType=Turban',
    '?accessoriesType=Sunglasses&avatarStyle=Circle&clotheColor=Gray02&clotheType=ShirtScoopNeck&eyeType=EyeRoll&eyebrowType=RaisedExcited&facialHairColor=Red&facialHairType=BeardMagestic&hairColor=Red&hatColor=White&mouthType=Twinkle&skinColor=DarkBrown&topType=LongHairBun',
    '?accessoriesType=Prescription02&avatarStyle=Circle&clotheColor=Black&clotheType=ShirtVNeck&eyeType=Surprised&eyebrowType=Angry&facialHairColor=Blonde&facialHairType=Blank&hairColor=Blonde&hatColor=PastelOrange&mouthType=Smile&skinColor=Black&topType=LongHairNotTooLong',
    '?accessoriesType=Round&avatarStyle=Circle&clotheColor=PastelOrange&clotheType=Overall&eyeType=Close&eyebrowType=AngryNatural&facialHairColor=Blonde&facialHairType=Blank&graphicType=Pizza&hairColor=Black&hatColor=PastelBlue&mouthType=Serious&skinColor=Light&topType=LongHairBigHair',
    '?accessoriesType=Kurt&avatarStyle=Circle&clotheColor=Gray01&clotheType=BlazerShirt&eyeType=Surprised&eyebrowType=Default&facialHairColor=Red&facialHairType=Blank&graphicType=Selena&hairColor=Red&hatColor=Blue02&mouthType=Twinkle&skinColor=Pale&topType=LongHairCurly'
  ]


  export default {
    data: () => ({
      active: [],
      avatar: null,
      open: [],
      users: []
    }),

    computed: {
      items () {
        return [
          {
            name: 'Users',
            children: this.users
          }
        ]
      },
      selected () {
        if (!this.active.length) return undefined

        const id = this.active[0]

        return this.users.find(user => user.id === id)
      }
    },

    watch: {
      selected: 'randomAvatar'
    },

    methods: {
      fetchUsers (item) {

        return fetch('https://jsonplaceholder.typicode.com/users')
          .then(res => res.json())
          .then(json => (item.children.push(...json)))
          .catch(err => console.warn(err))
      },
      randomAvatar () {
        this.avatar = avatars[Math.floor(Math.random() * avatars.length)]
      }
    }
  }
</script>

<style>

</style>
-->



<template>
    <div id="app">
    <div class="container">
      <div id="printMe" class="row">
        <div class="col-xs-12 col-md-10 offset-md-1 pt-5">
          <h3 align="center">МАЪЛУМОТНОМА</h3>
          <h3 class="mt-7" align="center">Эшматов Ботир Баҳодирович</h3>
            <div style="border: 1px solid black" class="table-responsive">
              <v-simple-table>
                  <template v-slot:default>
                    <thead class="table">
                      <tr >
                        <th  style="border: 1px solid black; font-size: 10px;">
                          Қариндош-лиги
                        </th>
                        <th class="text-left" style="border: 1px solid black; font-size: 10px;">
                          Фамилияси, исми ва отасининг исми 
                        </th>
                        <th class="text-left" style="border: 1px solid black; font-size: 10px;">
                          Туғилган йили ва жойи
                        </th>
                        <th class="text-left" style="border: 1px solid black; font-size: 10px;">
                          Иш жойи ва лавозими
                        </th>
                        <th class="text-left" style="border: 1px solid black; font-size: 10px;">
                          Турар жойи
                        </th>
                      </tr>
                    </thead>
                    <tbody>
                      <tr
                        v-for="item in desserts"
                        :key="item.who"
                      >
                        <td style="border: 1px solid black; font-size: 10px;">{{ item.who }}</td>
                        <td  style="border: 1px solid black; font-size: 10px;">{{ item.name }}</td>
                        <td  style="border: 1px solid black; font-size: 10px;">{{ item.birth_location }}</td>
                        <td  style="border: 1px solid black; font-size: 10px;">{{ item.work_at }}</td>
                        <td  style="border: 1px solid black; font-size: 10px;">{{ item.home }}</td>
                      </tr>
                    </tbody>
                  </template>
                </v-simple-table>
            </div>
        </div>
      </div>
      <div class="row">
        <div class="col-xs-12 col-md-10 offset-md-1 mb-5">
          <button class="btn btn-outline-primary" @click="print">Export to PDF</button>
        </div>
      </div>
    </div>
  </div>
</template>
  <script>

export default {
  
        data () {
        return {

desserts: [
          {
            who: 'Отаси',
            name: 'Эшматов Баҳодир Темирович',
            birth_location: '1935 йил, Қашқадарё вилояти, Косон тумани',
            work_at: 'Пенсияда (Қарши муҳандислик-иқтисодиёт институти ўқитувчиси)',
            home: 'Қашқадарё вилояти, Косон тумани, Бинокор кўчаси, 5-уй'
          },
          {
            who: 'Онаси',
            name: 'Абдушукурова (Ҳамдамова) Раҳима ',
            birth_location: '1936 йил, Қашқадарё вилояти, Косон тумани',
            work_at: 'Пенсияда (Қарши муҳандислик-иқтисодиёт институти ўқитувчиси)',
            home: 'Тошкент шаҳри, М.Улуғбек тумани, Хумоюн мавзеси, 176-уй, 5-хонадон'
          },
          {
            who: 'Опаси',
            name: 'Соатова (Эшматова) Гулчеҳра Баҳодировна',
            birth_location: '1959 йил, Қашқадарё вилояти, Косон тумани',
            work_at: 'Пенсияда (Қарши муҳандислик-иқтисодиёт институти ўқитувчиси)',
            home: 'Қашқадарё вилояти, Косон тумани, Бинокор кўчаси, 5-уй'
          },
          {
            who: 'Укаси',
            name: 'Эшматов Тохир Баҳодирович',
            birth_location: '1972 йил, Қашқадарё вилояти, Косон тумани',
            work_at: 'Пенсияда (Қарши муҳандислик-иқтисодиёт институти ўқитувчиси)',
            home: 'Қашқадарё вилояти, Косон тумани, Бинокор кўчаси, 5-уй'
          },
          {
            who: 'Турмуш ўртоғи',
            name: 'Эшматова (Пирматова) Нозима Шарофходжаевна',
            birth_location: '1968 йил, Қашқадарё вилояти, Косон тумани',
            work_at: 'Пенсияда (Қарши муҳандислик-иқтисодиёт институти ўқитувчиси)',
            home: 'Қашқадарё вилояти, Косон тумани, Бинокор кўчаси, 5-уй'
          },
          {
            who: 'Қизи',
            name: 'Эшматова Зиёда Ботировна',
            birth_location: '1993 йил, Қашқадарё вилояти, Косон тумани',
            work_at: 'Пенсияда (Қарши муҳандислик-иқтисодиёт институти ўқитувчиси)',
            home: 'Қашқадарё вилояти, Косон тумани, Бинокор кўчаси, 5-уй'
          },
          {
            who: 'Қизи',
            name: 'Эшматова Зилола Ботир қизи',
            birth_location: '2000 йил, Қашқадарё вилояти, Косон тумани',
            work_at: 'Пенсияда (Қарши муҳандислик-иқтисодиёт институти ўқитувчиси)',
            home: 'Қашқадарё вилояти, Косон тумани, Бинокор кўчаси, 5-уй'
          },
          {
            who: 'Ўғли',
            name: 'Эшматов Мақсуд Ботир ўғли',
            birth_location: '2012 йил, Қашқадарё вилояти, Косон тумани',
            work_at: 'Пенсияда (Қарши муҳандислик-иқтисодиёт институти ўқитувчиси)',
            home: 'Қашқадарё вилояти, Косон тумани, Бинокор кўчаси, 5-уй'
          },
          {
            who: 'Қайнотаси',
            name: 'Пирматов Шарофходжа Нигматович',
            birth_location: '1939 йил, Қашқадарё вилояти, Косон тумани',
            work_at: 'Пенсияда (Қарши муҳандислик-иқтисодиёт институти ўқитувчиси)',
            home: 'Қашқадарё вилояти, Косон тумани, Бинокор кўчаси, 5-уй'
          },
          {
            who: 'Қайнонаси',
            name: 'Пирматова (Юнусбекова) Машкура Собировна',
            birth_location: '1945 йил, Қашқадарё вилояти, Косон тумани',
            work_at: 'Пенсияда (Қарши муҳандислик-иқтисодиёт институти ўқитувчиси)',
          
          },
        ],
          globalOptions: {
            name: '_blank',
            specs: [
              'fullscreen=yes',
              'titlebar=yes',
              'scrollbars=yes'
            ],
            styles: [
              'https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css',
              'https://unpkg.com/kidlat-css/css/kidlat.css',
            ]
          },
        }
      },
      methods: {
        print () {
          this.$htmlToPaper('printMe', null, () => {
            console.warn('done');
          });
        },
      }
}
</script>
<style scoped>
table, td, th {
  border: 1px solid black;
}



th {
  height: 70px;
}
.table{
  border: 1px solid black
}
</style>


