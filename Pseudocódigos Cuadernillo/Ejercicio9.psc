Algoritmo ejercicio_9
	definir A Como Caracter;
	definir PK, KR, B Como Real;
	definir CP Como Entero;
	escribir "TIPOS DE AUTOBUS";
	escribir "H";
	escribir "N";
	escribir "R";
	escribir "TIPO DE AUTOBUS";
	leer A;
	escribir "CANTIDA DE PERSONAS";
	leer CP;
	si (CP < 15)
		Entonces
		escribir "EL AUTOBUS NO PUEDE SALIR";
	SiNo
		si (A == 'H' | A == 'h' | A == 'N' | A == 'n' | A == 'R' | A == 'r')
			Entonces
			escribir"KILOMETROS RECORRIDOS";
	leer KR;
	Segun A Hacer
			Opcion 'H': 
			opcion 'h':
				PK = 6 * KR;
			    B = CP * PK;
		Opcion 'N':
		opcion 'n':
			PK = 8 * KR;
			B = CP * PK;
		opcion 'R':
		opcion 'r':
			PK = 9 * KR;
			B = CP * PK;
	Fin Segun
	escribir "COSTO TOTAL POR PERSONA ES: ";
	Imprimir PK;
	escribir "COSTO TOTAL ES: ";
	imprimir B;
sino 
	Escribir "verifcar el autobus"
finsi 
FinSi

	
FinAlgoritmo
