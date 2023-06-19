import datetime as dt #importacao do modulo

#modulo para a data
data = dt.datetime.now()
data_formatado = data.strftime('%m/%d/%y, %H:%M:%S')

def imc(peso, altura):
    return round(peso/(altura**2), 2)

#dados
print('Digite os seus dados: ')
idade = int(input('Sua idade: '))
altura = float(input('Sua altura (separado com "."): '))
peso = float(input('Seu peso: '))

#dados do usuario
print('-'*60)
print('Dados do usuario:')
print('-'*60)
print(f'Data da consulta: {data_formatado}')
print(f'---Idade do usuario: {idade} anos---')
print(f'---IMC do usuario: {imc(peso, altura)}---')