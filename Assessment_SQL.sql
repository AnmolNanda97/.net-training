create database Assessment

create table branch_master(
branch_id varchar(6),
branch_name varchar(30),
branch_city varchar(30),
constraint pk_bid primary key (branch_id)

)

create table loan_details(
customer_number varchar(6),
branch_id varchar(6),
loan_amount int,
constraint fk_bid1 foreign key (branch_id) references branch_master (branch_id),
constraint fk_cust1 foreign key (customer_number) references customer_master (customer_number) 

)

create table customer_master(
customer_number varchar(6),
firstname varchar(30),
middlename varchar(30),
lastname varchar(30),
customer_city varchar(15),
customer_contact_no varchar(15),
occupation varchar(20),
customer_date_of_birth date,
constraint pk_cust primary key (customer_number)

)

create table transaction_details(
transaction_number varchar(6),
account_number varchar(6),
date_of_transaction date,
medium_of_transaction varchar(20),
transaction_type varchar(20),
transaction_amount int,
constraint pk_tran primary key (transaction_number),
constraint fk_acc foreign key (account_number ) references account_master (account_number)

)

create table account_master(
account_number varchar(6),
customer_number varchar(6),
branch_id varchar(6),
opening_balance int,
account_opening_date date,
account_type varchar(10),
account_status varchar(10),
constraint pk_acc primary key (account_number),
constraint fk_cust2 foreign key (customer_number) references customer_master (customer_number),
constraint fk_bid2 foreign key (branch_id) references branch_master (branch_id)


)


-1
SELECT a.account_number, c.customer_number, c.firstname, c.lastname, a.account_opening_date from
account_master a left join
customer_master c
on a.customer_number=c.customer_number

------------------------------------------------------------------------------------------------------
-2
select count(customer_city) as "Cust_Count" from customer_master where customer_city='DELHI' 

------------------------------------------------------------------------------------------------------

-3
SELECT  c.customer_number, c.firstname, a.account_number from
customer_master c
left join
account_master a 
on a.customer_number=c.customer_number where day(a.account_opening_date)>15

-------------------------------------------------------------------------------------------------------

-4
  SELECT  c.customer_number, c.firstname, a.account_number from
customer_master c
left join
account_master a 
on a.customer_number=c.customer_number where a.account_status='TERMINATED'  order by c.customer_number asc ,a.account_number asc

-----------------------------------------------------------------------------------------------------------------------

-5
select count(*) as Trans_Count , t.transaction_type
from transaction_details t, account_master a
where a.account_number = t.account_number and a.customer_number like '%001' group by t.transaction_type order by t.transaction_type asc;

-------------------------------------------------------------------------------------------
-6

SELECT  count(*) as Count_Customer from customer_master 
where customer_number not in (select distinct customer_number from account_master)

-----------------------------------------------------------------------------------------------

-7

select account_number , sum(transaction_amount ) as Deposit_Amount
from transaction_details
where transaction_details.transaction_type='DEPOSIT'
group by transaction_details.account_number
order by transaction_details.account_number

