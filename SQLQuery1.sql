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



select * from bank;

select * from employee;

insert into employee (employeeID,branchID,userName,password,name) values('1','masr000','hoss','500500','hossam');

insert into branch values('masr001','15 may city','108899');
select branchNum from bank;

alter table bank
alter column bankAddress varchar(50);

alter table branch
alter column branchAddress varchar(50);


select * from branch;

insert into bank values('bank masr','west city','108899');

alter table bank
add branchnum int;

update bank
set branchnum=2
where bankID='T345678LV';

delete from bank
where bankID='108899';



select * from bank;
select * from customer;

insert into bank(bankName, bankAddress, bankID)
values('Masr', 'Al Giza Desert, Giza Governorate', 'G9lk678'),
      ('QNB', 'Oula Al Haram, Giza Governorate', '165Rt5678'),
      ('AL-Ahli', 'El Sayeda Zeinab, Cairo Governorate','12u767834'),
      ('Cairo', 'Old Cairo, Cairo Governorate', 'D234567xg'),
      ('CIB', 'Agouza, Giza Governorate', 'T345678LV');


insert into branch(branchID, branchAddress, bankID)
values('Masr109', 'Kafr Tohormos , Bulaq, Giza Governorate','G9lk678'),
      ('QNB457', 'El Omraniya, Giza Governorate', '165Rt5678'),
      ('Masr1567', 'Qesm AR Ramel, Alexandria Governorate', 'G9lk678'),
      ('CIB788', 'Tarh Al Bahr, El Sharq, Port Said Governorate', 'T345678LV'),
      ('Cairo98', 'Qism El-Arab, Port Said Governorate', 'D234567xg'),
      ('AL-Ahli56', 'Fayoum University, Faiyum Governorate', '12u767834'),
      ('Cairo67', 'Shebean, Al Qalyubia Governorate','D234567xg'),
      ('QNB345', 'Banha, Al Qalyubia Governorate', '165Rt5678'),
      ('AL-Ahli90', 'Dokki, Giza Governorate','12u767834'),
      ('CIB123','Mall Of Egypt , Level 2, Giza Governorate', 'T345678LV'),
      ('QNB395', 'Nasr City, Cairo Governorate', '165Rt5678');


	  select * from customer;

	  select * from loanWaitingList;