
create table [ProductsType]
(
	[Id] int not null identity(1, 1) primary key,
	[Type] nvarchar(100) not null  check ([Type] <> N''),

	constraint CK_Format_Type check ([Type] <> '')
);
create table [Positions]
(
	[Id] int not null identity(1, 1) primary key,
	[Name] nvarchar(100) not null unique check ([Name] <> N''),

	constraint CK_Format_PositionName check ([Name] <> '')
);

create table [servicesList]
(
	[Id] int not null identity(1, 1) primary key,
	[Name] nvarchar(100) not null unique check ([Name] <> N''),
	[Price] money not null check ([Price] > 0.0),
	[Time] time not null,
	
	constraint CK_Format_servicesListName check ([Name] <> '')
);

create table [Client]
(
	[Id] int not null identity(1, 1) primary key,
	[FIO] nvarchar(100) not null unique check ([FIO] <> N''),
	[PhoneNumber] int not null,
	[Email] nvarchar(50) not null,
	[DateAdmission] date not null,
	[PostionId] int not null,
);

create table [Schedule]
(
	[Id] int not null identity(1, 1) primary key,
	[BarberId] int not null,
	[FreeDate] date not null,
	[FreeTime] time not null
);

create table [Barbers]
(
	[Id] int not null identity(1, 1) primary key,
	[FIO] nvarchar(100) not null unique check ([FIO] <> N''),
	[Gender] bit not null,
	[PhoneNumber] int not null,
	[Email] nvarchar(50) not null,
	[Birthday] date not null,
	[DateAdmission] date not null,
	[PostionId] int not null,

	constraint CK_Format_BarberFIO check ([FIO] <> ''),
);

create table [ArchiveVisits]
(
	[Id] int not null identity(1, 1) primary key,
	[ClientId] int not null,
	[BarberId] int not null,
	[Date] date not null,
	[Price] money not null,
	[Rating] int not null check ([Rating] between 1 and 5),
	[Feedback] nvarchar(100) not null unique check ([Feedback] <> N''),

	constraint CK_LectureRooms_Rating check (([Rating]>=(1) AND [Rating]<=(5))),
	constraint CK_Format_Feedback check ([Feedback] <> ''),
);
alter table [Barbers]
add foreign key ([PostionId]) references [Positions]([Id]);
go

alter table Schedule
add foreign key ([BarberId]) references [Barbers]([Id]);
go

alter table [ArchiveVisits]
add foreign key ([ClientId]) references [Client]([Id]);
go

alter table [ArchiveVisits]
add foreign key ([BarberId]) references [Barbers]([Id]);
go



