while True:
    nota = int(input("Ingrese nota (0-20): "))
    if nota >= 0 and nota <= 20: 
        break
    else:
        print("Error: nota debe ser entre 0 y 20.")

if nota >= 18 and nota <= 20: 
    print("Clasificación: EXCELENTE")
elif nota >= 14 and nota <= 17:
    print("Clasificación: BUENO")
elif nota >= 11 and nota <= 13: 
    print("Clasificación: REGULAR")
else:
    print("Clasificación: DESAPROBADO")