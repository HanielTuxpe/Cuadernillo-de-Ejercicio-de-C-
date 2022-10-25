Algoritmo ejercicio_6
	//DECLARAR VARIABLES
	Definir A,E,C,CB Como Entera
	Definir B,D,F,TT,CA Como Real
	//LEER VARIABLE
	Escribir "cantidad de producto 1"
	Leer A 
	Escribir "precio del producto"
	Leer B
	Escribir "cantidad del producto 2"
	Leer C
	Escribir "precio del producto"
	Leer D
	Escribir "cantidad del producto 2"
	Leer E
	Escribir "precio del producto"
	Leer F
	Escribir "CANTIDAD DEL BILLETE"
	Leer CB
	// PROCESO 
	TT <- (A * B) + (C * D) + (E * F)
	CA <- CB - TT
	// SALIDA
	Escribir "total a pagar es:"
	Imprimir TT 
	Escribir "el cambio es: "
	imprimir CB 
	
FinAlgoritmo
