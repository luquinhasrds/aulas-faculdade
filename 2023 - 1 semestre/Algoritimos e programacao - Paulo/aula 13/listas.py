# ADICIONAR ALGUM DADO NA LISTA
lista = [1, 2, 3 , 4, 5]

while True:
    print(f'o conteudo da lista é: {lista}')

    novo = float(input('digite um valor:'))

    lista.append(novo) #append = funcao para adicionar dado

    print(f'lista atualizada: {lista}')


# APAGAR ALGUM DADO DA LISTA
lista = [1, 2, 3, 4, 5]

while True:
    print(f'o conteudo da lista é: {lista}')

    lista.pop() # digite a posicao de deseja apagar

    print(f'lista atualizada: {lista}')


# ORGANIZAR A LISTA 
lista = [4, 3, 5, 2, 1]

print(lista)

lista.sort() #funcao para organizar lista 

print(lista)