Algoritmo Esejcicio3
	Definir n Como Real;
	Escribir "Ingrese un número para verificar que sea multiplo de 14";
	Leer n;
	Si n = 0 Entonces
		Escribir "Ingrese un número válido";
	SiNo
		Si n Mod 14 = 0 Entonces
			Escribir n, " es multiplo de 14";
		SiNo
			Escribir n, " no es multiplo de 14";
		Fin Si
	Fin Si
FinAlgoritmo