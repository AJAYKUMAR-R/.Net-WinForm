--use master;

--create table RegisterUser (username varchar(25),useremail varchar(45),userpassword varchar(20),usermobileno varchar(10) primary key); 

--select * from RegisterUser;


















--use POS;

--The table RegisterUser 
--create table RegisterUser (username varchar(25),useremail varchar(45),userpassword varchar(20),usermobileno varchar(10) primary key); 



--The table RegisterCosutomer 
--create table Singin (coustid int primary key identity(1000000,1),coustname varchar(25)  , coutemail varchar(25), coustmobile varchar(10), coustaddress varchar(45));

--The Product Table
--create table Product (productid int primary key identity(1000000,1),productname varchar(25) ,productdescription varchar(1000),stockunit bigint,productprice bigint);


--create table OrderTable(orderid int primary key identity(1000000,1),coustid int,productDescription varchar(1000),totalprice bigint,FOREIGN KEY (coustid) REFERENCES Singin (coustid));  


--select * from Product;

--drop table Product;

--insert into Product (productname,productdescription,stockunit,productprice)  values ('Soap','Himalaya',12407,125);

