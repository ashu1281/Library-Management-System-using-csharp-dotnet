create table NewMember(
memId int NOT NULL IDENTITY(1,1) primary key,
mName varchar(250) not null,
mContact bigint not null,
mEmail varchar(250) not null,
mState varchar(250) not null,
mCity varchar(250) not null,
mPinCode bigint not null
)


--mName, mContact, mEmail, mState, mCity, mPinCode
select * from NewMember