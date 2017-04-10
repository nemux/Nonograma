Instrucciones: 
 1. Desarrolle un servicio web que permita recibir un nonograma resuelto (en su variante binaria, es decir blanco y negro, de hasta 20 x 20 celdas) y regrese como respuesta la tomografía discreta del mismo, es decir, su planteo inicial para poder jugarlo, indicando las pistas numéricas en sus filas y columnas. Defina usted el formato que considere óptimo del request y el response.
 2. Desarrollar una forma de representación visual de ese planteo inicial del juego recibido como respuesta del servicio web.
 3. Presentar un stored procedure y la tabla en SQL para darle persistencia a este planteo inicial.

Solución:

La siguiente solución de compone de 2 proyectos:


	nonoGramaWS: Servicop WCF que devuelve la Tomografía dicreta para poder dibujar un nonograma, este servicio
		     recibe 3 parámetros:
			@param1: (Int) Representa el tamaño de las filas del nonograma.
			@param2: (Int) Representa el mañano de las columnas del nonograma.
			@param3: (Int[][]) Representa un mapa con las coordenadas de FilaxColumna de cada uno de los
				 puntos marcados en el nonograma. El tamaño de debe ser Int[n][2].

			@return: (DiscreteTomography) Devuelve un objeto del tipo DiscreteTomography que contiene
				 las siguientes propiedades relevantes:

					Rows[][]: Contiene un mapa asociado al número de fila, con cada unos de los 
						  valores correspondientes a su tomografía discreta.
					Columns[][]: Contiene un mapa asociado al número de columna, con cada unos de los 
						  valores correspondientes a su tomografía discreta.
					Error_Values: Contiene valores erroneos insertados como coordenadas para el nonograma.
					Error_Coords: Contiene las coordenadas erroneas que se enviaron al nonograma, esto es
						      coordenadas que no es posible ubicarlas en el mismo.

En la figura Pantalla1, se puede ver la prueba del servicio web.
El Servicio web requiere de una base de datos, la cual puede ser creada mediante el archivo database.sql


	nonoGrama: Es un aplicativo Windows Forms que consume el servicio nonogramaWS para la creación gráfica de un nonograma.


Para la prueba de concepto, se realiza un nonograma de 4x4 con la siguiente solución en coordenadas (Figura pantalla2 y pantalla3):
(0,0),(0,2),(0,3),(1,2),(2,2),(2,1),(3,3),(3,0) 

      1     1
      1 1 3 1
      _ _ _ _
1,2  |X|_|X|X|
1    |_|_|X|_|	
2    |_|X|X|_|
1,1  |X|_|_|X|



El servicio web hace uso de una base de datos, hay que configurar el string de conexión o usar los configurados
por defecto:
	Servidor: localhost
	Usuario: temp
	Password: tempo



