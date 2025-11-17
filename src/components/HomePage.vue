<template>
  <main class="my-4 mx-auto flex flex-wrap max-width-1080 justify-center">
    <EventSection
      v-for="event in events"
      v-bind:key="event.id"
      :event="event"
      :now="now"
    />
    <AboutSection />
    <BannerSection />
    <FooterSection />
  </main>
</template>

<script>
import EventSection from "./EventSection.vue";
import AboutSection from "./AboutSection.vue";
import BannerSection from "./BannerSection.vue";
import FooterSection from "./FooterSection.vue";

export default {
  name: "HomePage",
  components: {
    EventSection,
    AboutSection,
    BannerSection,
    FooterSection,
  },
  data() {
    return {
      events: [],
      now: new Date(),
    };
  },
  mounted() {
    this.axios
      .get(
        "https://mandagsklubben.blob.core.windows.net/mandagsklubben-events/events.json"
      )
      .then((response) => (this.events = response.data.events));
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
</style>
