<template>
<div>
  <h1>City Info</h1>
      <div   class="city-cards-row">
        <div :key="city" v-for="city in cities">
          <CityCard :cityName="city" :imagePath="city" :isSelected="city == selectedCityName" @city-selected="selectCity"/>
        </div>
      </div>
      <div class="city-info-container">
        <CityInfoLayout :timeZoneData="timeZoneData" :weatherData="weatherData" :astronomyData="astronomyData"/>
      </div>
    </div>
</template>

<script>
import CityCard from './components/CityCard.vue'
import CityInfoLayout from './components/CityInfoLayout.vue'

export default {
  name: 'HomePage',
  components: {
      CityCard,
      CityInfoLayout
  },
  data(){
    return{
      cities: [],
      selectedCityName: '',
      timeZoneData: {},
      weatherData:{},
      astronomyData: {}
      }
  },

    async created() {
      this.cities = ["Osijek","Tokyo","Los Angeles"];
      this.selectedCityName = this.cities[0];
      this.getNewCityData(this.selectedCityName)
    },

  methods:{
   

    selectCity(cityName){
      this.selectedCityName = cityName;
      this.getNewCityData(cityName);
    },

    async getNewCityData(cityName)
    {      
      this.weatherData = null;
      this.timeZoneData = null;
      this.astronomyData = null;

      this.getTimeZone(cityName)
      this.getWeather(cityName)
      this.getAstronomy(cityName)
    },

    async getTimeZone(cityName){
      const res = await fetch(`api/home/getTimeZone?cityName=${cityName}`)
      if(res.status == 200){
        const data = await res.json();
        this.timeZoneData = data;
      }else{
        //TODO: show no content
      }
    },
    async getWeather(cityName){
      const res = await fetch(`api/home/getWeather?cityName=${cityName}`)
      if(res.status == 200){
        const data = await res.json();
        this.weatherData = data;
      }else{
        //TODO: show no content
      }
    },
    async getAstronomy(cityName){
      const res = await fetch(`api/home/getAstronomy?cityName=${cityName}`)
      if(res.status == 200){
        const data = await res.json();
        this.astronomyData = data;
      }else{
        //TODO: show no content
      }  
    }
  }
}
</script>

<style>

.city-cards-row{
  display:flex;
  justify-content:center;
  margin-top:50px;
}

div.city-info-container{
  display: flex;
  justify-content:center;
  margin-top:50px;
}
</style>