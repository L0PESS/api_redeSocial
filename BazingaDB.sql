    CREATE DATABASE BAZINGA;
    GO
    USE BAZINGA;
    GO
    CREATE TABLE dbo.Usuario(
        Id INT IDENTITY(1,1) PRIMARY KEY,
        Nome NVARCHAR(100) NOT NULL,
        Email NVARCHAR(150) UNIQUE NOT NULL,
        SenhaHash VARCHAR(255) NOT NULL, 
    );
    GO
    CREATE TABLE dbo.Post(
        Id INT IDENTITY(1,1) PRIMARY KEY,
        Usuario_Id INT NOT NULL,
        Texto NVARCHAR(255) NULL,
        ImagemUrl VARCHAR(500) NOT NULL,
        CriadoEm DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(),
        CONSTRAINT FK_Post_Usuario FOREIGN KEY (Usuario_Id) REFERENCES Usuario(Id)
    );
    GO
        CREATE TABLE dbo.Curtida(
        Usuario_Id INT NOT NULL,
        Post_Id INT NOT NULL,
        CriadoEm DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(),
        CONSTRAINT PK_Curtida PRIMARY KEY (Usuario_Id,Post_Id),
        CONSTRAINT FK_Curtida_Usuario FOREIGN KEY (Usuario_Id) REFERENCES Usuario(Id),
        CONSTRAINT FK_Curtida_Post FOREIGN KEY (Post_Id) REFERENCES Post(Id)
    );
    GO
    CREATE TABLE dbo.Comentario(
        Id INT IDENTITY(1,1)PRIMARY KEY,
        Usuario_Id INT NOT NULL,
        Post_Id INT NOT NULL,
        Texto NVARCHAR(500) NOT NULL,
        CriadoEm DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(),
        CONSTRAINT FK_Comentario_Usuario FOREIGN KEY (Usuario_Id) REFERENCES Usuario(Id),
        CONSTRAINT FK_Comentario_Post FOREIGN KEY (Post_Id) REFERENCES Post(Id)
    );
    GO



