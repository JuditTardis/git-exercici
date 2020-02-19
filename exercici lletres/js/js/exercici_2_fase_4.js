function nom(){
    var name = document.getElementById("text1").value;
    var desglossat_name = Array.from(name);
    var surname = document.getElementById("text2").value;
    var desglossat_surname = Array.from(surname);
    var full_Name = [];
    full_Name = desglossat_name + " " + desglossat_surname;
    for (let i  = 0; i<full_Name.length; i++){
        document.getElementById("resultat").innerHTML += full_Name[i] + "<br>";
    }
}