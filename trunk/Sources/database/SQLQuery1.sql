-- create database
CREATE DATABASE ACCESSMOODLE ON PRIMARY
	(NAME= 'ACCESSMOODLE',
	 FILENAME= 'C:\Users\QuangViet\Desktop\CCMT\database\ACCESSMOODLE_DB.mdf',
	 SIZE= 2MB, MAXSIZE= unlimited, FILEGROWTH= 1MB)
LOG ON
	(NAME= 'ACCESSMOODLE_log',
	 FILENAME= 'C:\Users\QuangViet\Desktop\CCMT\database\ACCESSMOODLE_log.ldf',
	 SIZE= 2MB, MAXSIZE= unlimited, FILEGROWTH= 10%)

----------------------------------------------- STRUCTURES ------------------------------------------
-- create Student table
create table Student 
(
	StudentID                 int   IDENTITY,
		
	Name                      nvarchar(50) not null,
	
	Email                     char(50),

	Password                  char(20)
	
)

create table Term
(
	TermID		int IDENTITY,
	StartDay	datetime,
	FinishDay	datetime,
	Name		nvarchar(50)
)

create table Subject
(
	SubjectID	int IDENTITY,		
	Name		nvarchar(20) 
)

create table OpenSubject
(
	OpenSubjectID	int IDENTITY,	
	TermID	int ,
	SubjectID	int
)
create table Thread
(
	ThreadID	int identity,
	Title		 nvarchar(50) not null,
	Content		 nvarchar(max),
	Time		 datetime,
	OpenSubjectID    int,
	StudentID    int 
)

create table Deadline
(		
	Title                    nvarchar(50) not null,
	Time                     datetime not null,
	OpenSubjectID                int not null
)

create table Study
(
	StudentID	int not null,
	OpenSubjectID	int not null,
)

create table ReplyThread
(
	ReplyThreadID int identity,
	Content	nvarchar(max),
	Time	datetime, 
	ThreadID int ,
	StudentID	int
)
--primary key
ALTER TABLE Student	 ADD CONSTRAINT PK_Student	PRIMARY KEY (StudentID)

ALTER TABLE Term     ADD CONSTRAINT PK_Term	PRIMARY KEY (TermID)

ALTER TABLE Subject  ADD CONSTRAINT PK_Subject	PRIMARY KEY (SubjectID)

ALTER TABLE OpenSubject  ADD CONSTRAINT PK_OpenSubject	PRIMARY KEY (OpenSubjectID)

ALTER TABLE Thread   ADD CONSTRAINT  PK_Thread	PRIMARY KEY (ThreadID)

ALTER TABLE Deadline ADD CONSTRAINT PK_Deadline	PRIMARY KEY (Time,OpenSubjectID)

ALTER TABLE Study    ADD CONSTRAINT PK_Study	PRIMARY KEY (StudentID,OpenSubjectID)

ALTER TABLE ReplyThread   ADD CONSTRAINT PK_ReaplyThread	PRIMARY KEY (ReplyThreadID) 

-- foreign key

ALTER TABLE OpenSubject  ADD CONSTRAINT FK_Term_OpenSubject FOREIGN KEY (TermID) REFERENCES Term(TermID)
ALTER TABLE OpenSubject ADD CONSTRAINT FK_Subject_OpenSubject FOREIGN KEY (SubjectID) REFERENCES Subject(SubjectID)

ALTER TABLE Thread  ADD CONSTRAINT FK_Thread_Student FOREIGN KEY (StudentID)  REFERENCES Student(StudentID)
ALTER TABLE Thread  ADD CONSTRAINT FK_Thread_OpenSubject FOREIGN KEY (OpenSubjectID) REFERENCES OpenSubject(OpenSubjectID)

ALTER TABLE Deadline  ADD CONSTRAINT FK_Deadline_OpenSubject FOREIGN KEY (OpenSubjectID) REFERENCES OpenSubject(OpenSubjectID)

ALTER TABLE Study  ADD CONSTRAINT FK_Study_Student FOREIGN KEY (StudentID) REFERENCES Student(StudentID)
ALTER TABLE Study  ADD CONSTRAINT FK_Study_OpenSubject FOREIGN KEY (OpenSubjectID) REFERENCES OpenSubject(OpenSubjectID)

ALTER TABLE ReplyThread	ADD CONSTRAINT FK_ReplyThread_Thread	FOREIGN KEY (ThreadID) REFERENCES	Thread(ThreadID)
ALTER TABLE ReplyThread	ADD CONSTRAINT FK_ReplyThread_Student	FOREIGN KEY (StudentID) REFERENCES	Student(StudentID)
