console.log("Hello World!");
function calculator(arg1, action, arg2) {

    if ( (arg1 === undefined) || (action === undefined) || (arg2 === undefined) || (arg1 === null) || (action === null) || (arg2 === null)) {
        return "INVALID"
    }

    if ( (typeof arg1 !== 'number') || (typeof arg2 !== 'number')) {
        return "INVALID"
    }

    if (action === "add") {
        return arg1 + arg2
    } else if (action === "subtract") {
        return arg1 - arg2
    } else if (action === "multiply") {
        return arg1 * arg2
    } else if (action === "divide") {
        return arg1 / arg2
    } else {
        return "INVALID"
    }
}

function calcTest(arg1, action, arg2) {
    var test = calculator(arg1, action, arg2)
    if ( test === "INVALID") {
        console.log(test)
    } else {
        console.log("The result is " + test)
    }
}

calcTest(2, "add", 2)
calcTest("a", "add", "0")
calcTest(10, "divide", 2)
calcTest(3, "multiply", 3)

var input = { arg1: 2, action: "add", arg2: 2 };

function objectCalculator(calcArgs) {
    if ( (calcArgs.arg1 === undefined) || (calcArgs.action === undefined) || (calcArgs.arg2 === undefined) || (calcArgs.arg1 === null) || (calcArgs.action === null) || (calcArgs.arg2 === null) ) {
        return "INVALID"
    }

    if ( (typeof calcArgs.arg1 !== 'number') || (typeof calcArgs.arg2 !== 'number') ) {
        return "INVALID"
    }

    if (calcArgs.action === "add") {
        return calcArgs.arg1 + calcArgs.arg2;
    } else if (calcArgs.action === "subtract") {
        return calcArgs.arg1 - calcArts.arg2;
    } else if (calcArgs.action === "multiply") {
        return calcArgs.arg1 * calcArgs.arg2;
    } else if (calcArgs.action === "divide") {
        return calcArgs.arg1 / calcArgs.arg2;
    } else {
        return "INVALID";
    }
}

objectCalculator(input);

function calcTest2() {
    var testData = [
        { arg1: 2, action: "add", arg2: 2 },
        { arg1: "a", action: "add", arg2: "0" },
        { arg1: 10, action: "divide", arg2: 2},
        { arg1: 3, action: "multiply", arg2: 3 }
    ];

    for (i = 0; i < testData.length; i++) {
        var test = objectCalculator(testData[i])
        if ( test === "INVALID" ) {
            console.log(test)
        } else {
            console.log("The result is " + test)
        }
}
}

calcTest2()