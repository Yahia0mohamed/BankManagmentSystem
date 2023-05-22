use myBankSystem

create table bank(
	branchNum INT,
	bankName VARCHAR(30),
	bankAddress VARCHAR(50),
	bankID VARCHAR(10) PRIMARY KEY
);

alter table bank 
alter column branchNum INT;

alter table bank
add branchNum INT IDENTITY(1,1);

CREATE TABLE branch(
	branchID VARCHAR(10) PRIMARY KEY,
	branchAddress VARCHAR(50),
	bankID VARCHAR(10)
);

ALTER TABLE branch
ADD CONSTRAINT FK_bankID
FOREIGN KEY (bankID) REFERENCES bank(bankID);

CREATE TABLE Customer(
     SSN varchar(10) primary key,
     name varchar(30),
     phone varchar(11),
     address varchar(50),
     branchID varchar(10),
);

CREATE TABLE account(
	accID VARCHAR(10),
	balance float,
	accType varchar(30),
	SSN VARCHAR(10)
);

ALTER TABLE account
ADD CONSTRAINT FK_SSN_customer
FOREIGN KEY (SSN) REFERENCES customer(SSN);

create table employee(
    employeeID varchar(10) primary key,
    branchID varchar(10),
    userName varchar(20),
    [password] varchar(20)
);

alter table employee
add name varchar(30);

ALTER TABLE customer
ADD CONSTRAINT FK_BranchID_customer
FOREIGN KEY (branchID) REFERENCES branch(branchID);

Alter table customer
add userName varchar(10) not null, [password] varchar(20) not null;

alter table loanWaitingList
add id int identity(1,1);

create table loanWaitingList(
    customerName varchar(30),
    loanType varchar(30),
    amount float,
    SSN varchar(10) foreign key references customer(SSN),
    branchID varchar(10) foreign key references branch(branchID)
);


CREATE TABLE Loan(
     loanID varchar(10),
     loanType varchar(30),
     amount float,
     SSN varchar(10),
     branchID varchar(10)
);

alter table loan
add employeeID varchar(10) not null;

alter table loan
add constraint FK_EMPID_EMPLOYEE
FOREIGN KEY (employeeID) references employee(employeeID);

/* loan
empID  loanID
1      88
1      99

employee

id name username pass loanid
1						88
1						99
*/

ALTER TABLE loan
ADD CONSTRAINT FK_BranchID_loan
FOREIGN KEY (branchID) REFERENCES branch(branchID) , FOREIGN KEY (SSN) REFERENCES customer(SSN) ;

select * from account;
select * from bank;
select * from branch;
select * from Customer;
select * from employee;
select * from Loan;
select * from loanWaitingList;

ALTER TABLE loan
ADD CONSTRAINT PK_LoanID
PRIMARY KEY (loanID);

ALTER TABLE account
ADD CONSTRAINT PK_accID
PRIMARY KEY (accID);

ALTER TABLE loan
Alter column loanID varchar(10) not null;

ALTER TABLE account
Alter column accID varchar(10) not null;


/*add employee*/
insert into employee (employeeID,userName,password,branchID) values (?,?,?,?);

/*add bank*/
insert into bank (bankAddress,bankName) values ('?','?');

/*add branch*/

select * from bank
insert into branch(branchID,branchAddress,bankID) values ('?','?','?')
update bank set branchNum=branchNum+1
where bankname ='?';

/*add customer*/

insert into Customer (branchID,SSN,name,phone,address,userName,password) values ('?','?','?','?','?','?','?');

/*showing list of loans*/

select distinct loanType
from Loan;


/*showing list of customers*/

select name,phone,address,SSN,branchID from Customer;

/*show a list of loan with customer name and employee name*/

select loanType,amount ,
(
	select name from Customer
	where Customer.SSN=Loan.SSN
) 
as CustomerName ,
(
	select name from employee
	where employee.employeeID=Loan.employeeID
) 
as employeeName
from Loan;

/*Performing operations on loans: request and start operation (by
customer)*/
insert into loanWaitingList (customerName,loanType,amount,SSN,branchID) values ('?','?','?','?','?');


/*Performing operations on loans: accept (reject, pay loan (by employee))*/
/*if he choose waiting list*/
select * from loanWaitingList;

select * from loanWaitingList
where id='?';

/*if he choose loans*/
select * from Loan;

select * from Loan
where loanID='?';




select * from customer

alter table loanwaitinglist
add constraint COM_PK_SSN_BRANCHID
PRIMARY KEY(SSN,branchID);

alter table loanwaitinglist
alter column SSN varchar(10) not null;
alter table loanwaitinglist
alter column branchID varchar(10) not null;