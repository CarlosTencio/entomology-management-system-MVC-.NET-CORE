CREATE DATABASE ProyectoSGCE
USE ProyectoSGCE

CREATE TABLE tb_user(
id_usuario INT PRIMARY KEY IDENTITY, 
nombre_usuario VARCHAR(50),
password Varbinary(255),
tipo_usuario INT,
is_active INT
)

CREATE TABLE tb_comment(
ID_comment INT PRIMARY KEY IDENTITY,
ID_user INT,
Comment VARCHAR(250),
Id_specimen INT,
FOREIGN KEY(ID_user) REFERENCES tb_user(id_usuario) 
)

	select * from tb_comment
	
CREATE PROCEDURE sp_search_user
 @nombre_usuario VARCHAR(100)
AS
BEGIN
    DECLARE @exists BIT;
    
    -- Verificar si el nombre de usuario existe en la base de datos
    IF EXISTS (SELECT 1 FROM tb_user WHERE nombre_usuario = @nombre_usuario)
    -- Devolver el resultado
    SELECT @exists AS 'Exists';
END
EXEC sp_verify_login 'sse','sse',0
CREATE PROCEDURE sp_verify_login
@nombre_usuario VARCHAR(50),
@password VARCHAR(255),
@Result INT OUTPUT
AS
BEGIN 
	DECLARE @table_password varbinary(160) = (SELECT password FROM tb_user WHERE nombre_usuario = @nombre_usuario);
    if(@table_password IS NOT NULL)
    BEGIN 
        OPEN SYMMETRIC KEY smkProyectoLenguajes
            DECRYPTION BY CERTIFICATE certProyectoLenguajes;

        DECLARE @origin_password varbinary(160) = DECRYPTBYKEY(@table_password);

        DECLARE @sha_password varbinary(160) = HASHBYTES('SHA2_256',@password);

        CLOSE SYMMETRIC KEY smkProyectoLenguajes;
        IF (@sha_password = @origin_password ) 
        BEGIN
            SET @Result = 1;
        END
        ELSE
        BEGIN
            SET @Result = 0

        END
    END
    SELECT @Result;
END;





CREATE PROCEDURE sp_register_user
@nombre_usuario VARCHAR(50),
@password VARCHAR(255)
AS
BEGIN 
	
		if(not exists(SELECT id_usuario FROM tb_User WHERE nombre_usuario=@nombre_usuario))
		BEGIN
			OPEN SYMMETRIC KEY smkProyectoLenguajes
				DECRYPTION BY CERTIFICATE certProyectoLenguajes;

			DECLARE @sha_password varbinary(160) = HASHBYTES('SHA2_256',@password);
			DECLARE @encrypted_password varbinary(160) = ENCRYPTBYKEY(key_GUID('smkProyectoLenguajes'),@sha_password);

			INSERT INTO tb_user VALUES(@nombre_usuario,@encrypted_password ,1,1);

			CLOSE SYMMETRIC KEY smkProyectoLenguajes;
		END
END



CREATE PROCEDURE sp_register_comment_user
@name_user VARCHAR(100),
@Comment VARCHAR(250),
@Id_specimen INT
AS 
BEGIN
	DECLARE @id_user INT;
	SET @id_user= (SELECT id_usuario FROM tb_user
	WHERE @name_user LIKE nombre_usuario);
	INSERT INTO tb_comment VALUES(@id_user,@Comment,@Id_specimen)
END
select * from tb_comment
EXEC sp_register_comment_user 'v','Soy comentario 2',2
CREATE PROCEDURE sp_getcomments
@id_specimen INT
AS
BEGIN 
SELECT nombre_usuario,Comment,Id_specimen
FROM tb_comment
JOIN tb_user ON tb_comment.ID_user=tb_user.id_usuario
WHERE Id_specimen =@Id_specimen
END
EXEC sp_getcomments 1
select * from tb_user