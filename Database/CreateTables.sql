use GutyrchikIntensive
go
create table Projects
(
	ProjectID int primary key IDENTITY(1,1) not null,
	ProjectName varchar(30) not null
)
go
create table Tasks
(
	ProjectID int not null,
	TaskID int IDENTITY(1,1) not null,
	TaskName varchar(30) not null,
	Specification varchar(300) not null,
	Closed varchar(3) not null,
	Deadline date,

	constraint PK_Tasks primary key (TaskID),
	constraint Actual_Deadline check (Deadline > GetDate()),
	constraint FK_Tasks_Projects foreign key (ProjectID) references Projects(ProjectID),
)
go
create table Tags
(
	TagID int primary key IDENTITY(1,1) not null,
	TagName varchar(30) unique not null 
)
go
create table [Tags in tasks]
(
	TaskID int not null,
	TagID int not null,

	constraint PK_TagInTasks primary key(TaskID, TagID),
	constraint FK_TagsInTasks_Tasks foreign key (TaskID) references Tasks(TaskID),
	constraint FK_TagsInTasks_Tags foreign key (TagID) references Tags(TagID)
)

