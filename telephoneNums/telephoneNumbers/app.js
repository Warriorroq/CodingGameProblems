
function getRandomInt(min, max) {
    return Math.floor(min + Math.random() * Math.floor(max - min));
}

var N = getRandomInt(1, 15);
var arraySet = new Set();

for (var i = 0; i < N; i++) {
    var number = getRandomInt(1000000000, 9999999999).toString();
    console.log(number)
    for (var j = 1; j <= number.length; j++) {
        arraySet.add(number.substring(0, j))
    }

}
console.log(arraySet.size)
console.log(arraySet)
while (true);