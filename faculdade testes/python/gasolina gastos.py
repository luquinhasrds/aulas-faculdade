while True:

    print('-'*80)

    # Solicita ao usuário as informações necessárias
    preco_combustivel = float(input("Digite o preço do combustível por litro: "))
    consumo_medio = float(input("Digite o consumo médio do seu carro em km/l: "))
    distancia_percorrer = float(input("Digite a distância a percorrer em km: "))
    ida_volta = input('calcular ida e volta?')
        if ida_volta == 'sim' or 'SIM'

    # Calcula a quantidade de combustível necessária
    combustivel_necessario = distancia_percorrer / consumo_medio

    # Calcula o valor total a ser gasto em combustível
    valor_total = combustivel_necessario * preco_combustivel
    print(f'Para percorrer {distancia_percorrer} km, você precisará de {combustivel_necessario} litros de combustível, que custarão R${valor_total}.')
    print('-'*80)
