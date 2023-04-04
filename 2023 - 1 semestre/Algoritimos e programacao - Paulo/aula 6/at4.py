produto = float(input('Digite o valor do produto: '))
if produto > 50:
    desc = produto*(1-0.05)
    print(f'o valor do prouto é {desc}')
else:
    desc = produto*(1-0.1)
    print(f'o valor do prouto é {desc}')