print("--calcular aplicação--")
valor_apli = float(input("digite o valor da sua aplicação:"))
juros = float(input("digite o porcentual de juros ao mes:"))
tempo = int(input("digite por quantos meses esse valor foi aplicado:"))
juros = juros/100
valor_final = (valor_apli*juros*tempo)+valor_apli
print("o valor final da aplicação foi de", valor_final)