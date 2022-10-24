Algoritmo Ejercicio1
	//Declarar Variables
	Definir nt, t Como Entero;
	Escribir "Calcule el precio de total por una conpra de tamales";
	//Entrada
	Escribir "¿Cuántos tamales va a comprar?";
	Leer nt
	//Proceso
	Si nt <= 100 Entonces
		t = nt * 10;
	SiNo
		Si nt > 100 & nt <= 200 Entonces
			t = nt * 8
		SiNo
			t = nt * 6
		Fin Si
	Fin Si
	//Salida
	Escribir "El total a pagar por ", nt , " tamales es de: ", t;
FinAlgoritmo
