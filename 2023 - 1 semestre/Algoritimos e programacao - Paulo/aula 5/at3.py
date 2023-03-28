print("---digite um numero para ver se ele é impar ou par---")
while True:
	numero = int(input("Digite um numero:"))
	if numero % 2 != 0:
		print("O numero é impar.")
	elif numero == 0:
		print("o numero é zero ")
	else:
		print("O numero é par.")