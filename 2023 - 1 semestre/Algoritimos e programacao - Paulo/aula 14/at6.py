#Escreva um programa que receba uma lista de números do usuário e retorne uma lista com
#apenas os números pares presentes na lista.

lista = []

print('digite os numeros um a um da sua lista, e depois digite "fim" para terminar')

while True:
    att = (input('Digite um numero (ou "fim para encerrar"):'))
    if att == 'fim':
        break
    lista.append(int(att))

for par in lista:
    if par %2 ==0:
        print(f'os numeros pares nao {par}')
        print('-'*30)