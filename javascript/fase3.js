var any = 1948;
var traspas = 4;
var naixement = 1996;
var si = "El teu any de naixement era de traspas";
var no = "El teu any de naixement no era de traspas";
var coincide = true;
for (any; any <= naixement; any = any + traspas)
{
    console.log(any);
    document.writeln(any);
    var coincide = (any == naixement);
}

    if (coincide)
    {
        console.log(si);
        document.writeln(si);
    }
    else
    {
        console.log(no);
        document.writeln(no);
    }
