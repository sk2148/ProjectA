create database CmS
use CmS
go

create table Usr(
UserName varchar(20) unique,
FirstName varchar(20),
LastName varchar(20),
Password varchar(20))


insert Usr values('sk2148','Santhosh','S','Sk@29102001')

select * from Usr

create proc UsrLogin
@uname varchar(20),
@pwrd varchar(20)
as
select UserName,Password from Usr
where UserName=@uname and Password=@pwrd

exec UsrLogin'sk2148','Sk@29102001'

create table Doctor(
Doctor_ID int identity(1,1) primary key,
FirstName varchar(20) unique not null,
LastName varchar(20),
Sex varchar(10),
Specialization varchar(20),
Visiting_Hours varchar(20),
constraint Gen check(Sex in('M','F','Others')), 
constraint Spec check(Specialization in('General','Internal Medicine','Pediatrics','Orthopedics','Ophthalmology'))
)


drop table Doctor
select * from Doctor

create proc Add_Doc
@fname varchar(20),
@lname varchar(20),
@sex varchar(10),
@spec varchar(20),
@vhrs varchar(20)
as
insert Doctor values(@fname,@lname,@sex,@spec,@vhrs)

create table Patient(
Patient_ID int identity(1,1)primary key,
FirstName varchar(20),
LastName varchar(20),
Sex Varchar(10),
Age int,
DOB varchar(10))

create proc Add_Pat
@fname varchar(20),
@lname varchar(20),
@sex varchar(10),
@age int,
@dob varchar(20)
as
insert Patient values(@fname,@lname,@sex,@age,@dob)

exec Add_Pat'Latha','R','F','25','25/02/1998'

drop proc Add_Pat

create table Appointment(
Appointment_ID int identity(1,1) primary key,
Patient_ID int foreign key references Patient(Patient_ID),
Specialization varchar(20),
Doctor varchar(20) foreign key references Doctor(FirstName),
VisitDate varchar(20),
Appointment_Time varchar(20),
)

drop table Appointment

drop table Doctor

drop table Patient
select * from Patient

select * from appointment

select * from Doctor