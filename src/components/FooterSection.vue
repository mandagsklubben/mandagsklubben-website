<template>
    <div class="w-full text-center flex flex-col">

      <section class="flex-auto m-2">
        <a href="https://www.facebook.com/pg/mandagsklubben.net" target="blank">
          <img src="/images/facebook.svg" height="12" width="12"> Like our Facebook Page to get notified of upcoming events
        </a>
      </section>
      
      <section class="flex-auto m-2">
        <a href="http://www.flowersfx.com" target="blank">
          FlowersFX © 2011-2019 ★ info@flowersfx.com
        </a>
      </section>

    </div>
</template>

<script>
export default {
  name: 'FooterSection'
}
</script>

<style scoped>
.min-width-320 {
  min-width: 320px;
}
.max-width-720 {
  max-width: 720px;
}
a {
  color: #FFFC00;
  background-color: #0b0b0b;
  text-decoration: none;
}
a:hover {
  text-decoration: underline;
}
</style>