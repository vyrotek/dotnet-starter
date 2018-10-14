<template>
    <div class="home">
        <div style="padding:20px;">
            <Messsage msg="Welcome to the Vue Starter!"></Messsage>
        </div>
    </div>
</template>

<script lang="ts">
    import { Component, Vue } from 'vue-property-decorator';
    import Messsage from '@/components/Message.vue'; // @ is an alias to /src

    @Component({
      components: {
          Messsage,
      },
    })
    export default class Home extends Vue {}
</script>
