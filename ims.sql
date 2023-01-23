create database imsDB
use imsDB

----- Users
create table users(
user_id int not null identity primary key,
user_name varchar(100) not null,
user_username varchar(100) not null,
user_password nvarchar(100) not null,
user_phone varchar (100) not null,
user_email varchar(100) not null,
user_status tinyint not null default 1
)

create procedure insertusers
@name varchar(100),
@username varchar(100),
@pwd nvarchar(100),
@phone varchar(100),
@email varchar(100)
AS
insert into users (user_name,user_username,user_password,user_phone,user_email) 
values (@name,@username,@pwd,@phone,@email)


create procedure updateusers
@name varchar(100),
@username varchar(100),
@pwd nvarchar(100),
@phone varchar(100),
@email varchar(100),
@id int
AS
update  users 
set
user_name= @name,
user_username= @username,
user_password = @pwd,
user_phone=@phone,
user_email= @email
where 
 user_id= @id


 create procedure deleteuser @id int
 as 
 delete from users where user_id = @id


 create procedure getusersdata as 
 select 
 u.user_id as 'ID',
 u.user_name as'Name',
 u.user_username as'Username',
 u.user_password as 'password',
 u.user_phone as 'Phone',
 u.user_email as 'Email',
 case when (user_status =1) then 'Active' else 'In-active' end as 'Status'
 from users u order by u.user_name


 --------------------- Categories
 create table Categories (
 cat_id int not null primary key identity,
 cat_name varchar(50),
 cat_inactive tinyint not null
 )

 create procedure Insertcat
 @catname varchar(50),
 @inactivecat tinyint
AS
insert into Categories (cat_name,cat_inactive)
values (@catname,@inactivecat)


create procedure updatecat
 @catname varchar(50),
 @inactivecat tinyint,
@idcat int
AS
update  Categories 
set
cat_name= @catname,
cat_inactive= @inactivecat
where
 cat_id= @idcat


 create procedure deletecat @idcat int
 as 
 delete from Categories where cat_id = @idcat

 create procedure getcatdata as 
 select 
 c.cat_id as 'ID',
 c.cat_name as'Category',
 case when (c.cat_inactive =1) then 'Yes' else 'No' end as 'Status'
 from Categories c order by c.cat_name asc

  create procedure getcatdatalist as 
 select 
 c.cat_id as 'ID',
 c.cat_name as'Category'
 from Categories c order by c.cat_name asc


 ---- Products
 create table products (
 pro_id int not null primary key identity,
 pro_name varchar(50) not null,
 pro_barcode nvarchar(100),
 pro_expiry date,
 pro_cat_id int not null foreign key references Categories(cat_id)
 )
 select * from products

 create procedure insertproduct
 @name varchar(50),
@barcode nvarchar(100),
@expiry date,
@catID int
AS
insert into products (pro_name,pro_barcode,pro_expiry,pro_cat_id)
values (@name,@barcode,@expiry,@catID)

create procedure updateproduct
 @name varchar(50),
@barcode nvarchar(100),
@expiry date,
@catID int,
  @proid int
AS
update  products 
set
pro_name= @name,
pro_barcode= @barcode,
pro_expiry=@expiry,
pro_cat_id= @catID
where 
 pro_id= @proid

  create procedure deleteproduct @proid int
 as 
 delete from products where pro_id = @proid


create procedure getproductdata
as
select
p.pro_id as 'Product ID',
p.pro_name as 'Product Name',
FORMAT(p.pro_expiry, 'dd,MMM,yyyy') as 'Expiry',
p.pro_barcode as 'Barcode'
from  products p 

------------ getuserdataforlogin

 create procedure getuserslogin
 @user varchar(100),
 @pass varchar(100)
 as 
 select 
 u.user_id as 'ID',
 u.user_name as'Name',
 u.user_username as'Username',
 u.user_password as 'password' 
 from users u 
 where 
 u.user_username = @user
 and 
 u.user_password= @pass


 --- supplier

 create table supplier(
 supplierid int not null primary key identity,
 supplierName varchar(100) not null unique,
 conatctPerson varchar (100) not null,
 phone1 varchar (15)not null,
 phone2 varchar (15),
 AddressS varchar(100) not null,
 NTN varchar (100) ,
 Supplier_status tinyint not null
 )

----getsupplier
create procedure insertsupplier
@suppliername varchar(100),
@contactperson varchar(100),
@phone1 varchar(15),
@phone2 varchar(15),
@addresss varchar(100),
@ntn varchar(100),
@status tinyint
AS
 insert into supplier (supplierName,conatctPerson,phone1,phone2,AddressS,NTN,Supplier_status)
 values(@suppliername,@contactperson,@phone1,@phone2,@addresss,@ntn,@status)

 create procedure updatesupplier
 @suppliername varchar(100),
