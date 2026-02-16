<template>
  <footer class="w-full border-t border-foreground/20 mt-8">
    <nav class="flex flex-wrap items-center justify-center gap-4 sm:gap-8 px-4 py-6">
      <a href="https://www.facebook.com/mandagsklubbenafterwork" target="_blank" rel="noopener">
        Facebook
      </a>
      <a href="https://discord.gg/4VwCann" target="_blank" rel="noopener">
        Discord
      </a>
      <a href="https://www.twitch.tv/mandagsklubben" target="_blank" rel="noopener">
        Twitch
      </a>
      <a href="https://mondagsklubben.myspreadshop.se/" target="_blank" rel="noopener">
        Merch
      </a>
    </nav>
    <p class="text-center text-xs opacity-50 pb-4">
      <a href="http://www.flowersfx.com" target="_blank" rel="noopener">
        FlowersFX
      </a>
    </p>
  </footer>
</template>

<script>
export default {
  name: "FooterSection",
};
</script>

<style scoped>
a {
  color: #fffc00;
  text-decoration: none;
}
a:hover {
  text-decoration: underline;
}
</style>
