while True:
    print('='*60)
    print('----------calcule a area de alguma figura geometrica----------')
    print(
        '''
        [1]circulo

        [2]quadrado

        [3]retangulo
        '''
    )
    opcao = int(input('digite o numero da opcao que deseja: '))
    if opcao == 1:
        print('-----circulo-----')
        raio = int(input('digite o raio do circulo'))
        area = round((3.142*(raio**2)), 2)
        print(f'a area do circulo é {area}')
    elif opcao == 2:
        print('-----quadrado-----')
        lado = int(input('digite quanto tem um lado do quadrado: '))
        area = round()