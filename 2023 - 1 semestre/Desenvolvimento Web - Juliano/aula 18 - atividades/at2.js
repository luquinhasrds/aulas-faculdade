//2 - Faça um script que leia um número e mostre uma mensagem
//    indicando se este número é par ou ímpar e se é positivo ou negativo.

let numero = Number(prompt('digite um numero:'))
let texto = ''
if (numero % 2 == 0){
    texto = texto + 'o numero é par, '
}else{
    texto = texto + 'o numero é impar, '
}

if(numero >= 0){
    texto = texto + 'o numero é positivo.'
}else{
    texto = texto + 'o numero é negativo.'
}
alert(texto)