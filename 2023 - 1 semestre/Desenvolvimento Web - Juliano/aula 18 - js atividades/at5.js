//5 - Crie um script que leia três notas e imprima a média das notas e informe se o aluno está aprovado ou não.
//    A média para aprovação é 6.

let n1 = Number(prompt('Digite a primeira nota: '))
let n2 = Number(prompt('Digite a segunda nota: '))
let n3 = Number(prompt('Digite a terceira nota: '))

let media = (n1+n2+n3)/3

if(media >= 6){
    alert(`voce esta aprovado com nota ${media}`)
}else{
    alert(`voce foi REPROVADO, sua nota é ${media}`)
}