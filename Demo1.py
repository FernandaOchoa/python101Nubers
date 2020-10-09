pago15Oct = 35000
bono15Oct = 7500

compuGamer = 42000
total = pago15Oct + bono15Oct

if total < compuGamer:
    print('Esta quincena no sera, tienes: '+ str(total))
elif total == compuGamer:
    print('Pensando que no vas a comer nada hasta la siguiente quincena, te alcanza')
else:
    print('Por supesto, tienes: '+ str(total))

renta = 2400
despensa = 2000
servicios = 3800

gastosFijos = renta + despensa + servicios
total = total - gastosFijos

print(str(total))

if total < compuGamer:
    print('Esta quincena no sera, tienes: '+ str(total))
elif total == compuGamer:
    print('Pensando que no vas a comer nada hasta la siguiente quincena, te alcanza')
else:
    print('Por supesto, tienes: '+ str(total))