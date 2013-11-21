/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

truncate table Cogs
insert into Cogs ([Name], [Description]) values ('Name 1','Description 1')
insert into Cogs ([Name], [Description]) values ('Name 2','Description 2')
insert into Cogs ([Name], [Description]) values ('Name 3','Description 3')
insert into Cogs ([Name], [Description]) values ('Name 4','Description 4')
insert into Cogs ([Name], [Description]) values ('Name 5','Description 5')
insert into Cogs ([Name], [Description]) values ('Name 6','Description 6')
insert into Cogs ([Name], [Description]) values ('Name 7','Description 7')
insert into Cogs ([Name], [Description]) values ('Name 8','Description 8')
insert into Cogs ([Name], [Description]) values ('Name 9','Description 9')
insert into Cogs ([Name], [Description]) values ('Name 10','Description 10')

truncate table Widgets
insert into Widgets ([Name], [Description]) values ('Name 1','Description 1')
insert into Widgets ([Name], [Description]) values ('Name 2','Description 2')
insert into Widgets ([Name], [Description]) values ('Name 3','Description 3')
insert into Widgets ([Name], [Description]) values ('Name 4','Description 4')
insert into Widgets ([Name], [Description]) values ('Name 5','Description 5')
insert into Widgets ([Name], [Description]) values ('Name 6','Description 6')
insert into Widgets ([Name], [Description]) values ('Name 7','Description 7')
insert into Widgets ([Name], [Description]) values ('Name 8','Description 8')
insert into Widgets ([Name], [Description]) values ('Name 9','Description 9')
insert into Widgets ([Name], [Description]) values ('Name 10','Description 10')

truncate table Sprockets
insert into Sprockets ([Name], [Description]) values ('Name 1','Description 1')
insert into Sprockets ([Name], [Description]) values ('Name 2','Description 2')
insert into Sprockets ([Name], [Description]) values ('Name 3','Description 3')
insert into Sprockets ([Name], [Description]) values ('Name 4','Description 4')
insert into Sprockets ([Name], [Description]) values ('Name 5','Description 5')
insert into Sprockets ([Name], [Description]) values ('Name 6','Description 6')
insert into Sprockets ([Name], [Description]) values ('Name 7','Description 7')
insert into Sprockets ([Name], [Description]) values ('Name 8','Description 8')
insert into Sprockets ([Name], [Description]) values ('Name 9','Description 9')
insert into Sprockets ([Name], [Description]) values ('Name 10','Description 10')
