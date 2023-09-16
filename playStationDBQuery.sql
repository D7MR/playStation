---------------------product-----------------------------------
create table product(product_id int primary key,
product_cost decimal (20,2) not null,
product_name varchar(200)not null,
product_num int,
product_dis decimal 
);
-----------------------employee---------------------------------
create table employee (employee_ssn int primary key,
employee_permission bit not null,
employee_name varchar(200) not null,
employee_email varchar(200),
employee_address varchar(200),
employee_password varchar(200) not null
);
---------------------------payment-----------------------------
create table payment(payment_id int primary key,
payment_purpose varchar(200)not null,
payment_cost decimal(20,2) not null,
payment_date date not null,
employee_ssn int ,
foreign key(employee_ssn) REFERENCES employee (employee_ssn) 
);
------------------------------customer--------------------------
create table customer(customer_id int primary key,
customer_number varchar(200),
customer_name varchar(200),
customer_email varchar(200),
);
------------------------------datils--------------------------
create table datils(dat_id int primary key,
start_time varchar(200) not null,
end_time varchar(200) not null,
discount decimal(20,2),
total_cost decimal(20,2)not null,
employee_ssn int,
customer_id int,
foreign key(customer_id) REFERENCES customer (customer_id) ,
foreign key(employee_ssn) REFERENCES employee (employee_ssn) 
);
------------------------------room-----------------------------
create table room(room_id int primary key,
room_number int not null,
room_type bit not null,
room_hourCost decimal(20,0) not null
);
------------------------------room_detils-----------------------------
create table room_detils(
room_id int,
dat_id int ,
foreign key(room_id) REFERENCES room (room_id) ,
foreign key(dat_id) REFERENCES datils (dat_id)
);
---------------------product_datils-----------------------------------
create table product_datils(
det_id int ,
product_id int,
foreign key(product_id) REFERENCES product(product_id),
foreign key(det_id) REFERENCES datils(dat_id)
);