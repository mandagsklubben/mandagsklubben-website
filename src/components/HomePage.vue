<template>
  <main class="m-0">

    <div class="flex flex-wrap">
      <section class="m-5 flex-1 min-width-160">
        <img src="/images/logosmall.png" />
      </section>
    
      <EventSection v-for="event in events" v-bind:key="event.id" :event="event" />
    </div>

  </main>
</template>

<script>
import EventSection from './EventSection.vue'

export default {
  name: 'HomePage',
  components: {
    EventSection
  },
  data () {
    return {
      events: [],
    }
  },
  mounted () {
    this.axios
      .get('https://mandagsklubben-functions.azurewebsites.net/api/events')
      .then(response => (this.events = response.data.events))
  }
}
</script>

<style scoped>
.min-width-160 {
  min-width: 160px;
}
</style>
