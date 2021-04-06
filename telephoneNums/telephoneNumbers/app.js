
function getRandomInt(min, max) {
    return Math.floor(min + Math.random() * Math.floor(max - min));
}

var N = getRandomInt(1, 15);
var tokens = new Set();

for (var i = 0; i < N; i++) {
    var telephone = getRandomInt(1000000000, 9999999999).toString();
    console.log(telephone)
    for (var j = 1; j <= telephone.length; j++) {
        tokens.add(telephone.substring(0, j))
    }

}
console.log(tokens.size)
console.log(tokens)
while (true);