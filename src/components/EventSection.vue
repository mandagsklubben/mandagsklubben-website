<template>
  <section class="m-5 flex-1 min-width-320 max-width-720">
    <h2 class="absolute bg-background p-2 underline pointer">
      <a :href="'https://www.facebook.com/events/' + event.id" target="blank">
        {{ eventfriendlytime() }}
        ★ Facebook Event</a
      >
    </h2>
    <img :src="event.coverurl ? event.coverurl : '/images/cover.jpg'" />
    <h1>{{ event.name }}</h1>
    <p class="text-lg">
      {{ event.description }}
    </p>
    <p class="text-sm p-0">
      {{ event.starttime | moment("dddd Do MMMM YYYY") }},
      {{ event.starttime | moment("HH:mm") }}-{{
        event.endtime | moment("HH:mm")
      }}
    </p>
    <p class="text-sm p-0">{{ event.placename }}, {{ event.placestreet }}</p>
  </section>
</template>

<script>
import moment from "moment";

export default {
  name: "EventSection",
  props: ["event", "now"],
  methods: {
    eventfriendlytime: function () {
      if (
        moment(this.now).isBetween(this.event.starttime, this.event.endtime)
      ) {
        return "in progress";
      } else {
        return moment(this.event.starttime).fromNow();
      }
    },
  },
};
</script>

<style scoped>
.min-width-320 {
  min-width: 320px;
}
.max-width-720 {
  max-width: 720px;
}
a {
  color: #fffc00;
  background-color: #0b0b0b;
  text-decoration: none;
}
a:hover {
  text-decoration: underline;
}
</style>