function nom(){
    let list = new Map();
    var name = document.getElementById("text").value;
    var desglossat_name = Array.from(name);
    for (var i = 0; i<desglossat_name.length; i++){
        list.set(desglossat_name[i], 1);
        for (let [key, value] of list) {
            document.getElementById("resultat").innerHTML+=(key + ':' + value);

        }
    }    

}