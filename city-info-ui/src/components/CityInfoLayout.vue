<template>
    <div class="main-container">
      <div class="info-card info-card-timezone">
        <TimeZoneInfo :timeZoneData="timeZoneData"/>
      </div>
      <div class="info-card info-card-weather">
        <WeatherInfo :weatherData="weatherData"/>
      </div>
      <div class="info-card info-card-astronomy">
        <AstronomyInfo :astronomyData="astronomyData"/>
      </div>
    </div>
</template>

<script>
import TimeZoneInfo from './TimeZoneInfo.vue'
import WeatherInfo from './WeatherInfo.vue'
import AstronomyInfo from './AstronomyInfo.vue'

export default {
  name: 'CityInfoLayout',
  components: {
    TimeZoneInfo,
    WeatherInfo,
    AstronomyInfo
  },
  props:{
    timeZoneData: Object,
    weatherData:Object,
    astronomyData: Object
  }
}
</script>

<style scoped>

.main-container{
  box-shadow: 0 4px 8px 0 rgba(2,0,0,0.2);
  transition: 0.3s;
  border-radius: 5px; 
  margin:0px 20px;
  
  min-width: 290px;
  min-height: 300px;
  max-width: 980px;
  max-height: 600px;
  width: 100%; 

  display:flex;
  justify-content:center;
  margin-top:50px;
  
}

.info-card{
  margin: 10px;
  width: 30%;
  border-style: solid;
  border-radius: 10px;
}

.info-card-timezone{
  background: linear-gradient(to bottom , #ffffff,#9fe7af);
}
.info-card-weather{
  background: linear-gradient(to bottom , #ffffff,#fffbb7);
}
.info-card-astronomy{
  background: linear-gradient(to bottom , #ffffff,#cccccc);
}

</style>