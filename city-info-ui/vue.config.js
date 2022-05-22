const { defineConfig } = require('@vue/cli-service')
module.exports = defineConfig({
  transpileDependencies: true,
  devServer: {
    proxy: {
        '^/api': {
            target: 'https://localhost:44362/api',
            changeOrigin: true,
            pathRewrite: { '^/api': '/' },
          },
    },
  },
})