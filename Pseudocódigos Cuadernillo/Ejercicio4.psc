Algoritmo Ejercicio4
	Definir d, t, op Como Real;
	//Entrada
	Escribir "Ofertas del menú del día: ";
	Escribir "1 = Antojitos mexicanos";
	Escribir "2 = Milanesa de res|Bistec a la mexicana|Pollo a la crema";
	Escribir "3 = Comida especial del día";
	Leer op;
	//Proceso
	Si op == 1 || op == 2 || op == 3 Entonces
		Segun op Hacer
			1:
				d = (35 * 8) / 100; t = 35 - d;
			2:
				d = (40 * 5) / 100; t = 40 - d;
			3:
				d = (50 * 10) / 100; t = 50 - d; 
		Fin Segun
		//salida
		Escribir "El descuento es de: $", d;
		Escribir "El precio de su orden es de: $", t;
	SiNo
		Escribir "Elija una opción correcta"
	Fin Si
FinAlgoritmo