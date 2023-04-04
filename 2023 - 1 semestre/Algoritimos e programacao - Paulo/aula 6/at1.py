nota = [float(input('Digite a nota: '))for _ in range(3)]
media = round(sum(nota)/len(nota), 2)
if media > 7:
    print(f'voce foi APROVADO com media {media}.')
else:
    print(f'voce foi REPROVADO, media {media}.')