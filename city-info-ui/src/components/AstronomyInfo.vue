<template>
   <div>
        <div v-if="astronomyData">
            <div class="info-content">
                <div class="info-row">
                    <div class="info-row-label">Moon Phase</div>
                    <div class="info-row-value">{{astronomyData.moonPhase}}</div>
                </div>
                <div class="info-row">
                    <div class="info-row-label">Moon Rise</div>
                    <div class="info-row-value">{{astronomyData.moonRise}}</div>
                </div>
                <div class="info-row">
                    <div class="info-row-label">Moon Set</div>
                    <div class="info-row-value">{{astronomyData.moonSet}}</div>
                </div>
                <div class="info-row">
                    <div class="info-row-label">Sun Rise</div>
                    <div class="info-row-value">{{astronomyData.sunRise}}</div>
                </div>
                <div class="info-row">
                    <div class="info-row-label">Sun Set</div>
                    <div class="info-row-value">{{astronomyData.sunSet}}</div>
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
  name: 'AstronomyInfo',
  components: {

  },
  props:{
    astronomyData: Object
  }
}
</script>

<style scoped>



</style>