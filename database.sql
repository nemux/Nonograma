CREATE DATABASE nonograma;
USE nonograma;

CREATE TABLE nonograma (
	id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	total_columns int,
	total_rows int
);


CREATE TABLE solution (
	id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	nonograma_id int,
	column_no int,
	row_no int

	FOREIGN KEY (nonograma_id) REFERENCES nonograma(id)
);

CREATE PROCEDURE sp_savenonogram
	@columns int,
	@rows int
AS
	INSERT INTO nonograma (total_columns,total_rows)
	VALUES (@columns,@rows)
	SELECT MAX (id) from nonograma

CREATE PROCEDURE sp_savesolution
	@nonograma_id int,
	@column int, 
	@row int 
AS
	INSERT INTO solution (nonograma_id,column_no,row_no)
	VALUES (@nonograma_id,@column,@row)
	



























