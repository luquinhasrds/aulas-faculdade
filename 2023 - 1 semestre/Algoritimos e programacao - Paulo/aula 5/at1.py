resistencia = float(input("digite a tensao eletrica (em Ohms):"))
tensao = float(input("digite a tensao eletrica (em volts):"))
corrente = round(tensao/resistencia, 2)
print(f"a corrente eletrica é {corrente} amperes.")