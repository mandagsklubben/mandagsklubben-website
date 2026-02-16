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
  src: url("@/assets/fonts/Snowstorm.otf");
}

@font-face {
  font-family: "Snowstorm Light";
  src: url("@/assets/fonts/Snowstorm Light.otf");
}

*,
*::before,
*::after {
  box-sizing: border-box;
  margin: 0;
  padding: 0;
}

body {
  font-family: "Snowstorm Light", sans-serif;
  color: #fffc00;
  background-color: #0b0b0b;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
}

h1, h2 {
  font-family: "Snowstorm", sans-serif;
}

img {
  display: block;
  max-width: 100%;
}
</style>
