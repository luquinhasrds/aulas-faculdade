v0  = float(input("digite a velocidade inicial do objeto em m/s:"))
a = float(input("digite a aceleracao do objeto em m/s:"))
t = float(input("digite o tempo percorrido em segundos:"))

# formula: s =vo*t+a*t**2/2

distancia = v0*t+(a*(t**2))/2 

print(distancia)
