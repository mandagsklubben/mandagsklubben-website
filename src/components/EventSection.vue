<template>
  <section class="m-10 flex-1 min-width-320">
      <h2 class="absolute bg-background p-2">
        {{ event.starttime | moment("from") }}
      </h2>
      <img :src="event.coverurl ? event.coverurl : '/images/cover.jpg'" />
      <h1>{{ event.name }}</h1>
      <p class="text-lg">
        {{ event.description }}
      </p>
      <p>
        {{ event.starttime | moment("dddd Do MMMM YYYY") }},
        {{ event.starttime | moment("HH:mm") }}-{{ event.endtime | moment("HH:mm") }}
      </p>
      <p>
        {{ event.placename }}, {{ event.placestreet }}
      </p>
    </section>
</template>

<script>
export default {
  name: 'EventSection',
  props: ['event']
}
</script>

<style scoped>
.min-width-320 {
  min-width: 320px;
}
</style>