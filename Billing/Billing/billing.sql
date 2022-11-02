--use POS;
 
--select stockunit from Product where productid = 1000000;

--select * from Product;

--select productid,productname,productdescription,productprice from Product where productid = 1000000;

--select * from OrderTable;

--drop table RegisterUser;

--Register user TAble

--create table RegisterUser( username varchar(45) not null, usermobileno varchar(10) primary key,userpassword varchar(25) not null,userrole varchar(45) not null);

--insert into RegisterUser values('Ajay','9942711513','123','user');



--elect * from RegisterUser;

--select * from Singin;


--select coustid from Singin where coustmobile = '9942711513';

--select * from RegisterUser;


--delete Singin where coustid = 1000002;

--insert into Singin (coustname,coutemail,coustmobile,coustaddress)   values ('Ajay','ajaysehwag005@gmail.com','9942711513','Trichy');

--create table OrderTable(ordrderid bigint   primary key , custid int,productdetails varchar(2000) not null ,price decimal(6,2) not null,bildate varchar(30) not null,foreign key(custid) references coustomerRegister(custid));

--select * from coustomerRegister;

--insert into OrderTable values(101,100,'Shampo',125,'13-08-2022');

--select * from OrderTable;

--select * from Singin;


--SELECT TOP 1 ordrderid FROM OrderTable
--ORDER BY ordrderid DESC;

--update  Product set stockunit = stockunit - 1   where productid = 1000000; 



--ALTER TABLE Product ALTER COLUMN productprice decimal(5,2);



--delete from Product where productid = 1000009;

--drop table Product;

--insert into Product(productname,productdescription,stockunit,productprice) values('SunSoap','Himalaya',87,200.225);



--select * from OrderTable;


--ALTER TABLE OrderTable ALTER COLUMN price decimal(5,2)


--update Product set productname = 'Paste',productdescription = 'Himalya',stockunit = 124589,productprice = 128.98 where productid = 1000000;

--select * from Product;

--delete from Product where productid = 1000015;

--select * from RegisterUser;


--select * from Product;

--product Categories Table

--drop table productcategories;

--create table Productcategories (productid int not null ,productcatid varchar(200) not null , catename varchar(55) unique not null,stocks int not null, price decimal(20,2) not null, dateproductcategoriesaddded varchar(20) not null, foreign key (productid) references Product(productid) on delete cascade,primary key(productcatid) );

--drop table Product;


--product table
--create table Product (productid int IDENTITY(1,1) primary key,pname varchar(50) unique not null,dateproductaddded varchar(20) not null);

--insert into Product(pname,dateproductaddded) values('Conditioner','5 june 2018');

--select * from Product;


--select * from productcategories;

--select productcatid,catename,price from productcategories;

--drop table coustomerRegister;


--Coustomer Register Table
--create table coustomerRegister (custid int identity(100,1) primary key ,custname varchar(50) not null,customereamil varchar(45) not null,customermobileno varchar(10) unique,customeraddress varchar(35));

--select * from productcategories;

--delete Productcategories where  catename = 'Dark_2';

--select * from Productcategories where catename = 'soap';

--drop table Singin;

--update Productcategories 

--select * from coustomerRegister;

--select * from OrderTable;

--update Productcategories set stocks = 178, price = 85.25 where catename = 'DeadDark' ;

--select custid,custname from coustomerRegister where customermobileno = '7502449969';


--select * from Product;



--delete Product where pname = '8767+';

--delete Productcategories where productid = 1;


--select * from coustomerRegister;


--select OrderTable.custid,coustomerRegister.custname,OrderTable.ordrderid,OrderTable.productdetails,OrderTable.productdetails from OrderTable  LEFT JOIN  coustomerRegister on OrderTable.custid = coustomerRegister.custid where custname = 'Ajay kumar r';

--alter table Product add  unique (pname);

--Practise In Query

--create table Student(id int primary key identity(1,1),names varchar(20));

--insert into  Student(names) values('Vjay');

--select * from Student;

--update Student set names = 'Arnold' where id = 2;


--delete Student where id =2;


--select * from Student;

--create view Ajay as select id from Student;

--select * from Ajay;

--SELECT NAME FROM sys.objects WHERE TYPE='U'  


--drop procedure ak;

--create procedure ak
--as
--begin
--select * from Student order by  id desc;
--end;


--exec ak;

--alter table Student add  dates date;


--insert into Student(names,dates) values('Arun','12/9/2000');

--select DATENAME(MONTH, GETDATE()) AS CurrentMonth  from Student;

--select top 1 id from Student;

---alter table Student  column names varchar(25);


--select * from Product inner join Productcategories on Product.productid  = Productcategories.productid;


--select * from Productcategories;

--select * from Student;

--create table Stu(id int ,years int);

---insert into Stu values (3,2000),(4,2500);

select * from Student full join Stu on Student.id  = Stu.id;