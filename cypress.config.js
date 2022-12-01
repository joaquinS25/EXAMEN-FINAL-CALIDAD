const { defineConfig } = require("cypress");

module.exports = defineConfig({
  env:{
    URL: 'https://localhost:7023/'
  },
  e2e: {
    experimentalSessionAndOrigin:true,
    setupNodeEvents(on, config) {
      // implement node event listeners here
    },
  },
});