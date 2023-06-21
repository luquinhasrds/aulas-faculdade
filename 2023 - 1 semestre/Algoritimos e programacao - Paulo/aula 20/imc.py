import datetime as dt

data = dt.datetime.now()
data_formatado = data.strftime('%m/%d/%y, %H:%M:%S')

#dados
print('Digite os seus dados: ')
nome = input('Seu nome: ')
altura = float(input('Sua altura (separado com "."): '))
peso = float(input('Seu peso: '))

imc = round(peso/(altura**2), 2)

print('-'*60)
print('Dados do usuario:')
print('-'*60)
print(f'Data da consulta: {data_formatado}')
print(f'---Idade do usuario: {nome}---')
print(f'---IMC do usuario: {imc}---')