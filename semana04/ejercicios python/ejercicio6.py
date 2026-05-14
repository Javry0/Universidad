def calificar_promedio(promedio):
    if promedio < 0 or promedio > 20:
        return "Valor inválido"
    elif promedio <= 5:
        return "Deficiente"
    elif promedio <= 10:
        return "Regular"
    elif promedio <= 14:
        return "Bueno"
    else:
        return "Excelente"


nota = float(input("Ingresa una nota entre 0 y 20: "))
resultado = calificar_promedio(nota)
print(f"La calificación es: {resultado}")