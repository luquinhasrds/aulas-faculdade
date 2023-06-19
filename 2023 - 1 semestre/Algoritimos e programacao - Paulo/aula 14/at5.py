#Escreva um programa que receba uma lista de números do usuário e retorne a quantidade de
#números ímpares presentes na lista.

lista = []
pares = []

print('digite os numeros um a um da sua lista, e depois digite "fim" para terminar')

while True:
    att = (input('Digite um numero (ou "fim para encerrar"):'))
    if att == 'fim':
        break
    lista.append(int(att))

for numeros in lista:
    if numeros %2 != 0:
        pares.append(numeros)

qtd = len(pares)
print(f'na lista voce tem {qtd} numeros impares')