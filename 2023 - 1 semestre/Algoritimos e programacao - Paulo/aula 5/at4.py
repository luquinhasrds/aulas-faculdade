print('-' * 30)

h0 = float(input('digite a altura inicial do objeto em metros:'))  #altura inicial
g = 9.81 #aceleracao da gravidade em m/s^2
v0 = 0  #velocidade inicial em m/s

tempo_queda = (2*h0/g)**0.5  #calculo altura maxima

print(f'o tempo de queda livre é de {tempo_queda} segundos')
print('-' * 30)
v0 = float(input('digite a velocidade inicial do objeto:'))
altura_max = h0+(v0**2/(2*g))
print(f'a altura maxima do objeto é de {altura_max}')
print('-' * 30)
