<template>
  <HomePage id="app" />
</template>

<script>
import HomePage from './components/HomePage.vue'

export default {
  name: 'app',
  components: {
    HomePage
  }
}
</script>

<style>
@font-face {
       font-family: "Snowstorm";
       src: url("/fonts/snowstorm.otf");
}

body {
  font-family: "Snowstorm", sans-serif;
  color: #fffc00;
  background-color: #0b0b0b;
}
</style>
