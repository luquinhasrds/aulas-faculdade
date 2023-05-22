#Escreva um programa que receba uma lista de números do usuário e imprima a
#lista em ordem crescente.

lista = []

print('digite os numeros um a um da sua lista, e depois digite "fim" para terminar')

while True:
    att = (input('Digite um numero (ou "fim para encerrar"):'))
    if att == 'fim':
        break
    lista.append(int(att))

lista.sort()

print(lista)