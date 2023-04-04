while True:
    salario = float(input('digite o salario do funcionario: '))
    if salario <= 1000:
        imposto = 0
        print('isento de impostos')
    elif salario <=2000:
        imposto = salario*0.1
        print(f'o valor do imposto é de R${imposto}.')
    else:
        imposto = salario*0.2
        print(f'o valor do imposto é de R${imposto}')
    print('-'*30)