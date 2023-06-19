lista = []
cont = 0
while True:
    try:
        num = int(input('digite um numero:'))
    except ValueError:
        print('digite um numero inteiro valido!!!!')

    if num == 0 :
        break
        
    else:
        lista.append(num)

for item in lista:
    if item % 2 == 0:
        cont = cont + 1
print(cont)
