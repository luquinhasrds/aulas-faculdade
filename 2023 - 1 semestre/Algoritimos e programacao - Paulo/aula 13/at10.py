lista = []

print('digite os numeros um a um da sua lista, e depois digite "fim" para terminar')

while True:
    att = (input('Digite um numero (ou "fim para encerrar"):'))
    if att == 'fim':
        break
    lista.append(int(att))

verificar = int(input("Digite o número para ser verificado: "))

# Verificar se o número está presente na lista
if verificar in lista:
    print(f"O número {verificar}, está na lista.")
else:
    print(f"O número {verificar}, não na lista.")