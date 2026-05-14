
print("==Menú de operaciones==")
print("1. calcular área de un círculo")
print("2. Calcular área de un cuadrado")
print("3. Calcular área de un triángulo")
print("4. Salir")

opcion = int(input("Seleccione una opción (1-4): "))

match opcion:

    case 1:
        print("elegiste círculo")
        print("Área del círculo = π x r²")
    case 2:
        print("elegiste cuadrado")
        print("Área cuadrado = lado²")
    case 3:
        print("elegiste triangulo")
        print("Área triángulo = (base x altura) / 2")
    case 4:
        print("saliendo del programa....")
    case _:
        print("Opción invalidad ingrese un numero del 1 al 4")
        