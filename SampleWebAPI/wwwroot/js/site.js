// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

fetch('/api/product/1')
  .then(response => response.json())
  .then(data => {
    let product = JSON.stringify(data);
    var li = document.createElement("li");
    li.innerHTML = product;
    document.getElementById("products").appendChild(li);
  });
fetch('/api/product/2')
  .then(response => response.json())
  .then(data => {
    let product = JSON.stringify(data);
    var li = document.createElement("li");
    li.innerHTML = product;
    document.getElementById("products").appendChild(li);
  })
fetch('/api/product/3')
  .then(response => response.json())
  .then(data => {
    let product = JSON.stringify(data);
    var li = document.createElement("li");
    li.innerHTML = product;
    document.getElementById("products").appendChild(li);
  });
fetch('/api/product/4')
  .then(response => response.json())
  .then(data => {
    let product = JSON.stringify(data);
    var li = document.createElement("li");
    li.innerHTML = product;
    document.getElementById("products").appendChild(li);
  });
fetch('/api/product/5')
  .then(response => response.json())
  .then(data => {
    let product = JSON.stringify(data);
    var li = document.createElement("li");
    li.innerHTML = product;
    document.getElementById("products").appendChild(li);
  });
