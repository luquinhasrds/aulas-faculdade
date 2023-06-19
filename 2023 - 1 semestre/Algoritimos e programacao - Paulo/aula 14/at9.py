#Escreva um programa que receba uma lista de números do usuário e retorne a média dos
#números presentes na lista.

lista = []

print('digite os numeros um a um da sua lista, e depois digite "fim" para terminar')

while True:
    att = (input('Digite um numero (ou "fim para encerrar"):'))
    if att == 'fim':
        break
    lista.append(int(att))

media = sum(lista)/len(lista)

print(f'a media da lista é {media}')