#   Escreva um programa que receba uma lista de números do usuário e imprima
#apenas os números pares presentes na lista.

lista = []

print('digite os numeros um a um da sua lista, e depois digite "fim" para terminar')

while True:
    att = (input('Digite um numero (ou "fim para encerrar"):'))
    if att == 'fim':
        break
    lista.append(int(att))

for num_par in lista:
    if num_par %2 == 0:
        print('-'*30)
        print('os numeros pares são:')
        print(num_par)
        print('-'*30)
