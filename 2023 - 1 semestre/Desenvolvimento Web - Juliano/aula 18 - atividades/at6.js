//6 - Crie um novo script que leia um número que só pode ser de 1 a 7 e imprima os dias da semana sendo 1 = domingo e 7 = sábado.

let dia = Number(prompt('Digite um numero de 1 a 7:'))

switch(dia){
    case 1:
        diasemana = 'domingo'
        break;
    case 2:
        diasemana = 'segunda'
        break;
    case 3:
        diasemana = 'terça'
        break;
    case 4:
        diasemana = 'quarta'
        break;
    case 5:
        diasemana = 'quinta'
        break;
    case 6:
        diasemana = 'sexta'
        break;
    case 7:
        diasemana = 'sabado'
        break;
}
alert(diasemana)