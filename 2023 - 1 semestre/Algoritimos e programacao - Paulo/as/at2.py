while True:
    print(
        '''
        selecione uma das opcoes

        [1] verificar aprovações

        [2] SAIR

        '''
    )

    opcao = int(input('digite a opcao que deseja: '))
    if opcao == 1:
        nome = input('digite o seu nome: ')
        ap1 = int(input('digite a sua nota da ap1: '))
        ap2 = int(input('digite a sua nota da ap2: '))
        aas = int(input('digite a sua nota da as: '))
        faltas = int(input('digite o numero de faltas: '))

        ps = ap1+ap2+aas

        if ps >= 6 and faltas <= 5:
            print(f'Parabens {nome} voçê foi aprovado.')
        elif faltas > 5:
            print(f'{nome}, infelizmente voçê foi reprovado por faltas.')
        elif ps <= 6 or faltas <= 5:
            print(f'{nome}, voçê devera fazer a avaliação a avaliacao final (AF).')
        
    elif opcao == 2:
        break