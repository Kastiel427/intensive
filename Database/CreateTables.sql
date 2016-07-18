use GutyrchikIntensive
go
create table Projects
(
	ProjectID int primary key not null,
	ProjectName varchar(30) not null
)
go
create table Tasks
(
	TaskID int primary key not null,
	TaskName varchar(30) not null,
	Specification varchar(300) not null,
)
go
create table [Tasks in projects]
(
	ProjectID int not null,
	TaskID int not null,
	Closed varchar(3) not null,
	Deadline datetime,

	constraint PK_TaskInProjects primary key (ProjectID, TaskID),
	constraint Actual_Deadline check (Deadline > GetDate()),
	constraint FK_TasksInProjects_Project foreign key (ProjectID) references Projects(ProjectID),
	constraint FK_TasksInProjects_Tasks foreign key (TaskID) references Tasks(TaskID)
)
go
create table Tags
(
	TagID int primary key not null,
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