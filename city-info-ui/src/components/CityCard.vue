<template>
    <div class="card" :class="isSelected ? 'selected' : ''" @click="$emit('city-selected', cityName)">
        <img :src="getImgUrl(imagePath)" alt="CityImage" >
        <div class="city-name-title">
            {{cityName}}
        </div>
    </div>
</template>

<script>

export default {
  name: 'CityCard',
  components: {
  },
  props:{
    cityName: String,
    imagePath:String,
    isSelected:{
            type: Boolean,
            default: false
        }
  },
  methods:{

     getImgUrl(city) {
      var images = require.context('../assets/', false, /\.jpg$/)
      return images('./' + city.toLowerCase() + ".jpg")
     }
  }
}
</script>

<style scoped>
.card {
  box-shadow: 0 4px 8px 0 rgba(0,0,0,0.2);
  border-radius: 5px; 
  margin:0px 20px;
  min-width: 100px;
  min-height: 100px;
  max-width: 300px;
  max-height: 300px;
  width: 90%;
  height: 90%;
  position: relative;
}

.selected{
  border-style: solid;
  border-color: rgb(129, 245, 154);
}
img {
  border-radius: 5px 5px 0 0;
  width: 90%;
  height: 70%;

  padding: 10px;
  margin-bottom: 15px;
}
.city-name-title{
    position: absolute;
    bottom: 10px;
    width: 100%;
}

.card:hover {
  box-shadow: 0 8px 16px 0 rgba(0,0,0,0.2);
}

.container {
  padding: 2px 16px;
}
</style>