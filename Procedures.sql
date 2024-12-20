USE [Pytania]
GO
/****** Object:  StoredProcedure [dbo].[getRandomTwo]    Script Date: 05.12.2024 11:52:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[getRandomTwo] as
begin
declare @res table (id int)
insert into @res select top 2 id from Pytanie where [czyWolne] = 0 order by NEWID();
update Pytanie set czyWolne = 1 where id in (select id from @res);
select * from Pytanie where id in (select id from @res);
end


exec getRandomTwo

Create procedure [dbo].[setCzyWolneOnZero] as
begin
update Pytanie set czyWolne = 0;
end

exec [setCzyWolneOnZero]