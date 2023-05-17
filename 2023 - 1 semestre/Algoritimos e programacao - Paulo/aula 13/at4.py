#Escreva um programa que receba uma lista de números do usuário e calcule a
#média de todos os números presentes na lista.
lista = [1, 5, 9, 7, 6, 2, 3]

while True:
    print(f'Essa é a sua lista {lista}')
    print('''
        [1] se quiser somar os numeros

        [2] se quiser saber quantos itens tem na lista

        [3] se quiser fazer a media dos numeros da lista

        [4] para apagar a lista e fazer uma nova
        ''')
    opcao = int(input('digite a opcao desejada: '))
    if opcao == 1:
        print('-'*60)
        print(f'essa é a lista {lista}')
        print('a soma dos numeros é:')
        print(f'===== {sum(lista)} =====')
        print('-'*60)
    elif opcao == 2:
        print('-'*60)
        print(f'essa é a lista {lista}')
        print('a soma dos elementos é:')
        print(f'===== {len(lista)} =====')
    elif opcao == 3:
        print('-'*60)
        print(f'essa é a lista {lista}')
        print('a media dos numeros é:')
        media = sum(lista)/len(lista)
        print(f'===== {media} =====')
        print('-'*60)
    elif opcao == 4:
        print('-'*60)
        lista.clear()
        elementos = int(input('digite de quantos elementos vai ser sua lista: '))
        at  t = [int(input('digite os elementos que desejar um a um: '))for _ in range(elementos)]
        lista.append(att)
        print(f'aqui é a sua nova lista {lista}')
        print('-'*60)