// JavaScript source code
/*
string val = nb.ToString();
var hashSet = new HashSet<char>();
for (int i = 0; i < val.Length; i++)
{
    hashSet.Add(val[i]);
}

return (hashSet.Count > 2) ? 0 : 1;*/

function isduodigit(number) {

     valeur = number.toString();
    var hashSet = new Set();
    for (var i = 0; i < valeur.length; i++) {
        hashSet.add(valeur[i]);
    }
    return (hashSet.Count > 2) ? 0 : 1;
}
