CREATE TABLE [dbo].[Tarefas]
(
	[Id] INT NULL , 
    [tarefa] NCHAR(30) PRIMARY KEY NOT NULL, 
    [data] NCHAR(20) NOT NULL, 
    [concluida] NCHAR(20) NULL, 
    [descricao] NCHAR(300) NOT NULL
)
