Algoritmo Ejercicio5
	Definir p, d, t, op, nb, st Como Real;
	p = 365.55;
	Escribir "Elija su tarifa de viaje: ";
	Escribir "1 = Estudiante || 2 = Adulto || 3 = Ni�o";
	Leer op;
	si op == 1 | op == 2 | op == 3 Entonces
		Escribir "�Cu�ntos boletos va a comprar?";
		Leer nb;
		Segun op Hacer
			1: d = (p * 8) / 100; st = p - d; t = nb * st;
				
			2: d = 0; st = p - d; t = nb * st;
				
			3: d = (p * 50) / 100; st = p - d; t = nb * (p - d);
		FinSegun
		//Salida
		st = REDON(st * 100)/100;
		t = REDON(t * 100)/100;
		Escribir "El descuento es de: $", d;
		Escribir "El precio del boleto con descuento incluido es de: $", st;
		Escribir "El total a pagar por ", nb, " boletos es de: $", t;
	SiNo
		Escribir "Eliga una opci�n correcta";
	fin si
FinAlgoritmo