USE warehouse_db
go

CREATE procedure dbo.selectArticlesCode

as
	select Code as 'Article code' from Articles;
return;
go

CREATE procedure insertOrder
(
	@date datetime,
	@name nchar(30),
	@surname nchar(30),
	@address nchar(40),
	@articlecode nchar(10),
	@article_amount int,
	@delivery_way nchar(20)
)

as
begin
	insert into orders (Date,Name,Surname,Address,ArticleID,Article_amount,Delivery_way)
		values (@date,@name,@surname,@address,(select id from Articles where code=@articlecode),@article_amount,@delivery_way);
end
return;
go

create procedure selectArticleAmount
(
	@code nchar(10)
)

as
	select Amount from Articles where id=(select id from Articles where Code=@code);
return;
go

create procedure updateArticleAmount
(
	@code nchar(10),
	@amount int
)

as
	update Articles set Amount=@amount where Code=@code;
return;
go

create procedure collectAvailableArticles
as
select Name, Code, Amount from Articles where Amount>0;

go