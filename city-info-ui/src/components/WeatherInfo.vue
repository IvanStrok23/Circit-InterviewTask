<template>
    <div>
        <div v-if="weatherData">
            <div class="info-row">
                    <img :src="weatherData.weatherIcon" alt="">
                </div>
            <div class="info-content">        
                <div class="info-row">
                    <div class="info-row-label">Weather</div>
                    <div class="info-row-value">{{weatherData.weatherText}}</div>
                </div>
                <div class="info-row">
                    <div class="info-row-label">Feels Like</div>
                    <div class="info-row-value">{{weatherData.feelsLike}} &#8451;</div>
                </div>
                <div class="info-row">
                    <div class="info-row-label">Updated At</div>
                    <div class="info-row-value">{{weatherData.updatedAt}}</div>
                </div>
            </div>
        </div>
        <div v-else class="loading-text">
            Loading...
        </div>
    </div>
</template>

<script>

export default {
  name: 'WeatherInfo',
  components: {

  },
  props:{
    weatherData: Object
  }
}
</script>

<style scoped>



</style>