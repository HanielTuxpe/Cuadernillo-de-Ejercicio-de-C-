Algoritmo Ejercicio2
	Definir np, cc, tp, tg, p Como Real;
	//Entrada
	Escribir "Calcule la cantidad de pan que genera al día y la ganancia";
	Escribir "¿Cuántos panes caben en una charola?";
	Leer np;
	Escribir  "¿Cuántas charolas meten al horno por día?";
	Leer cc;
	Escribir "¿Cuánto cuesta el pan por pieza?";
	Leer p;
	//Proceso
	tp = np * cc;
	tg = tp * p;
	//salida
	Escribir "El total de produccion de panes en un dia es de: ", tp;
	Escribir "El ganancia total por la venta de", np, "panes en un dia es de: $", tg;
FinAlgoritmo
