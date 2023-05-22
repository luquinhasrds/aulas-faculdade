#Escreva um programa que receba uma lista de números do usuário e imprima
#apenas os números ímpares presentes na lista.

lista = []

print('digite os numeros um a um da sua lista, e depois digite "fim" para terminar')

while True:
    att = (input('Digite um numero (ou "fim para encerrar"):'))
    if att == 'fim':
        break
    lista.append(int(att))

for num_impar in lista:
    if num_impar %2 != 0:
        print(num_impar)
        print('-'*30)