<template>
  <div class="users">
    
    <v-list>
        <template v-for="(user) in users">                    
            <v-list-tile :key="user.title" avatar>
                <v-list-tile-avatar>
                <img :src="'http://i.pravatar.cc/50?u=' + user.id">
                </v-list-tile-avatar>
                <v-list-tile-content>
                <v-list-tile-title v-html="user.name"></v-list-tile-title>
                <v-list-tile-sub-title v-html="user.email"></v-list-tile-sub-title>
                </v-list-tile-content>
            </v-list-tile>
        </template>
    </v-list>
      
  </div>
</template>

<script>
    import UserService from '@/services/user-service';
    export default {
        data() {
            return {
                users: []
            };
        },
        methods: {
            async getUsers() {
                let svc = new UserService();
                let users = await svc.getUsers();
                this.users = users;
            }
        },
        mounted() {
            this.getUsers();
        }
    };
</script>