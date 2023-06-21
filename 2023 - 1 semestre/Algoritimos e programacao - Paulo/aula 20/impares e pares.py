from time import sleep

par = []
impar = []

def numeros(lista, num):
    lista.append(num)

while True:
    num = int(input('digite os numeros da sua lit (e digite 0 para finalizar): '))
    if num == 0:
        print('finalizando o codigo...')
        sleep(1.5)
        break
    elif num % 2 == 0:
        numeros(par, num)
    elif num % 2 != 0:
        numeros(impar ,num)

print('-'*60)
print(f'Os numeros PARES são {par}, e os numeros IMPARES são {impar}.')
print('-'*60)
