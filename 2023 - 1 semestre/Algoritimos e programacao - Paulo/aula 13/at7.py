#Escreva um programa que receba uma lista de números do usuário e imprima
#apenas os números que são múltiplos de 3 e 5 simultaneamente.

lista = []

print('digite os numeros um a um da sua lista, e depois digite "fim" para terminar')

while True:
    att = (input('Digite um numero (ou "fim para encerrar"):'))
    if att == 'fim':
        break
    lista.append(int(att))

for num_par in lista:
    if num_par %3 == 0 and num_par %5 == 0:
        print(num_par)
        print('-'*30)