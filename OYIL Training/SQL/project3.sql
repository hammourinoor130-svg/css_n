
CREATE DATABASE CourseRegistrationDB;
USE CourseRegistrationDB;
CREATE TABLE Students (
    Student_ID INT PRIMARY KEY identity,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    Email VARCHAR(100) UNIQUE,
    PhoneNumber VARCHAR(20),
    EnrollmentDate DATE
);

CREATE TABLE Instructors (
    InstructorID INT PRIMARY KEY identity,
    Name VARCHAR(100) NOT NULL,
    Department VARCHAR(50),
    Email VARCHAR(100)
);

CREATE TABLE Departments (
    Department_ID INT PRIMARY KEY identity,
    DepartmentName VARCHAR(100) NOT NULL
);

CREATE TABLE Courses (
    CourseID INT PRIMARY KEY identity,
    CourseName VARCHAR(100) NOT NULL,
    InstructorID INT,
    Credits INT,
    Department VARCHAR(50),
    FOREIGN KEY (InstructorID) REFERENCES Instructors(InstructorID)
);


CREATE TABLE Enrollments (
    Enrollment_ID INT PRIMARY KEY identity,
    StudentID INT,
    CourseID INT,
    EnrollmentDate DATE,
    Status VARCHAR(20),
    FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
    FOREIGN KEY (CourseID) REFERENCES Courses(CourseID)
);

CREATE TABLE CourseRequirements (
    CourseID INT,
    PrerequisiteCourseID INT,
    FOREIGN KEY (CourseID) REFERENCES Courses(CoursID),
    FOREIGN KEY (PrerequisiteCourseID) REFERENCES Courses(CourseID)
);

INSERT INTO Students (FirstName, LastName, Email, PhoneNumber, EnrollmentDate)
VALUES
('Ahmad','Ali','ahmad@email.com','0791828411','2023-09-01'),
('Sara','Omar','sara@email.com','0799288636','2023-09-01'),
('Lina','Hassan','lina@email.com','0777742020','2023-09-02'),
('Mohammad','Khaled','moh@email.com','0786939303','2023-09-03'),
('Noor','Salem','noor@email.com','0795858270','2023-09-04');

INSERT INTO Instructors (Name, Department, Email)
VALUES
('Dr. Ahmad Saleh','Computer Engineering','ahmad@uni.edu'),
('Dr. Rana Hasan','Electrical Engineering','rana@uni.edu'),
('Dr. Sami Omar','Information Technology','sami@uni.edu'),
('Dr. Lina Yazan','Computer Science','lina@uni.edu'),
('Dr. Khaled Ali','Networks Eneineering','khaled@uni.edu');

INSERT INTO Departments (DepartmentName)
VALUES
('Computer Engineering'),
('Electrical Engineering'),
('Information Technology'),
('Computer Science'),
('Networks Engineering');
INSERT INTO Courses (CourseName, InstructorID, Credits, Department)
VALUES
('Database Systems',1,3,'Computer Engineering'),
('Operating Systems',4,3,'Computer Science'),
('Computer Networks',5,3,'Networks Engineering'),
('Digital Logic',2,3,'Electrical Engineering'),
('Web Development',3,3,'Information Technology');

INSERT INTO Enrollments (StudentID, CourseID, EnrollmentDate, Status)
VALUES
(1,1,'2023-09-10','Completed'),
(2,1,'2023-09-10','Enrolled'),
(3,2,'2023-09-11','Completed'),
(4,3,'2023-09-12','Withdrawn'),
(5,4,'2023-09-13','Enrolled'),
(1,5,'2023-09-14','Completed');

INSERT INTO CourseRequirements (CourseID, PrerequisiteCourseID)
VALUES
(2,1),
(3,1);

SELECT s.*
FROM Students s
JOIN Enrollments e ON s.StudentID = e.StudentID
WHERE e.CourseID = 1;

INSERT INTO Students (FirstName, LastName, Email, PhoneNumber, EnrollmentDate)
VALUES ('Omar','Yousef','omar@email.com','0792080112',CURDATE());

UPDATE Enrollments
SET Status = 'Completed'
WHERE StudentID = 2 AND CourseID = 1;

SELECT CourseName
FROM Courses
WHERE InstructorID = 1;
SELECT s.*
FROM Students s
JOIN Enrollments e ON s.Student_ID = e.StudentID
WHERE e.CourseID = 1
AND e.Status = 'Completed';

SELECT *
FROM Courses
WHERE Department = 'Computer Engineering';


INSERT INTO Enrollments (StudentID, CourseID, EnrollmentDate, Status)
VALUES (3,5,'2023-10-15','Enrolled');

SELECT DISTINCT s.StudentID, s.FirstName, s.LastName
FROM Students s
JOIN Enrollments e ON s.Student_ID = e.StudentID
JOIN CourseRequirements cr ON e.CourseID = cr.CourseID
WHERE e.Status != 'Completed';