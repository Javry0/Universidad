edad = int(input("Ingrese su edad: "))

if edad >= 18:
    print("Acceso permitido. Bienvenido.")
else:
    faltan = abs(18 - edad)
    print("Acceso denegado.")
    print("Te faltan", faltan, "año(s) para registrarte.")