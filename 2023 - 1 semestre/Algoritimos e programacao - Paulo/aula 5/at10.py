notas = [float(input("Digite a nota:")) for c in range(5)]
soma_notas = sum(notas)
quantidade = len(notas)
print(f"a media das notas é {soma_notas/quantidade}")
