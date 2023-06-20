import datetime as dt

def imc(peso, altura):
    calc = round(peso/(altura**2), 2)
    return calc
def classificacao(calc):
    if calc < 18.5:
        return 'seu IMC é classificado como MU  ITO MAGRO'
    elif calc < 24.9:
        return 'Seu IMC é classificado como NORMAL '
    elif calc < 29.9:
        return 'Seu IMC é classificado como SOBREPESO'
    elif calc < 34.9:
        return 'Seu IMC é classificado como OBESIDADE I'
    elif calc < 39.9:
        return 'Seu IMC é classificado como OBESIDADE II'
    else:
        return 'Seu IMC é classificado como OBESIDADE III'
nome = input('Digite o seu nome: ')
peso = float(input('Digite o seu peso: '))
altura = float(input('Digite a sua altura: '))
data = dt.datetime.now()
data_formatada = data.strftime('%d/%m/%y, %H:%M:%S')
imc_avaliado = imc(peso, altura)
imc_classificado = classificacao(imc_avaliado)

print(f'ola {nome}!')
print(f'Seu imc é {imc_avaliado}')
print(imc_classificado)
print(f'essa avaliacao foi realizada em: {data_formatada}')