@contactperson varchar(100),
@phone1 varchar(15),
@phone2 varchar(15),
@addresss varchar(100),
@ntn varchar(100),
@status tinyint,
@supid int
AS
update supplier
set
supplierName = @suppliername,
conatctPerson= @contactperson,
phone1=@phone1,
phone2=@phone2,
AddressS=@addresss,
NTN=@ntn,
Supplier_status=@status
where
supplierid=@supid

delete from supplier


create procedure deletesupplier
@supid int
as 
delete from supplier  where supplierid=@supid

create procedure getsupplierlist 
as
select 
s.supplierid as 'Supplier ID',
s.supplierName as ' Suuplier Name'
from supplier s  order by  s.supplierName asc


create procedure getsuplierdata 
as select 
s.supplierid as 'Supplier ID',
s.supplierName as ' Supplier Name',
s.conatctPerson as 'Contact Person',
s.phone1 as 'Phone1',
s.phone2 as 'Phone2',
s.AddressS as 'Address',
s.NTN as 'NTN#',
case when (s.Supplier_status =1) then 'active' else 'In-active' end as 'status'
from supplier s order by s.supplierName asc



--purchase invoice

create table PurchaseInvoice (
pi_id bigint not null identity primary key,
pi_date date not null,
pi_doneby int not null,
pi_suppID int not null,

)

create procedure insertpurchaseinvoice 
@date date,
@doneby int,
@suppID int
as
insert into PurchaseInvoice values (@date,@doneby,@suppID)

create procedure getlastpurchaseID
as
select top 1 pii.pi_id from PurchaseInvoice pii order by pii.pi_id desc

create table PurchaseInvoiceDetials
(
pid_id bigint not null identity primary key,
pid_purchaseid bigint not null foreign key references PurchaseInvoice(pi_id),
pid_proid int not null,
pid_proquan int not null,
pro_totalprice money not null,
)

delete  from stock

create procedure insertpurchaseinDetial
@purchaseID bigint,
@proID int,
@quan int,
@toPrice money
as
insert into PurchaseInvoiceDetials values (@purchaseID,@proID,@quan,@toPrice)

create table stock 
(
sproid int not null unique,
quan int not null
)
create procedure getallstock
as
select
p.pro_id as 'Product ID',
p.pro_name as 'Product Name',
p.pro_barcode as 'Barcode',
format (p.pro_expiry,'dd-MMM-yyyy') as 'Expiry Date',
pp.pp_buyingprice as 'Buying Price',
pp.pp_sellingprice as 'Selling Price',
c.cat_name as 'Category'
from products p 
inner join Categories c
on c.cat_id = p.pro_cat_id
inner join productprice pp 
on p.pro_id = pp.pp_proid


create table productprice
(
pp_proid int not null unique foreign key references products(pro_id) on delete cascade on update cascade,
pp_buyingprice money not null,
pp_sellingprice money,
pp_discount float,
pp_profit float
)

create procedure insertproductprice 
@proid int,
@bp money,
@sp money
as 
insert into productprice (pp_proid,pp_buyingprice) values (@proid,@bp)

create procedure updateproductprice
@proid int,
@bp money,
@sp money,
@dis float,
@proftp float
as
update productprice 
set 
pp_buyingprice = @bp,
pp_sellingprice = @sp,
pp_discount = @dis,
pp_profit =@proftp
where
pp_proid = @proid

create procedure getproductWRTCategory
@catID int
as
select 
p.pro_id as 'Product ID',
p.pro_name as 'Products',
pp.pp_buyingprice as 'Buying Price',
case when (pp.pp_sellingprice is null) then 0 else pp.pp_sellingprice end as 'Selling Price',
case when (pp.pp_discount is null) then 0 else pp.pp_discount end as 'Discount',
case when (pp.pp_profit is null) then 0 else pp.pp_profit end as 'ProfitP'
from products p
inner join productprice pp 
on p.pro_id = pp.pp_proid
inner join Categories c
on c.cat_id =p.pro_cat_id
where c.cat_id =@catID

create procedure checkproductpriceexit
@proid int
as
select * from productprice where  pp_proid= @proid


create procedure updateproductprice1
@proid int,
@bp money
as
update productprice 
set 
pp_buyingprice = @bp
where
pp_proid = @proid


create procedure getproductbybarcode
@barcode nvarchar(100)
as select
p.pro_id as 'Product ID',
p.pro_name as 'Product Name',
pp.pp_sellingprice as 'Selling Price'
from products p 
inner join productprice pp
on p.pro_id = pp.pp_proid
where p.pro_barcode = @barcode

create procedure getproductbybarcodePI	
@barcode nvarchar(100)
as select
p.pro_id as 'Product ID',
p.pro_name as 'Product Name'
from products p 
where p.pro_barcode = @barcode


