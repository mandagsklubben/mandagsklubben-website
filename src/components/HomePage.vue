<template>
  <div class="min-h-screen flex flex-col">
    <!-- Hero: full-width cover image with overlay -->
    <BannerSection />

    <!-- About content -->
    <AboutSection />

    <!-- Events (only if any exist) -->
    <section v-if="events.length" class="w-full max-w-2xl mx-auto px-4 py-8">
      <h2 class="text-2xl mb-6 text-center">Upcoming Events</h2>
      <EventSection
        v-for="event in events"
        v-bind:key="event.id"
        :event="event"
        :now="now"
      />
    </section>

    <!-- Spacer to push footer down -->
    <div class="flex-grow"></div>

    <!-- Footer links -->
    <FooterSection />
  </div>
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
      .then((response) => (this.events = response.data.events))
      .catch(() => {});
  },
};
</script>
