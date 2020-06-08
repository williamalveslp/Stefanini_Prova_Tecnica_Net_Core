-- Profile_Type
INSERT INTO Profile_Type(Name, Is_Active, Date_Created, Date_Updated) VALUES (
'Administrador', 1, GETDATE(), GETDATE());
GO
INSERT INTO Profile_Type(Name, Is_Active, Date_Created, Date_Updated) VALUES (
'Financeiro', 1, GETDATE(), GETDATE());
GO
INSERT INTO Profile_Type(Name, Is_Active, Date_Created, Date_Updated) VALUES (
'TI', 1, GETDATE(), GETDATE());
GO
INSERT INTO Profile_Type(Name, Is_Active, Date_Created, Date_Updated) VALUES (
'Marketing', 1, GETDATE(), GETDATE());
GO

-- Task
INSERT INTO Task(Name, Description, Is_Active, Date_Created, Date_Updated) VALUES (
'Manter Planilhas Atualizadas', '', 1, GETDATE(), GETDATE());
GO
INSERT INTO Task(Name, Description, Is_Active, Date_Created, Date_Updated) VALUES (
'Atendimento aos clientes', 'Pessoalmente e por telefone', 1, GETDATE(), GETDATE());
GO
INSERT INTO Task(Name, Description, Is_Active, Date_Created, Date_Updated) VALUES (
'Enviar relatórios semanais', 'Enviar email com relatórios ao final de toda semana referente as Vendas realizadas', 1, GETDATE(), GETDATE());
GO

-- User_System
INSERT INTO User_System(User_Name, Password, Profile_Type_Id, Is_Active, Date_Created, Date_Updated) VALUES (
'NOVOUSUARIO', 'NOVOUSUARIO', 2, 1, GETDATE(), GETDATE());
GO
INSERT INTO User_System(User_Name, Password, Profile_Type_Id, Is_Active, Date_Created, Date_Updated) VALUES (
'TESTE123', 'TESTE123', 3, 1, GETDATE(), GETDATE());
GO
INSERT INTO User_System(User_Name, Password, Profile_Type_Id, Is_Active, Date_Created, Date_Updated) VALUES (
'STEFANINITESTE', 'STEFANINITESTE', 3, 1, GETDATE(), GETDATE());
GO