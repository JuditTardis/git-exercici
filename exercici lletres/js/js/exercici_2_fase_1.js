function nom(){
    var name = document.getElementById("text").value;
    var desglossat_name = Array.from(name);
    for (let i  = 0; i<desglossat_name.length; i++){
        document.getElementById("resultat").innerHTML += desglossat_name[i] + "<br>";
    }
}