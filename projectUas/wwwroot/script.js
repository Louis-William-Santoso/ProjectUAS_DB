/*Fields*/
//const fs = require("fs");
let mapView = L.map("map").setView([-7.32011, 112.76793], 15); //set view layer default ke SBY
let popUp = L.popup(); //popup message
let marker = L.marker([-7.322745, 112.767786]).addTo(mapView);

//tambahkan tileLayer yang didalamnya terdapat api peta dari openstreetmap
L.tileLayer("https://tile.openstreetmap.org/{z}/{x}/{y}.png", {
  attribution: "Made by LouisW :v",
}).addTo(mapView);

//L.geoJSON(geojsonFeature).addTo(mapView);

//map clicks
function MapClicks(obj) {
  marker.setLatLng(obj.latlng).addTo(mapView);
  popUp
    .setLatLng(obj.latlng)
    .setContent("you clicked at" + obj.latlng)
    .openOn(mapView);

  let titikLokasi = JSON.stringify(obj);
  //fs.writeFileSync("lokasi.json", titikLokasi);
  return obj.latlng;
}
mapView.on("click", MapClicks);
