-- DROP SCHEMA dbo;

CREATE SCHEMA dbo;
-- felixchococat.dbo.days_of_week definition

-- Drop table

-- DROP TABLE felixchococat.dbo.days_of_week;

CREATE TABLE days_of_week (
	id int IDENTITY(1,1) NOT NULL,
	[day] varchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	CONSTRAINT PK__days_of___3213E83F97330A47 PRIMARY KEY (id),
	CONSTRAINT UQ__days_of___D87793208E32A0AF UNIQUE ([day])
);


-- felixchococat.dbo.semester definition

-- Drop table

-- DROP TABLE felixchococat.dbo.semester;

CREATE TABLE semester (
	id int IDENTITY(1,1) NOT NULL,
	start_date date NULL,
	end_date date NULL,
	description varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	CONSTRAINT PK__semester__3213E83F5233365D PRIMARY KEY (id)
);


-- felixchococat.dbo.users definition

-- Drop table

-- DROP TABLE felixchococat.dbo.users;

CREATE TABLE users (
	id int IDENTITY(1,1) NOT NULL,
	login_id varchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	firstname varchar(25) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	lastname varchar(35) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	student_id varchar(12) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	passcode varchar(35) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	user_role char(7) COLLATE SQL_Latin1_General_CP1_CI_AS DEFAULT 'STUDENT' NOT NULL,
	CONSTRAINT PK__users__3213E83F8DBC25EB PRIMARY KEY (id)
);
ALTER TABLE felixchococat.dbo.users WITH NOCHECK ADD CONSTRAINT user_role_const1 CHECK (([user_role]='PROF' OR [user_role]='STUDENT'));


-- felixchococat.dbo.class definition

-- Drop table

-- DROP TABLE felixchococat.dbo.class;

CREATE TABLE class (
	id int IDENTITY(1,1) NOT NULL,
	department varchar(4) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	number char(4) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[section] char(3) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	prof_id int NULL,
	start_time time(3) NULL,
	end_time time(3) NULL,
	semester_id int NULL,
	name varchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	description varchar(500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	CONSTRAINT PK__class__3213E83FC16B3A9C PRIMARY KEY (id),
	CONSTRAINT FK__class__prof_id__6FE99F9F FOREIGN KEY (prof_id) REFERENCES users(id),
	CONSTRAINT fk_semesterID FOREIGN KEY (semester_id) REFERENCES semester(id)
);


-- felixchococat.dbo.class_days definition

-- Drop table

-- DROP TABLE felixchococat.dbo.class_days;

CREATE TABLE class_days (
	class_id int NOT NULL,
	day_id int NOT NULL,
	CONSTRAINT PK__class_da__55416F2D0B13263F PRIMARY KEY (class_id,day_id),
	CONSTRAINT FK__class_day__class__0B5CAFEA FOREIGN KEY (class_id) REFERENCES class(id) ON DELETE CASCADE,
	CONSTRAINT FK__class_day__day_i__0C50D423 FOREIGN KEY (day_id) REFERENCES days_of_week(id) ON DELETE CASCADE
);


-- felixchococat.dbo.enrollment definition

-- Drop table

-- DROP TABLE felixchococat.dbo.enrollment;

CREATE TABLE enrollment (
	user_id int NULL,
	class_id int NULL,
	CONSTRAINT FK__enrollmen__class__0E6E26BF FOREIGN KEY (class_id) REFERENCES class(id),
	CONSTRAINT FK__enrollmen__user___0D7A0286 FOREIGN KEY (user_id) REFERENCES users(id)
);


-- felixchococat.dbo.question definition

-- Drop table

-- DROP TABLE felixchococat.dbo.question;

CREATE TABLE question (
	id int IDENTITY(1,1) NOT NULL,
	question_text varchar(500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	class_id int NULL,
	CONSTRAINT PK__question__3213E83FA1F5F945 PRIMARY KEY (id),
	CONSTRAINT FK__question__class___3C34F16F FOREIGN KEY (class_id) REFERENCES class(id)
);


-- felixchococat.dbo.quiz definition

-- Drop table

-- DROP TABLE felixchococat.dbo.quiz;

CREATE TABLE quiz (
	id int IDENTITY(1,1) NOT NULL,
	title varchar(30) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	password char(20) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	validate_answers char(1) COLLATE SQL_Latin1_General_CP1_CI_AS DEFAULT 'T' NOT NULL,
	class_id int NULL,
	CONSTRAINT PK__quiz__3213E83F977011AC PRIMARY KEY (id),
	CONSTRAINT UQ__quiz__6E2DBEDEC605EF87 UNIQUE (password),
	CONSTRAINT fk_quiz_classID FOREIGN KEY (class_id) REFERENCES class(id)
);
ALTER TABLE felixchococat.dbo.quiz WITH NOCHECK ADD CONSTRAINT validate_answers_const1 CHECK (([validate_answers]='F' OR [validate_answers]='T'));


-- felixchococat.dbo.quiz_question definition

-- Drop table

-- DROP TABLE felixchococat.dbo.quiz_question;

CREATE TABLE quiz_question (
	quiz_id int NOT NULL,
	question_id int NOT NULL,
	CONSTRAINT PK__quiz_que__AF9C72B84845E5B0 PRIMARY KEY (quiz_id,question_id),
	CONSTRAINT FK__quiz_ques__quest__489AC854 FOREIGN KEY (question_id) REFERENCES question(id) ON DELETE CASCADE,
	CONSTRAINT FK__quiz_ques__quiz___47A6A41B FOREIGN KEY (quiz_id) REFERENCES quiz(id) ON DELETE CASCADE
);


-- felixchococat.dbo.quiz_records definition

-- Drop table

-- DROP TABLE felixchococat.dbo.quiz_records;

CREATE TABLE quiz_records (
	id int IDENTITY(1,1) NOT NULL,
	quiz_id int NULL,
	user_id int NULL,
	ip_address varchar(45) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	submitted datetime NULL,
	correct_answers int NULL,
	quiz_results decimal(5,2) NULL,
	status char(7) COLLATE SQL_Latin1_General_CP1_CI_AS DEFAULT 'ABSENT' NOT NULL,
	CONSTRAINT PK__quiz_rec__3213E83FD3F8B289 PRIMARY KEY (id),
	CONSTRAINT fk_quizrec_id_quiz FOREIGN KEY (quiz_id) REFERENCES quiz(id) ON DELETE CASCADE ON UPDATE CASCADE,
	CONSTRAINT fk_quizrec_userid FOREIGN KEY (user_id) REFERENCES users(id) ON DELETE CASCADE ON UPDATE CASCADE
);
ALTER TABLE felixchococat.dbo.quiz_records WITH NOCHECK ADD CONSTRAINT validate_status_const1 CHECK (([status]='LATE' OR [status]='ABSENT' OR [status]='EXCUSED' OR [status]='PRESENT'));


-- felixchococat.dbo.answer definition

-- Drop table

-- DROP TABLE felixchococat.dbo.answer;

CREATE TABLE answer (
	id int IDENTITY(1,1) NOT NULL,
	question_id int NOT NULL,
	answer_text varchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	correct_value char(1) COLLATE SQL_Latin1_General_CP1_CI_AS DEFAULT 'F' NOT NULL,
	CONSTRAINT PK__answer__3213E83F52A35ABB PRIMARY KEY (id),
	CONSTRAINT FK__answer__question__40058253 FOREIGN KEY (question_id) REFERENCES question(id)
);