<template>
  <v-app>
    <v-navigation-drawer v-model="drawer" persistent enable-resize-watcher fixed app>

      <v-card>

        <v-list two-line>

            <!-- <v-divider></v-divider> -->

            <v-list-tile avatar>

              <v-list-tile-avatar size="45">
                <img src="http://i.pravatar.cc/50?2">
              </v-list-tile-avatar>

              <v-list-tile-content>
                <v-list-tile-title>Jason Barnes</v-list-tile-title>
                <v-list-tile-sub-title>jason@vyrotek.com</v-list-tile-sub-title>
              </v-list-tile-content>
            </v-list-tile>

        </v-list>

      </v-card>

      <v-list>

        <v-list-tile key="home" to="/">
          <v-list-tile-action>
            <v-icon>home</v-icon>
          </v-list-tile-action>
          <v-list-tile-content>
            <v-list-tile-title>Home</v-list-tile-title>
          </v-list-tile-content>
        </v-list-tile>

        <v-list-tile key="users" to="/users">
          <v-list-tile-action>
              <v-icon>people</v-icon>
          </v-list-tile-action>
          <v-list-tile-content>
            <v-list-tile-title>Users</v-list-tile-title>
          </v-list-tile-content>
        </v-list-tile>                

      </v-list>
    </v-navigation-drawer>

    <v-toolbar app dark color="primary">
      <v-toolbar-side-icon @click.stop="drawer = !drawer"></v-toolbar-side-icon>
      <v-toolbar-title >Starter</v-toolbar-title>
      <!-- <v-spacer></v-spacer> -->
      <v-toolbar-items class="hidden-sm-and-down">
        <v-btn flat>
          <v-icon>home</v-icon>&nbsp;Home
        </v-btn>
        <v-btn flat>
          <v-icon>people</v-icon>&nbsp;Users
        </v-btn>
      </v-toolbar-items>
      <v-spacer></v-spacer>
      <v-toolbar-items class="hidden-sm-and-down">
         <v-btn flat>Login</v-btn> 
      </v-toolbar-items>
    </v-toolbar>

    <v-content>
      
      <transition>
        <keep-alive>
          <router-view></router-view>
        </keep-alive>
      </transition>

    </v-content>
    <v-footer app>
      <span>&nbsp;&copy; 2018</span>
    </v-footer>

  </v-app>

</template>

<script>
    export default {
        name: 'App',
        components: {
        },
        data() {
            return {
                drawer: true
            };
        }
    };
</script>
