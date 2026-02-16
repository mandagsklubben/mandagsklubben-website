<template>
  <article class="border border-foreground/20 rounded-lg overflow-hidden mb-6">
    <img
      :src="event.coverurl ? event.coverurl : '/images/cover.jpg'"
      :alt="event.name"
      class="w-full h-48 sm:h-56 object-cover"
    />
    <div class="p-4 sm:p-6">
      <div class="flex items-center justify-between mb-2">
        <span class="text-sm opacity-70">{{ eventfriendlytime() }}</span>
        <a
          :href="'https://www.facebook.com/events/' + event.id"
          target="_blank"
          rel="noopener"
          class="text-sm underline hover:opacity-80"
        >
          Facebook Event
        </a>
      </div>
      <h2 class="text-xl sm:text-2xl mb-3">{{ event.name }}</h2>
      <p class="text-base whitespace-pre-line leading-relaxed mb-4">
        {{ event.description }}
      </p>
      <div class="text-sm opacity-70 space-y-1">
        <p>
          {{ formatDate(event.starttime) }},
          {{ formatTime(event.starttime) }}&ndash;{{ formatTime(event.endtime) }}
        </p>
        <p>{{ event.placename }}, {{ event.placestreet }}</p>
      </div>
    </div>
  </article>
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
    formatDate: function (date) {
      return moment(date).format("dddd Do MMMM YYYY");
    },
    formatTime: function (date) {
      return moment(date).format("HH:mm");
    },
  },
};
</script>

<style scoped>
a {
  color: #fffc00;
}
</style>
