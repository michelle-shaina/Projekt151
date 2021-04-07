
use Projekt151;

create table Kategorie (
	KategorieId int identity not null primary key,
	KategorieName varchar(50) not null,
	Beschreibung varchar(MAX)
);

create table Stadt (
	StadtId int identity not null primary key,
	StadtName varchar(150) not null,
);

create Table Mitarbeiter (
	MitarbeiterId int identity not null primary key,
	MitarbeiterName varchar(150) not null,
	StadtId int not null,
	Password varchar(MAX),
	RoleId int,
	Foreign key(StadtId) references Stadt(StadtId)
);

create table Tasks (
	TaskId int identity not null primary key,
	TaskName varchar(150) not null,
	Beschreibung varchar(MAX),
	IsDone bit
);

create table Projekt (
	ProjektId int identity not null primary key,
	ProjektName varchar(150) not null,
	Beschreibung varchar(MAX),
	StartDate varchar(20),
	EndDate varchar(20),
	IsGoing bit,
	KategorieId int,
	Foreign key(KategorieId) references Kategorie(KategorieId),
)

create table ProjektToTask (
	ProjektId int not null,
	TaskId int not null,
	ProjectToTaskId int identity not null primary key (ProjektId, TaskId),
	Foreign key(ProjektId) references Projekt(ProjektId),
	Foreign key(TaskId) references Tasks(TaskId)
)

create table ProjektToMitarbeiter (
	ProjektId int not null,
	MitarbeiterId int not null,
	ProjectToMitarbeiterId int identity not null primary key (ProjektId, MitarbeiterId)
	Foreign key(ProjektId) references Projekt(ProjektId),
	Foreign key(MitarbeiterId) references Mitarbeiter(MitarbeiterId)
)

create table Role (
	RoleId int identity not null primary key,
	RoleName varchar(50) not null,
)

insert into Tasks (TaskName, Beschreibung, IsDone)
values ('Einkaufen','Snacks f�r die Sitzung',0);
insert into Role (RoleName) values ('Admin');
insert into Role (RoleName) values ('User');
insert into Stadt(StadtName) values ('Lenzburg');
insert into Kategorie(KategorieName, Beschreibung) values ('Administratives', 'Admin Stuff');
insert into Mitarbeiter(MitarbeiterName, StadtId, Password, RoleId) values ('Michelle', 1,'1234',1);
insert into Projekt (ProjektName, Beschreibung, StartDate, EndDate, IsGoing, KategorieId) values ('mein erstes Projekt', 'das erste Projekt', '01.02.2020', '01.01.2021', 1, 1);
insert into ProjektToTask(ProjektId, TaskId) values (1,1);
insert into ProjektToMitarbeiter(ProjektId, MitarbeiterId) values (1, 1);
