#Escreva um programa que receba uma lista de números do usuário e imprima a lista na tela.

lista = []

while True:
    numero = int(input('Digite um numero para entrar na lista: '))
    lista.append(numero)
    print(lista)