<template>
  <main class="m-5">

    <div class="flex flex-wrap">

      <section class="m-5 flex-auto max-width-720">
        <img src="/images/cover-venue.jpg" />
      </section>

      <section class="m-5 flex-1 max-width-720 min-width-320">
        <h1>
          Afterwork | Activities | Geeks
        </h1>
        <p class="text-2xl">
          Welcome to Måndagsklubben - a friendly afterwork community on that dreadful of weekdays: <em>Monday</em>
        </p>
        <p>
          Our events are self-organized and free to attend and takes place inside the Wokhouse bar in Stockholm, Sweden, on <em>every</em> Monday evening.
        </p>
        <p>
          Måndagsklubben was started by the programmers Iona Rosin and Oskar Duveborn back in 2011. They wanted a place to hang out after work
          on Mondays where both introverts and extroverts could feel both welcome and engaged.
        </p>
        <p>
          You'll feel just as home sitting in a corner hacking away on your latest project with a coffee or a beverage from the bar as 
          when you're participating in the latest big screen or table activity with your friends, coworkers, strangers or competitors.
        </p>
        <p>
          People usually arrive between 17:00 and 19:00 and the crowd varies from week to week.
          </p>
      </section>  

    </div>
    
    <div class="flex flex-wrap">

      <!-- <section class="m-5 flex-1 min-width-320 max-width-720">
          <h2 class="absolute bg-background p-2">
            in 4 days
          </h2>
          <img src="https://scontent.xx.fbcdn.net/v/t1.0-9/s720x720/49250812_2167677083495988_6871804969016623104_o.jpg?_nc_cat=102&_nc_ht=scontent.xx&oh=1b9d88a280bc5b6fb8c8fc46aa420fa0&oe=5CCCC097" />
          <h1>VR-klubben</h1>
          <p class="text-lg">
            Fredrik brings his Pimax and Vive Pro headsets to Wokhouse for all of us to try out! There may be even more VR experiences so stay tuned!
          </p>
          <p class="text-sm p-0">
            Monday 14th January 2019, 19:00-23:00
          </p>
          <p class="text-sm p-0">
            Wokhouse, Regeringsgatan 26
          </p>
        </section> -->

      <EventSection v-for="event in events" v-bind:key="event.id" :event="event" />

    </div>

    <div class="w-full text-center">
      FlowersFX © 2011-2019 - info@flowersfx.com
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
      .get('https://mandagsklubben.blob.core.windows.net/mandagsklubben-events/events.json')
      .then(response => (this.events = response.data.events))
  }
}
</script>

<style scoped>
.min-width-320 {
  min-width: 320px;
}
.max-width-720 {
  max-width: 720px;
}
</style>
