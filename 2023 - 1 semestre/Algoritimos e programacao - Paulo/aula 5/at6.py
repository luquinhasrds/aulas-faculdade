a = float(input("digite o lado do triangulo:"))
b = float(input("digite o segundo lado do triangul:"))
c = float(input("digite o terceiro lado do triangulo:"))

if (a > b+c) or (b > a+c) or (c > a+b):
    print("Não é um triangulo")
elif (a==b) and (a==c):
    print("o triangulo é equilatero")
elif (a==b) or (a==c) or (b==c):
    print("o triangulo é isosceles")
else:
    print("escaleno")