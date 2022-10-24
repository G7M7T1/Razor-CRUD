/** @type {import('tailwindcss').Config} */
module.exports = {
  content: [
      "./src/**/*.{html,js}",
      "./Link/Pages/*.{razor,html,cshtml,js}",
      "./Link/Pages/**/*.{razor,html,cshtml,js}",
      "./Link/Pages/Shared/*.{razor,html,cshtml,js}",
      "./Link/Pages/Categories/*.{razor,html,cshtml,js}",
      "./Link/wwwroot/js/*.{razor,html,cshtml,js}"
  ],
  theme: {
    extend: {},
  },
  plugins: [],
}