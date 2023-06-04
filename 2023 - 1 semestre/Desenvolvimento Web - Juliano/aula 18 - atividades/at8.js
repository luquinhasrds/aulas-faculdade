//8 - Faça um script que leia números até que seja digitado um número negativo, ao final mostrar a média dos números digitados. 

let numero
let soma = 0
let numeros = []

while ((numero = Number(prompt('Digite um numero (digite um numero negativo para finalizar): '))) >= 0)  {
    numeros.push(numero)
    soma += numero
}

if(numeros.length === 0){
    alert('nao foi digitado corretamente')
}else{
    let media = soma/numeros.length
    alert(`essa é a media dos numeros: ${media}`)
}