#Escreva um programa que receba uma lista de números do usuário e retorne uma lista com
#apenas os números que são múltiplos de 3 e 5 simultaneamente.

lista = []

print('digite os numeros um a um da sua lista, e depois digite "fim" para terminar')

while True:
    att = (input('Digite um numero (ou "fim para encerrar"):'))
    if att == 'fim':
        break
    lista.append(int(att))

for numeros in lista:
    if numeros %3 == 0 and numeros %5 == 0:
        print(numeros)
        print('-'*30)