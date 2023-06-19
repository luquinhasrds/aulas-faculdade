//4 - Faça um script que receba um número, calcule e mostre a tabuada desse número.

let numero, resultado

numero = Number(prompt('digite um numero para fazer a tabuada: '))

for(let i = 1; i <= 10; i++){
    resultado = numero*i
    alert(`${numero} x ${i} = ${resultado}`)
    console.log(`${numero} x ${i} = ${resultado}`)
}
