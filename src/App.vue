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

@font-face {
       font-family: "Snowstorm Light";
       src: url("/fonts/snowstorm light.otf");
}

body {
  font-family: "Snowstorm Light", sans-serif;
  color: #fffc00;
  background-color: #0b0b0b;
}

h1 {
  font-family: "Snowstorm", sans-serif;
  padding-bottom: 0.1em;
}

h2 {
  font-family: "Snowstorm", sans-serif;
  padding-bottom: 0.1em;
}

p {
  font-size: larger;
  padding-bottom: 0.8em;
}
</style>
