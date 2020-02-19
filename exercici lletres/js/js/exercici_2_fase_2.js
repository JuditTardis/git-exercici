function nom(){
    var name = document.getElementById("text").value;
    var desglossat_name = Array.from(name);
    for (let i  = 0; i<desglossat_name.length; i++){
        if ((desglossat_name[i]=='a')||(desglossat_name[i]=='e')||(desglossat_name[i]=='i')||(desglossat_name[i]=='o')||(desglossat_name[i]=='u')){
            document.getElementById("resultat").innerHTML += desglossat_name[i] + " es vocal <br>";   
         }
         else if ((desglossat_name[i]=='0')||(desglossat_name[i]=='1')||(desglossat_name[i]=='2')||(desglossat_name[i]=='3')||(desglossat_name[i]=='4')||(desglossat_name[i]=='5')||(desglossat_name[i]=='6')||(desglossat_name[i]=='7')||(desglossat_name[i]=='8')||(desglossat_name[i]=='9')){
            document.getElementById("resultat").innerHTML += "Els noms de les persones no contenen numeros <br>";   
         }
         else {
            document.getElementById("resultat").innerHTML += desglossat_name[i] + " es consonant <br>";   

         }
    }
}