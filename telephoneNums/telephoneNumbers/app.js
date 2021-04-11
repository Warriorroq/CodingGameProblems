
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

//<------------Second turn------------------->

class Tree {
    constructor(telephoneNum) {
        this.nodes = []
        this.value = telephoneNum[0]
    }

    addNode(telephoneNumber) {
        if (telephoneNumber.length != 0) {
            for (var node of this.nodes) {
                if (node.value == telephoneNumber[0]) {
                    node.addNode(telephoneNumber.substr(1))
                    return;
                }
            }
            this.createNode(telephoneNumber)
        }
    }
    createNode(telephoneNumber) {
        var newNode = new Tree(telephoneNumber[0])
        newNode.addNode(telephoneNumber.substr(1))
        this.nodes.push(newNode)
    }
    nodeSize() {
        var size = 1
        for (var node of this.nodes)
            size += node.nodeSize()
        return size
    }
}

N = getRandomInt(1, 15);
var tree = new Tree(NaN)
for (var i = 0; i < N; i++)
    tree.addNode(getRandomInt(1000000000, 9999999999).toString())
console.log(tree.nodeSize() - 1)
while (true);