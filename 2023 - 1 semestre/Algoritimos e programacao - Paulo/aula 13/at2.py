#Escreva um programa que receba uma lista de nomes do usuário e imprima ca da nome em uma linha separada.

nomes = []

while True:
    nome = input('digite seu nome para a lista de nomes: ')
    nomes.append(nome)

    for item in nomes:
        print(item)