//3 - Faça um script que leia o nome e a idade de uma pessoa e informe se a pessoa é
//    maior de idade ou não. Exemplo: ‘João você tem 30 anos, é maior de idade’.

let nome, idade
let text = ''

nome = prompt('Digite o seu nome: ')
idade = Number(prompt('Digite sua idade: '))

if(idade >= 18){
    text = `${nome} voce tem ${idade}, é maior de idade.`
}else{
    text =  `${nome} voce tem ${idade}, é menor de idade.`
}
alert(text)


//alert(`${nome} voce tem ${idade}, é maior de idade.`)