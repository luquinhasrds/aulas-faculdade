
//botao adicionar
function adicionar() {
    const tarefa = document.getElementById('tarefa').value
    const li = document.createElement('li')
    li.textContent = tarefa

    //coloca as li para dentro da ol 'pendentes'
    const pendentes = document.getElementById('pendentes')
    pendentes.appendChild(li)

//botao remover 
    const remover = document.createElement('button')
    remover.textContent = 'Remover'
    remover.type = 'button'
    remover.style.marginLeft = '20px'
    remover.addEventListener('click', function () { li.remove() })
    li.appendChild(remover)

// Botão Concluir
    const concluir = document.createElement('button');
    concluir.textContent = 'Concluir';
    concluir.type = 'button';
    concluir.style.marginLeft = '20px';
    concluir.addEventListener('click', function () {
        const tarefa = this.parentNode; // Obtém o elemento pai (li) do botão Concluir.          confesso que esse nao entendi muito bem, pesquisei como usar na net
        const concluidas = document.getElementById('concluidas');
        concluidas.appendChild(tarefa);
    });
    li.appendChild(concluir);

    // verifica se esta em branco o imput
    document.getElementById('tarefa').value = ''
    document.getElementById('tarefa').focus()
}

//funcao para mudar de cor
function mudacor(){
    const body = document.querySelector('body')
    body.classList.toggle('fundo') //Adiciona e remove
}