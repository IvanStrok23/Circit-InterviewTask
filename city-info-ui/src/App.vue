<template>
  <HomePage />
</template>

<script>
import HomePage from './HomePage.vue'

export default {
  name: 'App',
  components: {
    HomePage
  }
}
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}

.info-content{
    display: inline-grid;   
    margin-top: 20px;
}

.info-row{
        align-items: center;
        margin: 10px 5px;
}

.info-row-label{
        font-size: 18px;
        font-weight: bold;
        margin-right: 5px;
        
}

.info-row-value{
         font-size: 16px;
}

.loading-text{
    margin-top: 40%;
    font-size: 28px;
    font-weight: bold;
    color: rgb(143, 143, 143);
}
</style>
