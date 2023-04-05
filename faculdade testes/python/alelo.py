from time import sleep
opcoes = 0
while opcoes != 5:
    print(
    '''
    [1]soma

    [2]multiplicacao

    [3]divisao

    [4]subtracao

    [5]sair do programa
    '''
    )

    opcoes = float(input('Digite o numero que deseja: '))
    
    if opcoes == 1:
        n1 = float(input('digite o primeiro numero: '))
        n2 = float(input('digite o segundo numero: '))
        resut = n1+n2
        print(f'o resultado da soma é {resut}')
    elif opcoes == 2:
        n1 = float(input('digite o primeiro numero: '))
        n2 = float(input('digite o segundo numero: '))
        resut = n1*n2
        print(f'o resultado da soma é {resut}')
    elif opcoes == 3:
        n1 = float(input('digite o primeiro numero: '))
        n2 = float(input('digite o segundo numero: '))
        resut = n1/n2
        print(f'o resultado da soma é {resut}')
    elif opcoes == 4:
        n1 = float(input('digite o primeiro numero: '))
        n2 = float(input('digite o segundo numero: '))
        resut = n1-n2
        print(f'o resultado da soma é {resut}')
    elif opcoes == 5:
        print('fim do programa')
        sleep(2)
    else:
        print('opcao invalida')
print('codigo finalizado')



