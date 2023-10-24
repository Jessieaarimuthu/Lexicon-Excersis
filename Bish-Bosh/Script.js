

function bishbashdup(value1, value2)
 {
    let Bish = 0;
    let Bash = 0;
    let BishBash = 0;
    let numbers = 0;
    

    for (let i = value1; i <= value2; i++) {
        let sumOfDigits = 0;
        let temp = i;
        while (temp > 0) {
            sumOfDigits += temp % 10;
            temp /= 10;
        }
        if (i % 3 === 0 && i % 4 === 0)
         {
            console.log("BishBash");
            BishBash++;
        } else if (i % 3 === 0) 
        {    
            console.log("Bish");
            Bish++;
        } else if (i % 4 === 0)
         {    
            console.log("Bash");
            Bash++;
        } 
        }
    

    console.log(`${Bish}, ${Bash}, ${BishBash}`);

    return [Bish, Bash, BishBash];
}

