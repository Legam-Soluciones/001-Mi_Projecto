SELECT DB_NAME() AS NombreBD;

SELECT @@SERVERNAME AS NombreServidor;
USE BugTrackerDB;
GO

SELECT name, type_desc FROM sys.database_principals;

SELECT DB_NAME(database_id) AS BaseDatos, login_name, client_net_address
FROM sys.dm_exec_sessions
JOIN sys.dm_exec_connections ON sys.dm_exec_sessions.session_id = sys.dm_exec_connections.session_id
WHERE DB_NAME(database_id) = 'BugTrackerDB';

SELECT name, type_desc, create_date 
FROM sys.sql_logins;

SELECT SUSER_NAME() AS UsuarioActual;
USE BugTrackerDB;

SELECT dp.name AS NombreUsuario, dp.type_desc AS TipoUsuario, 
       dp.create_date, dp.modify_date
FROM sys.database_principals dp
WHERE dp.type IN ('S', 'U', 'G'); 

SELECT SYSTEM_USER AS UsuarioWindows, 
       SUSER_NAME() AS UsuarioSQLServer,
       ORIGINAL_LOGIN() AS UsuarioOriginal;

ALTER LOGIN sa WITH PASSWORD = '@LgcmjnancYCS_#$%12/21';

SELECT * FROM sys.dm_exec_sessions WHERE is_user_process = 1;

SELECT name FROM sys.sql_logins;

SELECT SUSER_NAME();

USE BugTrackerDB;
SELECT * FROM sys.database_principals;

USE BugTrackerDB;
SELECT * FROM sys.database_principals;



SELECT * FROM Users;
SELECT * FROM Tickets;
SELECT * FROM Comments;


INSERT INTO Users (Username, Email, CreatedAt)
VALUES 
('LuisG', 'luisg@example.com', GETDATE()),
('Admin', 'admin@example.com', GETDATE());


SELECT * FROM Users;

INSERT INTO Users (Username, Email, CreatedAt)
VALUES ('LuisG', 'luisg@example.com', GETDATE());

SELECT * FROM Tickets;

INSERT INTO Tickets (Title, Description, Status, UserId, CreatedAt)
VALUES ('Bug en login', 'Ya se puede autenticar', 'Open', 2, GETDATE());

SELECT * FROM Users WHERE Id = 2;

SELECT DB_NAME() AS NombreBD;

SELECT @@SERVERNAME AS NombreServidor;
USE BugTrackerDB;
GO

SELECT name, type_desc FROM sys.database_principals;

SELECT DB_NAME(database_id) AS BaseDatos, login_name, client_net_address
FROM sys.dm_exec_sessions
JOIN sys.dm_exec_connections ON sys.dm_exec_sessions.session_id = sys.dm_exec_connections.session_id
WHERE DB_NAME(database_id) = 'BugTrackerDB';

SELECT name, type_desc, create_date 
FROM sys.sql_logins;

SELECT SUSER_NAME() AS UsuarioActual;
USE BugTrackerDB;

SELECT dp.name AS NombreUsuario, dp.type_desc AS TipoUsuario, 
       dp.create_date, dp.modify_date
FROM sys.database_principals dp
WHERE dp.type IN ('S', 'U', 'G'); 

SELECT SYSTEM_USER AS UsuarioWindows, 
       SUSER_NAME() AS UsuarioSQLServer,
       ORIGINAL_LOGIN() AS UsuarioOriginal;

ALTER LOGIN sa WITH PASSWORD = '@LgcmjnancYCS_#$%12/21';

SELECT * FROM sys.dm_exec_sessions WHERE is_user_process = 1;

