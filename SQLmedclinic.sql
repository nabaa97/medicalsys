create table patients(
patient_id int identity(1,1) primary key not null,
patient_name varchar (255) not null,
patient_age int,
patient_gender varchar (10),
patient_phoneno int not null,
);

create table doctors(
doctor_id int identity(1,1) primary key not null,
doctor_name varchar(255) not null,
doctor_spec varchar(255),
doctor_phoneno int not null,
);

create table medicins(
medicin_id int identity(1,1) primary key not null,
medicin_name varchar (255) not null,
);

create table appointments(
patient_id int not null,
foreign key (patient_id)
references patients(patient_id),
review_date varchar(255) not null,
reservation_seq int not null,
);

create table diagnotics(
patient_id int not null,
foreign key (patient_id)
references patients(patient_id),
pathocase varchar(255),
medicin_id int not null,
foreign key (medicin_id)
references medicins(medicin_id),
tests varchar(255),
);