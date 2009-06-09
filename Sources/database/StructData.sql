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
	StudentID                 int ,
		
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
	Name		nvarchar(50) 
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

INSERT INTO	Term  VALUES ('9-1-2006','12-31-2006',N'Học kỳ 1')
INSERT INTO	Term  VALUES ('1-1-2007','6-30-2007',N'Học kỳ 2')
INSERT INTO	Term  VALUES ('9-1-2007','12-31-2007',N'Học kỳ 3')
INSERT INTO	Term  VALUES ('1-1-2008','6-30-2008',N'Học kỳ 4')
INSERT INTO	Term  VALUES ('9-1-2008','12-31-2008',N'Học kỳ 5')
INSERT INTO	Term  VALUES ('1-1-2009','6-30-2009',N'Học kỳ 6')

INSERT INTO Subject VALUES(N'Công cụ và môi trường pt phần mềm')
INSERT INTO Subject VALUES(N'Nhập môn kiểm chứng phần mềm')
INSERT INTO Subject VALUES(N'Quản lý cấu hình phần mềm')
INSERT INTO Subject VALUES(N'Quản lý đề án phần mềm')
INSERT INTO Subject VALUES(N'Đặc tả hình thức')
INSERT INTO Subject VALUES(N'Các công nghệ lập trình hiện đại')

INSERT INTO STUDENT VALUES(0612513,N'Đỗ Minh Tuấn','fcmtuan@gmail.com','123456')
INSERT INTO STUDENT VALUES(0612557,N'Phạm Thế Vinh','vinhpham.it@gmail.com','123456')
INSERT INTO STUDENT VALUES(0612568,N'Nguyễn Trần Vọng ','thienlong24@gmail.com','123456')
INSERT INTO STUDENT VALUES(0612548,N'Lê Văn Vang','lvvang78@yahoo.com','123456')
INSERT INTO STUDENT VALUES(0612564,N'Võ Quang Việt','littleboyfriend@gmail.com','123456')

select * from opensubject

INSERT INTO OpenSubject VALUES(8,1)
INSERT INTO OpenSubject VALUES(8,2)
INSERT INTO OpenSubject VALUES(8,3)
INSERT INTO OpenSubject VALUES(8,4)
INSERT INTO OpenSubject VALUES(8,5)
INSERT INTO OpenSubject VALUES(8,6)


select * from OpenSubject
INSERT INTO STUDY VALUES(0612513,1)
INSERT INTO STUDY VALUES(0612557,1)
INSERT INTO STUDY VALUES(0612568,1)
INSERT INTO STUDY VALUES(0612548,1)
INSERT INTO STUDY VALUES(0612564,1)

INSERT INTO STUDY VALUES(0612513,2)
INSERT INTO STUDY VALUES(0612557,2)
INSERT INTO STUDY VALUES(0612568,2)
INSERT INTO STUDY VALUES(0612548,2)
INSERT INTO STUDY VALUES(0612564,2)


INSERT INTO STUDY VALUES(0612513,3)
INSERT INTO STUDY VALUES(0612557,3)
INSERT INTO STUDY VALUES(0612568,3)
INSERT INTO STUDY VALUES(0612548,3)
INSERT INTO STUDY VALUES(0612564,3)


INSERT INTO STUDY VALUES(0612513,4)
INSERT INTO STUDY VALUES(0612557,4)
INSERT INTO STUDY VALUES(0612568,4)
INSERT INTO STUDY VALUES(0612548,4)
INSERT INTO STUDY VALUES(0612564,4)

INSERT INTO STUDY VALUES(0612513,5)
INSERT INTO STUDY VALUES(0612557,5)
INSERT INTO STUDY VALUES(0612568,5)
INSERT INTO STUDY VALUES(0612548,5)
INSERT INTO STUDY VALUES(0612564,5)


INSERT INTO STUDY VALUES(0612513,6)
INSERT INTO STUDY VALUES(0612557,6)
INSERT INTO STUDY VALUES(0612568,6)
INSERT INTO STUDY VALUES(0612548,6)
INSERT INTO STUDY VALUES(0612564,6)

INSERT INTO DEADLINE VALUES(N'Nộp bài use case công cụ','6-15-2009',1)
INSERT INTO DEADLINE VALUES(N'Nộp bài J2ME','7-5-2009',6)
INSERT INTO DEADLINE VALUES(N'Nộp bài Đặc tả hình thức','6-15-2009',5)
INSERT INTO DEADLINE VALUES(N'Nộp bài Kiểm chứng','6-14-2009',2)

INSERT INTO THREAD VALUES(N'Xin gia hạn deadline',N'Vì thời gian quá gấp mong thầy dời deadline ngày 15/6/2009 sang ngày 20/6/2009','6-14-2009',1,0612513)
INSERT INTO THREAD VALUES(N'Xin thầy nói rõ về cách thức nộp bài',N'Thầy nói rõ hơn về cách tổ chức thư mục trong đồ án đặc tả','6-12-2009',5,0612564)
INSERT INTO THREAD VALUES(N'Thầy cho biết nội dung thi học kỳ',N'Thầy cho em biết nội dung ôn tập của môn Kiểm chứng','6-14-2009',2,0612557)
INSERT INTO THREAD VALUES(N'Nội dung đồ án J2ME',N'Đồ án môn này có được phép sử dụng các dll có sẵn hay không','6-14-2009',6,0612568)


INSERT INTO REPLYTHREAD VALUES(N'Mong thầy đồng ý gia hạn, vì chúng em còn quá nhiều môn thi.','6-15-2009',2,0612557)
INSERT INTO REPLYTHREAD VALUES(N'Môn này mình nghe nói phải học theo slide và nội dung thầy giảng trên lớp','6-15-2009',4,0612568)
INSERT INTO REPLYTHREAD VALUES(N'Bạn được sử dụng dll có sẵn nhưng phải ghi nguồn tham khảo nhé','6-15-2009',5,0612568)
INSERT INTO REPLYTHREAD VALUES(N'Đồ án này bạn nộp đĩa cd và tài liệu tham khảo để được vấn đáp','6-13-2009',3,0612564)

