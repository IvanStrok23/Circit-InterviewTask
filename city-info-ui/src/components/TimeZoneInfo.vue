<template>
    <div>
        <div v-if="timeZoneData">
            <br/><br/>
            <div class="info-content">
                <div class="info-row">
                    <div class="info-row-label">Name</div>
                    <div class="info-row-value">{{timeZoneData.name}}</div>
                </div>
                <div class="info-row">
                    <div class="info-row-label">Region</div>
                    <div class="info-row-value">{{timeZoneData.region}}</div>
                </div>
                <div class="info-row">
                    <div class="info-row-label">Country</div>
                    <div class="info-row-value">{{timeZoneData.country}}</div>
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
  name: 'TimeZoneInfo',
  components: {

  },
  props:{
    timeZoneData: Object
  }
}
</script>

<style scoped>



</style>