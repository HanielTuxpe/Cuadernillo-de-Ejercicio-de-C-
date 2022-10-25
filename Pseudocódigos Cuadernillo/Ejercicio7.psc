Algoritmo EJERCICIO_7
	Definir A, B, C, D, E, F, G, H,I, J, K, L Como Entero
	Definir TPM1,TPM2,TPM3,TPM4, TPM11, TPM22, TPM33, TPM44 Como Real 
	definir TPM111, TPM222,TPM333, TPM444,TPMU,TPMD,TPMT,TPMC,DT, D1, D2, D3 Como Real 
	Escribir "prendas vendias el priar dia"
	escribir "prendas vendidas del modelo 1"
	leer A 
	escribir "prendas vendidas del modelo 2"
	leer B 
	escribir "prendas vendidas del modelo 3"
	leer C 
	escribir"prendas vendidas del modelo 4"
	leer D
	
	TPM1 <- (A * 50) - (A * 30);
	TPM2 <- (B * 70) - (B * 60);
	TPM3 <- (C * 200) - (C * 160);
	TPM4 <- (D * 150) - (D * 120);
	D1 <- TPM1 + TPM2 + TPM3 + TPM4;
	
	Escribir "prendas vendias el segundo dia"
	escribir "prendas vendidas del modelo 1"
	leer E
	escribir "prendas vendidas del modelo 2"
	leer F
	escribir "prendas vendidas del modelo 3"
	leer G
	escribir"prendas vendidas del modelo 4"
	leer H
	TPM11 <- (E * 50) - (E * 30);
	TPM22 <- (F * 70) - (F * 60);
	TPM33 <- (G * 200) - (G * 160);
	TPM44 <- (H * 150) - (H * 120);
	D2 <- TPM11 + TPM22 + TPM33 + TPM44;
	
	escribir "prendas vendias el tercer dia"
	escribir "prendas vendidas del modelo 1"
	leer I
	escribir "prendas vendidas del modelo 2"
	leer J
	escribir "prendas vendidas del modelo 3"
	leer K
	escribir"prendas vendidas del modelo 4"
	leer L
	TPM111 = (I * 50) - (I * 30);
	TPM222 = (J * 70) - (J * 60);
	TPM333 = (K * 200) - (K * 160);
	TPM444 = (L * 150) - (L * 120);
	D3 = TPM111 + TPM222 + TPM333 + TPM444;
	
	TPMU = TPM1 + TPM11 + TPM111;
	TPMD = TPM2 + TPM22 + TPM222;
	TPMT = TPM3 + TPM33 + TPM333;
	TPMC = TPM4 + TPM44 + TPM444;
	DT = D1 + D2 + D3;
	escribir "GANANCIAS DEL MODELO 1 ES: " 
	imprimir TPMU
	escribir "GANANCIAS DEL MODELO 2 ES: "
	imprimir TPMD
	escribir "GANANCIAS DEL MODELO 3 ES: "
	imprimir TPMT
	escribir  "GANANCIAS DEL MODELO 4 ES: "
	imprimir TPMC
	escribir "GANANCIA TOTAL DE LOS 3 DIAS ES: "
	imprimir DT

	
FinAlgoritmo
