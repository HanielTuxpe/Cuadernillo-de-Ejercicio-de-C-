Algoritmo ejercicio_8
	definir NA Como Entero
	definir CB Como Real
	escribir "NUMERO DE ALUMNOS: ";
	leer NA;
	
	si (NA >= 150)
		Entonces
	CB = 70;
	escribir "EL COSTO DEL  VOLETO POR ALUMNO ES: ";
	Imprimir CB;
SiNo
	si (NA <= 100 & NA > 90 )
		Entonces
	CB = 80;
	escribir "EL COSTO DEL  VOLETO POR ALUMNO ES: ";
	Imprimir CB;
SiNo
	si (NA <= 90 & NA > 30)
		Entonces
	CB = 90;
	escribir "EL COSTO DEL  VOLETO POR ALUMNO ES: ";
	imprimir CB;
SiNo
	si (NA <= 30 & NA > 0)
		Entonces
	CB = 5000;
	escribir "EL COSTO DEL AUTOBUS ES: ";
	Imprimir CB;
SiNo
	si (NA <= 0)
		Entonces
	escribir "verificar la cantidad de alumnos";
fin si 
fin si
fin si 
fin si 
fin si 
	

	
FinAlgoritmo
