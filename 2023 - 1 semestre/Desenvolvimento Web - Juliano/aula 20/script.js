function alo(){
    alert('alo!')
}

function aloNome(nome){
    //alert('alo' + nome) //concatenaçao de strings
    alert(`alo ${nome}. seja bem vindo ao curso`) //interpolacao
}

function saudacao(){
    const nome = document.getElementById('nome').value

    if(nome === ''){
        alert('digite um nome.')
        document.getElementById('nome').focus() //foco no elemento
    }
    else{
        alert(`${nome} seja bem vindo ao curso`)
    }
}

function mousecima(){
    alert('o mouse esta aqui.')
}

function mousefora(){
    alert('o mouse saiu!!!!')
}

function textomudou(){
    alert('o texto mudou')
}

function emfoco(){
    const user = document.getElementById('user')
    user.style.border = '5px solid green'
    user.style.background = 'grey'
}

function semfoco(){
    const user = document.getElementById('user')
    user.style.border = '1px solid black'
    user.style.background = 'white'
}

function somar(){
    const num1 = Number(document.getElementById('num1').value)
    const num2 = Number(document.getElementById('num2').value)
    if (num1 != '' && num2 != ''){
        let soma = num1 + num2
        document.getElementById('result').innerHTML = 'resultado: ' + soma
    }else{
        alert('preencha os dois campos')
    }
}

function limpar(){
    document.getElementById('num1').value = ''
    document.getElementById('num2').value = ''
    document.getElementById('result').innerHTML = 'resultado'
}