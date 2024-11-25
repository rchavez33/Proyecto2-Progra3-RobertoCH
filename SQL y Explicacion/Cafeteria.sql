

-- Crear la base de datos
CREATE DATABASE Cafeteria;

-- Usar la base de datos
USE Cafeteria;

-- Crear la tabla Login
CREATE TABLE Login (
    UsuarioId INT PRIMARY KEY NOT NULL, -- ID autoincremental
    Usuario VARCHAR(50) NOT NULL,           -- Nombre de usuario
    Clave VARCHAR(50) NOT NULL              -- Contraseña
);

-- Insertar datos en la tabla Login
INSERT INTO Login (UsuarioId, Usuario, Clave )
VALUES
(100, 'Pedro', '123'),
(200, 'Maria', '123')

SELECT Usuario, Clave from Login where Usuario = 'Pedro' and Clave = '123' 

CREATE TABLE Productos (
    Codigo INT PRIMARY KEY NOT NULL, -- Campo autogenerado y clave primaria
    Nombre VARCHAR(100) NOT NULL,         -- Nombre del producto, obligatorio
    Precio DECIMAL NOT NULL         -- Precio del producto con decimales
)

INSERT INTO Productos (Codigo, Nombre, Precio)
VALUES 
(10, 'Café', 2.50),
(20, 'Té', 1.75),
(30, 'Sandwich', 4.00);

-- Crear la tabla Empleados
CREATE TABLE Empleados (
    EmpleadoID INT PRIMARY KEY, -- Llave primaria no autogenerada
    Nombre VARCHAR(50) NOT NULL, -- Campo obligatorio
    ApellidoPaterno VARCHAR(50) NOT NULL, -- Campo obligatorio
    ApellidoMaterno VARCHAR(50) NOT NULL, -- Campo obligatorio
    Email VARCHAR(100) NOT NULL -- Campo obligatorio
);

INSERT INTO Empleados (EmpleadoID, Nombre, ApellidoPaterno, ApellidoMaterno, Email)
VALUES 
(1001, 'Juan', 'Pérez', 'López', 'juan.perez@gmail.com'),
(1002, 'María', 'Rodríguez', 'García', 'maria.rodriguez@gmail.com'),
(1003, 'Carlos', 'Hernández', 'Martínez', 'carlos.hernandez@gmail.com'),
(1004, 'Ana', 'Gómez', 'Fernández', 'ana.gomez@gmail.com'),
(1005, 'Luis', 'Díaz', 'Ramírez', 'luis.diaz@gmail.com');



--Procedimientos de almacenado
-----------------
--Tabla Productos
-----------------

--Lista Productos

--Crear
CREATE PROCEDURE AgregarProducto
	@Codigo INT,
    @Nombre VARCHAR(100),
    @Precio DECIMAL
AS
BEGIN
    BEGIN TRY
        INSERT INTO Productos (Codigo, Nombre, Precio)
        VALUES (@Codigo, @Nombre, @Precio);

        PRINT 'Producto agregado exitosamente.';
    END TRY
    BEGIN CATCH
        PRINT 'Error al agregar el producto: ' + ERROR_MESSAGE();
    END CATCH
END;


--Borrar
CREATE PROCEDURE BorrarProducto
    @Codigo INT
AS
BEGIN
    BEGIN TRY
        IF EXISTS (SELECT 1 FROM Productos WHERE Codigo = @Codigo)
        BEGIN
            DELETE FROM Productos
            WHERE Codigo = @Codigo;

            PRINT 'Producto borrado exitosamente.';
        END
        ELSE
        BEGIN
            PRINT 'El producto no existe.';
        END
    END TRY
    BEGIN CATCH
        PRINT 'Error al borrar el producto: ' + ERROR_MESSAGE();
    END CATCH
END;


--Modificar
CREATE PROCEDURE ModificarProducto
    @Codigo INT,
    @Nombre VARCHAR(100),
    @Precio DECIMAL
AS
BEGIN
    BEGIN TRY
        IF EXISTS (SELECT 1 FROM Productos WHERE Codigo = @Codigo)
        BEGIN
            UPDATE Productos
            SET Nombre = @Nombre, Precio = @Precio
            WHERE Codigo = @Codigo;

            PRINT 'Producto modificado exitosamente.';
        END
        ELSE
        BEGIN
            PRINT 'El producto no existe.';
        END
    END TRY
    BEGIN CATCH
        PRINT 'Error al modificar el producto: ' + ERROR_MESSAGE();
    END CATCH
END;


--Consulta
CREATE PROCEDURE ConsultarProductos
AS
BEGIN
    SELECT * FROM Productos;
END;


------------------------
--Tabla Login (Usuarios)
------------------------

--Lista usuarios
create procedure ListaUsuario
as
	begin
		select usuarioid, usuario, clave from Login
	end

exec ListaUsuario

--Crear
CREATE PROCEDURE AgregarUsuario
    @UsuarioId INT,
    @Usuario VARCHAR(50),
    @Clave VARCHAR(50)
