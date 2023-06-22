function adicionar(){
    const tarefa = document.getElementById('tarefa').value
    const li = document.createElement('li')
    li.textContent = tarefa

    const remover = document.createElement('button')
    remover.textContent = 'Remover'
    remover.type = 'button'
    remover.style.marginLeft = '20px'
    remover.addEventListener('click', function(){li.remove()})

    li.appendChild(remover)
    
    //verifica se o campo esta em branco
    const pendentes = document.getElementById('pendentes')
    pendentes.appendChild(li)

    document.getElementById('tarefa').value = ''
    document.getElementById('tarefa').focus()

    
}