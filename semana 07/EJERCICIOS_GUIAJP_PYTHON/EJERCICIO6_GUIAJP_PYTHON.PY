votosAna = 0
votosCarlos = 0
votosLucia = 0
nulos = 0

while True:
    print("\n--- OPCIONES DE VOTACIÓN ---")
    print("1. Ana Torres")
    print("2. Carlos Mendoza")
    print("3. Lucía Paredes")
    print("0. Cerrar votación")
    
    voto = int(input("Ingrese su voto: "))
    
    if voto == 1:
        votosAna = votosAna + 1
    elif voto == 2:
        votosCarlos = votosCarlos + 1
    elif voto == 3:
        votosLucia = votosLucia + 1
    elif voto != 0:
        nulos = nulos + 1
        print("Voto nulo")
    else: # Cuando es 0, rompe el ciclo
        break

total = votosAna + votosCarlos + votosLucia + nulos

print("\n--- RESULTADOS ---")
print(f"Ana Torres: {votosAna}")
print(f"Carlos Mendoza: {votosCarlos}")
print(f"Lucía Paredes: {votosLucia}")
print(f"Votos nulos: {nulos}")
print(f"Total de votantes: {total}")

if votosAna > votosCarlos and votosAna > votosLucia:
    print("Ganadora: Ana Torres")
elif votosCarlos > votosAna and votosCarlos > votosLucia:
    print("Ganador: Carlos Mendoza")
elif votosLucia > votosAna and votosLucia > votosCarlos:
    print("Ganadora: Lucía Paredes")
else:
    print("Resultado: EMPATE")