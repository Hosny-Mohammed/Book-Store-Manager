create database BookStoreDB;

create table Books(
	BookID int primary key IDENTITY(1,1),
	Title nvarchar(225)  not null,
	Author nvarchar(225)  not null,
	ISBN nvarchar(13) not null,
	Price decimal (10,3) not null,
	Quantity int not null
);

create table Librarians (
	LibrarianID int primary key IDENTITY(1,1),
	Username nvarchar(225) not null Unique,
	Name nvarchar(225) not null,
	Password nvarchar(225) not null
);

create table Users (
	UserID int primary key IDENTITY(1,1),
	Username nvarchar(225) not null Unique,
	Name nvarchar(225) not null,
	Password nvarchar(225) not null
	--BookID int not null Foreign key references Books(BookID)
);
--drop table Users

create table Borrowing_Books(
	BorrowingID int primary key IDENTITY(1,1),
	UserID int not null Foreign key references Users(UserID),
	BookID int not null Foreign key references Books(BookID),
	Date Date not null DEFAULT GetDate()
);
INSERT INTO Books (Title, Author, ISBN, Price, Quantity) 
VALUES 
('To Kill a Mockingbird', 'Harper Lee', '9780061120084', 10.99, 50),
('1984', 'George Orwell', '9780451524935', 9.99, 40),
('The Great Gatsby', 'F. Scott Fitzgerald', '9780743273565', 12.99, 30),
('Pride and Prejudice', 'Jane Austen', '9780141439518', 8.99, 60),
('The Catcher in the Rye', 'J.D. Salinger', '9780316769488', 11.49, 45);

INSERT INTO Librarians (Username,Name ,Password)
VALUES 
('librarian1','librarian1' ,'hashed_password1'),
('librarian2','librarian2' ,'hashed_password2');

INSERT INTO Users(Username,Name,Password)
VALUES
('Ahmed','Ahmed Mohammed','12345'),
('Mohammed','Mohammed Hosny','12345');

INSERT INTO Borrowing_Books(UserID,BookID)
Values
(1,2),
(2,1);

select * from Books
select * from Librarians
select * from Users;
SELECT * from Borrowing_Books

SELECT BOOKS.Title, Users.Name FROM Borrowing_Books 
left join Users ON Users.UserID = Borrowing_Books.UserID 
left join Books ON Books.BookID = Borrowing_Books.BookID


alter table Borrowing_Books
add End_Date Date

alter table Borrowing_Books
add Days int

alter table Borrowing_Books
drop column Days