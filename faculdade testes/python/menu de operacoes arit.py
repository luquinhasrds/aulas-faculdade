from time import sleep
print('===========Selecione a alguma das operações aritmeticas===========')
opcoes = 0

while opcoes != 5:
    print(
        '''
        [1]Soma

        [2]Subtração

        [3]Divisão

        [4]Multiplicação

        [5]Sair do codigo
        '''
    )
    opcoes = float(input('Digite o numero da operação que deseja: '))
    if opcoes == 1:
        print('----------voce escolheu a opcao 1 (soma)----------')
        n1 = float(input('Digite o primeiro numero: '))
        n2 = float(input('Agora o segundo numero: '))
        print(f'O resultado da soma é {n1+n2}')
        sleep(2)
    elif opcoes == 2:
        print('----------voce escolheu a opcao 2 (Subtração)----------')
        n1 = float(input('Digite o primeiro numero: '))
        n2 = float(input('Agora o segundo numero: '))
        print(f'O resultado da Subtração é {n1-n2}')
        sleep(2)
    elif opcoes == 3:
        print('----------voce escolheu a opcao 3 (Divisão)----------')
        n1 = float(input('Digite o primeiro numero: '))
        n2 = float(input('Agora o segundo numero: '))
        print(f'O resultado da divisão é {n1/n2}')
        sleep(2)
    elif opcoes == 4:
        print('----------voce escolheu a opcao 4 (Multiplicação)----------')
        n1 = float(input('Digite o primeiro numero: '))
        n2 = float(input('Agora o segundo numero: '))
        print(f'O resultado da multiplicação é {n1*n2}')
        sleep(2)
    elif opcoes == 5:
        print('Finalizando codigo...')
        sleep(2)
    else:
        print('opcao invalida')
    print('='*60)
print('CODIGO FINALIZADO')