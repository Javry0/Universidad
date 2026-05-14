def calcular_notas():
    
    parcial = float(input("Ingrese examen parcial: "))
    final = float(input("Ingrese examen final: "))
    p1 = float(input("Ingrese práctica 1: "))
    p2 = float(input("Ingrese práctica 2: "))
    p3 = float(input("Ingrese práctica 3: "))

    # Fórmulas
    prom_prac = (p1 + p2 + p3 - min(p1, p2, p3)) / 2
    prom_final = (parcial + final + prom_prac) / 3

    # Clasificación
    clasificacion = ""
    if prom_final >= 18:
        clasificacion = "Excelente"
    elif prom_final >= 14:
        clasificacion = "Bueno"
    elif prom_final >= 10:
        clasificacion = "Regular"
    else:
        clasificacion = "Deficiente"

    # Salida de datos (formateada para no mostrar decimales si es entero como en el ejemplo)
    print(f"Promedio de prácticas: {int(prom_prac) if prom_prac.is_integer() else prom_prac}")
    print(f"Promedio final: {int(prom_final) if prom_final.is_integer() else prom_final}")
    print(clasificacion)

if __name__ == "__main__":
    calcular_notas()
