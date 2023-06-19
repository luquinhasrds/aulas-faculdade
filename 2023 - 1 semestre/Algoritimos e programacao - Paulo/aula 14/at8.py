#Escreva um programa que receba uma lista de nomes do usuário e retorne o nome mais longo
#presente na lista.

lista = []
print('digite os nomes a sua lista, e depois digite "fim" para terminar')

while True:
    att = (input('Digite um nome (ou "fim para encerrar"):'))
    if att == 'fim':
        break
    lista.append(att)


nome_longo = max(lista, key=len)

print(nome_longo)
