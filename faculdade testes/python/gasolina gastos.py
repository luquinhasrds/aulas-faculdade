# Solicita ao usuário as informações necessárias
preco_combustivel = float(input("Digite o preço do combustível por litro: "))
consumo_medio = float(input("Digite o consumo médio do seu carro em km/l: "))
distancia_percorrer = float(input("Digite a distância a percorrer em km: "))

# Calcula a quantidade de combustível necessária
combustivel_necessario = distancia_percorrer / consumo_medio

# Calcula o valor total a ser gasto em combustível
valor_total = combustivel_necessario * preco_combustivel

# Exibe o resultado para o usuário
print("Para percorrer {} km, você precisará de {:.2f} litros de combustível, que custarão R${:.2f}.".format(distancia_percorrer, combustivel_necessario, valor_total))
