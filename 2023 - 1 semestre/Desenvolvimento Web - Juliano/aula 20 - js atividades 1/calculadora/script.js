function limpar(){
    document.getElementById('num1').value = ''
    document.getElementById('num2').value = ''
    document.getElementById('resultado').innerHTML = 'Resultado: '
}

function somar(){
    const num1 = Number(document.getElementById('num1').value)
    const num2 = Number(document.getElementById('num2').value)
    if (num1 != '' && num2 != ''){
        let soma = num1+num2
        document.getElementById('resultado').innerHTML = 'Resultado: ' + soma
    }else{
        alert('Preencha os campos para somar')
    }

}

function subtrair(){
    const num1 = Number(document.getElementById('num1').value)
    const num2 = Number(document.getElementById('num2').value)
    if (num1 != '' && num2 != ''){
        let subtracao = num1-num2
        document.getElementById('resultado').innerHTML = 'Resultado: ' + subtracao
    }else{
        alert('Preencha os campos para somar')
    }
}

function dividir(){
    const num1 = Number(document.getElementById('num1').value)
    const num2 = Number(document.getElementById('num2').value)
    if (num1 != '' && num2 != ''){
        let divicao = num1/num2
        document.getElementById('resultado').innerHTML = 'Resultado: ' + divicao
    }else{
        alert('Preencha os campos para somar')
    }
}

function multiplicar(){
    const num1 = Number(document.getElementById('num1').value)
    const num2 = Number(document.getElementById('num2').value)
    if (num1 != '' && num2 != ''){
        let mult = num1*num2
        document.getElementById('resultado').innerHTML = 'Resultado: ' + mult
    }else{
        alert('Preencha os campos para somar')
    }
}

function limparnota(){
    document.getElementById('ap1').value = ''
    document.getElementById('ap2').value = ''
    document.getElementById('as').value = ''
    document.getElementById('nota').innerHTML = 'Resultado: '
}

function calcular(){
    const ap1 = Number(document.getElementById('ap1').value)
    const ap2 = Number(document.getElementById('ap2').value)
    const as = Number(document.getElementById('as').value)
    if (ap1 != '' && ap2 != '' && as != ''){
        let calc = ap1+ap2+as
        if(calc >= 6){
            document.getElementById('nota').innerHTML = 'Nota: ' + calc + ' Aprovado. Parabens'
        }if(calc < 6){
            document.getElementById('nota').innerHTML = 'Nota: ' + calc + ' Reprovado. Estude mais.'
        }
        
    }else{
    alert('Preencha os campos para somar')
    }
}

function verificaAp1(){
    const ap1 = Number(document.getElementById('ap1').value)
    if (ap1 < 0 || ap1 > 1.5){
        alert ('Digite uma nota de 0 a 1.5.')
        document.getElementById('ap1').value = ''
    }
}

function verificaAp2(){
    const ap2 = Number(document.getElementById('ap2').value)
    if (ap2 < 0 || ap2 > 2.5){
        alert ('Digite uma nota de 0 a 2.5.')
        document.getElementById('ap2').value = ''
    }
}

function verificaAs(){
    const as = Number(document.getElementById('as').value)
    if (as < 0 || as > 6){
        alert ('Digite uma nota de 0 a 6.')
        document.getElementById('as').value = ''
    }
}