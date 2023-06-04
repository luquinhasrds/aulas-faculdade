//prompt recebe entrada do usuario
let numero = Number(prompt('digite um numero')) //'Number' converte para tipo numero

if(numero > 5){
    alert('é maior.');
}
else if(numero == 5){
    alert('é igual');
    console.log(numero)
}
else{
    alert('é menor');
}



let opcao = Number(prompt('digite um numero de 1 a 4'))
switch(opcao){
    case 1:
        alert('opcao 1')
        break
    case 2:
        alert('opcao 2')
        break
    case 3:
        alert('opcao 3')
        break
    case 4:
        alert('opcao 4')
        break
    default:
        alert('selecione uma opcao valida')
}