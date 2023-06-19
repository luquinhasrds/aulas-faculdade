import requests
requisicao = requests.get('https://economia.awesomeapi.com.br/json/last/USD-BRL')

print(requisicao)

dic_requisicao = requisicao.json()

print(dic_requisicao)

cambio = dic_requisicao["USDBRL"]["bid"]

dolar = float(cambio)




"""while True:

    opcao=int(input("1 para Dol-> Reais \n2- Para Real -> Dol\n"))
    cotacao_dolar=float(input("Digite a cotaçao do Doleta"))
    valor_a_ser_convertido= float(input("Qual o valor?\n"))
    if opcao ==1:
        valor_convertion=valor_a_ser_convertido*cotacao_dolar
        print(f" O Valor {valor_a_ser_convertido} em reais é R${valor_convertion}")
    elif opcao ==2:
        valor_convertion= valor_a_ser_convertido/cotacao_dolar
        print(f" O Valor {valor_a_ser_convertido} em dolars é ${valor_convertion}")
    else
        print('opcao invalida')"""