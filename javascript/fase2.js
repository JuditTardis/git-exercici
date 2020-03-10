const year = 1948;
var traspaso = 4;
console.log ("Introduzce tu año de nacimiento");
var nacimiento = parseInt(prompt("Introduzce tu año de nacimiento"));
var resultado = ((nacimiento - year) / traspaso);
console.log("Desde el año " + year + " hasta el año " + nacimiento + " ha habido " + resultado + " años de traspaso.");
document.write("Desde el año " + year + " hasta el año " + nacimiento + " ha habido " + resultado + " años de traspaso.");