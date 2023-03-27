print("---digite um numero para ver se ele é impar ou par---")
while True:
	numero = int(input("Digite um numero:"))
	if numero % 2 == 0:
		print("O numero é par.")
	else:
		print("O numero é impar.")