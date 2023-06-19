let numero = Number(prompt('digite um numero'))
let texto = ''
if(numero % 2 == 0){
    texto = texto + 'o numero é par'
}else{
    texto = texto + 'o numero pe impar'
}
if(numero >= 0){
    texto = texto + 'o numero é positivo'
}else{
    texto = texto+ 'o numero é negativo'
}