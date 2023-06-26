while True:
    print('escolha a opcao que deseja: ')
    print(
        '''

        ----Menu de opções----

        [1]Celsius para Fahrenheit

        [2]Celsius para Kelvin

        [3]Fahrenheit para Celsius

        [4]Fahrenheit para Kelvin

        [5]Kelvin para Celsius

        [6]Kelvin para Fahrenheit

        [7]SAIR
        '''
    )

    opcao = int(input('Digite a opção desejada: '))

    if opcao == 1:  #  F = (C × 9/5) + 32
        temp = int(input('Digite a temperatura a ser convertida: '))   
        conversao = (temp*(9/5))+32
        print(f'{temp} graus celsius em Fahrenheit é {conversao}')
    elif opcao == 2: # K = C + 273.15
        temp = int(input('Digite a temperatura a ser convertida: '))
        conversao = temp + 273.15
        print(f'{temp} graus celsius em Kelvin é {conversao}')
    elif opcao == 3: # C = (F - 32) × 5/9
        temp = int(input('Digite a temperatura a ser convertida: '))
        conversao = (temp-32)*(5/9)
        print(f'{temp} Fahrenheit para Celsius é {conversao}')
    elif opcao == 4: # K = (F + 459.67) × 5/9
        temp = int(input('Digite a temperatura a ser convertida: '))
        conversao = (temp+459.67)*(5/9)
        print(f'{temp} Fahrenheit para Kelvin é {conversao}')
    elif opcao == 5: # C = K - 273.15
        temp = int(input('Digite a temperatura a ser convertida: '))
        conversao = (temp-273.15)
        print(f'{temp} Kelvin para Celsius é {conversao}')
    elif opcao == 6: # F = (K × 9/5) - 459.67
        temp = int(input('Digite a temperatura a ser convertida: '))
        conversao = (temp*9/5)-459.67
        print(f'{temp} Kelvin para Fahrenheit é {conversao}')
    elif opcao == 7:
        break