print("--calculo de desconto--")
valordoproduto = float(input("digite o valor do produto:"))
desconto = int(input("digite o valor do desconto:"))
desconto = desconto/100
valorfinal = valordoproduto*(1-desconto)
print("valor final do produto e:", valorfinal)