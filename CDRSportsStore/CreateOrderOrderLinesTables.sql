create table [dbo].[Orders] (
[OrderID]	int	identity(1,1) not null,
[Name]		nvarchar (max) null,
[Line1]		nvarchar (max) null,
[Line2]		nvarchar (max) null,
[Line3]		nvarchar (max) null,
[City]		nvarchar (max) null,
[State]		nvarchar (max) null,
[GiftWrap]	bit				not null,
[Dispatched]	bit			not null,
constraint  [PK_dbo.Orders] primary key clustered ([OrderID] asc)
);

create table [dbo].[OrderLines] (
[OrderLineID]	int identity (1,1) not null,
[Quantity]		int not null,
[Product_ProductID]	int null,
[Order_OrderID]		int null,
constraint [PK_dbo.OrderLines] primary key clustered ([OrderLineID] asc),
constraint [FK_dbo.OrderLines_dbo.Products_Product_ProductID] foreign key ([Product_ProductID]) references [dbo].[Products] ([ProductID]),
constraint [FK_dbo.OrderLines_dbo.Orders_Order_OrderID] foreign key ([Order_OrderID]) references [dbo].[Orders] ([OrderID])
);

