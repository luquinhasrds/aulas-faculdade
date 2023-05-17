#Escreva um programa que receba uma lista de números do usuário e calcule a
#soma de todos os números presentes na lista.

lista = [1, 5, 9, 7, 6, 2, 3]

while True:
    print(lista)
    print('''
        [1] se quiser somar os numeros
        [2] se quiser saber quantos itens tem na lista
        ''')
    opcao = int(input('digite a opcao desejada: '))
    if opcao == 1:
        print('-'*30)
        print('a soma dos numeros é:')
        print(sum(lista))
        print('-'*30)
    elif opcao == 2:
        print('-'*30)
        print('a soma dos elementos é:')
        print(len(lista))