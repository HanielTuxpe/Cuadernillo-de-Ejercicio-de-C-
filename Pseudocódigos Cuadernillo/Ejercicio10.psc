Algoritmo ejercicio_10
	definir E Como Caracter;
	definir PDP,CDM Como Real;
	escribir "PAQUETERIA HUEJUTLA";
	escribir "LUGAR DE EMVIO";
	leer E;
	escribir "PESO DEL PAQUETE";
	leer PDP;
	si (E == 'L' | E == 'l' | E == 'G' | E == 'g' | E == 'M' | E == 'm' | E == 'Q' | E == 'q')
		Entonces
		segun E Hacer
            Opcion 'L':
			Opcion 'l':
				CDM <- PDP * 15;
			Opcion 'G':
			Opcion 'g':
				CDM <- PDP * 20;
			Opcion 'M':
			Opcion 'm':
				CDM <- PDP * 25;
			Opcion 'Q':
			Opcion 'q':
				CDM <- PDP * 10;
		FinSegun
		Escribir "PRECIO DE EMVIO DEL PAQUE:"
		Imprimir  CDM;
	SiNo
		Escribir "VERIFICAR EL LUGAR DE EMVIO"
	FinSi
	
	
FinAlgoritmo
