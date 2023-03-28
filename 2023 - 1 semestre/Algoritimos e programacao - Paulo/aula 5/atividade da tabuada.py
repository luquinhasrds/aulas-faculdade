while True:
    num = int(input("DIGITE O NUMERO QUE QUER VER A TABUADA: "))
    print('-'*30)
    for tabuada in range(1, 11):
        print(f'{num} x {tabuada} = {num*tabuada}')
    print('-'*30)
