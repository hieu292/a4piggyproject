--create database DeadlineManager2
--drop  database DeadlineManager
create table Subject
(
	ID int IDENTITY, 
	Name nvarchar(40) not null,
	primary key (ID)
)

create table Deadline
(
	ID int IDENTITY, 
	Title nvarchar (100) not null,
	Time datetime not null,
	SubjectID int not null, 
	primary key (ID) 
)

create table Student
(
	ID int IDENTITY,
	Name nvarchar(40) not null,
	Email nvarchar(50) not null,
	Password nvarchar (40) not null,
	primary key (ID)
)

create table Study
(
	StudentID int,
	SubjectID int
)

create table Thread
(
	ID int IDENTITY,
	Title nvarchar (40) not null,
	Content nvarchar (40) not null,
	Time datetime not null,
	SubjectID int,
	StudentID int,
	primary key (ID)
)

---------------------------------------------------------------------
ALTER TABLE Deadline  
ADD CONSTRAINT FK_Deadline_Subject  
FOREIGN KEY (SubjectID)  
REFERENCES Subject(ID)

ALTER TABLE Study  
ADD CONSTRAINT FK_Study_Student  
FOREIGN KEY (StudentID)  
REFERENCES Student(ID)

ALTER TABLE Study  
ADD CONSTRAINT FK_Study_Subject  
FOREIGN KEY (SubjectID)  
REFERENCES Subject(ID)

ALTER TABLE Thread  
ADD CONSTRAINT FK_Thread_Student  
FOREIGN KEY (StudentID)  
REFERENCES Student(ID)

ALTER TABLE Thread  
ADD CONSTRAINT FK_Thread_Subject  
FOREIGN KEY (SubjectID)  
REFERENCES Subject(ID)
---------------------------------------------------------------------

insert into Subject values(N'ĐAPM')
insert into Subject values(N'XML và Ứng dụng')
insert into Subject values(N'Công nghệ web')
insert into Subject values(N'Công cụ và MTPTPM')
insert into Subject values(N'Java')

---------------------------------------------------------------------

insert into Deadline values(N'Đồ án Công nghệ web','2/25/2009',1)
insert into Deadline values(N'Đồ án XML và ứng dụng','5/26/2009',2)
insert into Deadline values(N'Đồ án Công cụ và MTPTPM','1/14/2009',3)
insert into Deadline values(N'Đồ án Công nghệ web','5/21/2009',4)
insert into Deadline values(N'Đồ án ĐAPM','6/16/2009',5)

---------------------------------------------------------------------

insert into Student values(N'Đỗ Minh Tuấn','fcmtuan@gmail.com',123)
insert into Student values(N'Võ Quang Việt','vqviet@gmail.com',123)
insert into Student values(N'Lê Văn Vang','vangvl87@gmail.com',123)
insert into Student values(N'Nguyễn Trần Vọng','thienlong@gmail.com',123)
insert into Student values(N'Phạm Thế Vinh','vinhpham@gmail.com',123)

---------------------------------------------------------------------

insert into Study values(1,1)
insert into Study values(1,2)
insert into Study values(1,3)
insert into Study values(1,4)
insert into Study values(1,5)

insert into Study values(2,1)
insert into Study values(2,2)
insert into Study values(2,3)
insert into Study values(2,4)
insert into Study values(2,5)

insert into Study values(3,1)
insert into Study values(3,2)
insert into Study values(3,3)
insert into Study values(3,4)
insert into Study values(3,5)

insert into Study values(4,1)
insert into Study values(4,2)
insert into Study values(4,3)
insert into Study values(4,4)
insert into Study values(4,5)

insert into Study values(5,1)
insert into Study values(5,2)
insert into Study values(5,3)
insert into Study values(5,4)
insert into Study values(5,5)
---------------------------------------------------------------------

insert into Thread values(N'Title1','Content1', '3/6/2009',1,2)
insert into Thread values(N'Title1','Content2', '1/7/2009',2,3)
insert into Thread values(N'Title1','Content3', '8/8/2009',1,3)
insert into Thread values(N'Title1','Content4', '6/12/2009',4,1)
insert into Thread values(N'Title1','Content5', '1/25/2009',5,4)
insert into Thread values(N'Title2','Content1', '3/30/2009',3,5)
insert into Thread values(N'Title2','Content2', '3/26/2009',1,1)
insert into Thread values(N'Title2','Content3', '4/5/2009',2,2)