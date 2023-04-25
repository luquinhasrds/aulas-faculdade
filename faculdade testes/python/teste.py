contador = 0
print('programa para consultar apoentadoria')
while True:
    print(f'avaliacao numero {contador}')
    print(
        '''
        [1]Homem

        [2]Mulher

        [3]Sair

        '''
    )

    opcao = int(input('digite a opcao desejada'))
    contador += 1
    if opcao == 1:
        nome = input('Digite o nome do avaliado: ')
        idade = int(input('digite a idade do avaliador: '))
        tempo = int(input('digite o tempo de contribuicao do avaliador: '))
        if idade >= 55 and tempo >= 35:
            print('parabens, voce pode solicitar a aposentadoria')
        else:
            print('o brasil ainda precisa de voce, siga firme!!')
    elif opcao == 2:
        nome = input('Digite o nome do avaliado: ')
        idade = int(input('digite a idade do avaliador: '))
        tempo = int(input('digite o tempo de contribuicao do avaliador: '))
        if idade >= 50 and tempo >= 30:
            print('parabens, voce pode solicitar a aposentadoria')
        else:
            print('o brasil ainda precisa de voce, siga firme!!')
    elif opcao == 3:
        print('saindo do programa...')
        break
    else:
        print('digite uma opcao valida!!!!!!!!!!!!')