AS
BEGIN
    BEGIN TRY
        IF NOT EXISTS (SELECT 1 FROM Login WHERE UsuarioId = @UsuarioId)
        BEGIN
            INSERT INTO Login (UsuarioId, Usuario, Clave)
            VALUES (@UsuarioId, @Usuario, @Clave);

            PRINT 'Usuario agregado exitosamente.';
        END
        ELSE
        BEGIN
            PRINT 'El UsuarioId ya existe.';
        END
    END TRY
    BEGIN CATCH
        PRINT 'Error al agregar el usuario: ' + ERROR_MESSAGE();
    END CATCH
END;


--Borrar
CREATE PROCEDURE BorrarUsuario
    @UsuarioId INT
AS
BEGIN
    BEGIN TRY
        IF EXISTS (SELECT 1 FROM Login WHERE UsuarioId = @UsuarioId)
        BEGIN
            DELETE FROM Login
            WHERE UsuarioId = @UsuarioId;

            PRINT 'Usuario borrado exitosamente.';
        END
        ELSE
        BEGIN
            PRINT 'El usuario no existe.';
        END
    END TRY
    BEGIN CATCH
        PRINT 'Error al borrar el usuario: ' + ERROR_MESSAGE();
    END CATCH
END;

--Modificar
CREATE PROCEDURE ModificarUsuario
    @UsuarioId INT,
    @Usuario VARCHAR(50),
    @Clave VARCHAR(50)
AS
BEGIN
    BEGIN TRY
        IF EXISTS (SELECT 1 FROM Login WHERE UsuarioId = @UsuarioId)
        BEGIN
            UPDATE Login
            SET Usuario = @Usuario, Clave = @Clave
            WHERE UsuarioId = @UsuarioId;

            PRINT 'Usuario modificado exitosamente.';
        END
        ELSE
        BEGIN
            PRINT 'El usuario no existe.';
        END
    END TRY
    BEGIN CATCH
        PRINT 'Error al modificar el usuario: ' + ERROR_MESSAGE();
    END CATCH
END;


--Consultar
CREATE PROCEDURE ConsultarUsuario
    @UsuarioId INT -- ID del usuario que queremos buscar
AS
BEGIN
    SET NOCOUNT ON;

    -- Buscar el usuario por su ID
    SELECT UsuarioId, Usuario, Clave
    FROM Login
    WHERE UsuarioId = @UsuarioId;

    -- Opcional: Si no existe el usuario, puedes devolver un mensaje:
    IF @@ROWCOUNT = 0
    BEGIN
        RAISERROR('No se encontró ningún usuario con el ID proporcionado.', 16, 1);
    END
END;

-----------------
--Tabla Empleados
-----------------
--Crear
CREATE PROCEDURE CrearEmpleado
    @EmpleadoID INT,
    @Nombre VARCHAR(50),
    @ApellidoPaterno VARCHAR(50),
    @ApellidoMaterno VARCHAR(50),
    @Email VARCHAR(100)
AS
BEGIN
    BEGIN TRY
        INSERT INTO Empleados (EmpleadoID, Nombre, ApellidoPaterno, ApellidoMaterno, Email)
        VALUES (@EmpleadoID, @Nombre, @ApellidoPaterno, @ApellidoMaterno, @Email);

        PRINT 'Empleado creado correctamente.';
    END TRY
    BEGIN CATCH
        PRINT 'Error al crear el empleado: ' + ERROR_MESSAGE();
    END CATCH
END;

--Borrar
CREATE PROCEDURE BorrarEmpleado
    @EmpleadoID INT
AS
BEGIN
    BEGIN TRY
        DELETE FROM Empleados WHERE EmpleadoID = @EmpleadoID;

        PRINT 'Empleado eliminado correctamente.';
    END TRY
    BEGIN CATCH
        PRINT 'Error al eliminar el empleado: ' + ERROR_MESSAGE();
    END CATCH
END;

--Modificar
CREATE PROCEDURE ModificarEmpleado
    @EmpleadoID INT,
    @Nombre VARCHAR(50),
    @ApellidoPaterno VARCHAR(50),
    @ApellidoMaterno VARCHAR(50),
    @Email VARCHAR(100)
AS
BEGIN
    BEGIN TRY
        UPDATE Empleados
        SET Nombre = @Nombre,
            ApellidoPaterno = @ApellidoPaterno,
            ApellidoMaterno = @ApellidoMaterno,
            Email = @Email
        WHERE EmpleadoID = @EmpleadoID;

        PRINT 'Empleado actualizado correctamente.';
    END TRY
    BEGIN CATCH
        PRINT 'Error al modificar el empleado: ' + ERROR_MESSAGE();
    END CATCH
END;

--Consultar
CREATE PROCEDURE ConsultarEmpleado
    @EmpleadoID INT
AS
BEGIN
    BEGIN TRY
        SELECT EmpleadoID, Nombre, ApellidoPaterno, ApellidoMaterno, Email
        FROM Empleados
        WHERE EmpleadoID = @EmpleadoID;

        -- Si deseas devolver un mensaje cuando no se encuentra el empleado:
        IF @@ROWCOUNT = 0
        BEGIN
            PRINT 'No se encontró ningún empleado con el ID proporcionado.';
        END
    END TRY
    BEGIN CATCH
        PRINT 'Error al consultar el empleado: ' + ERROR_MESSAGE();
    END CATCH
END;


----------------------------------
--Fin Procedimientos de Almacenado
----------------------------------

Select * from Productos