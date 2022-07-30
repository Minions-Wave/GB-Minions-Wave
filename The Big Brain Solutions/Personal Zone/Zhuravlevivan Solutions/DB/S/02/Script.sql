select * from persons

CREATE TABLE persons (
    person_full_name       varchar(100), 
    person_birthday        date,
    person_status          bool,
    person_phone           integer,
    person_comment         varchar(100),
    person_address         varchar(100),
    person_group           varchar(100)
)

INSERT INTO persons (
  person_full_name,
  person_birthday,
  person_status,
  person_phone,
  person_comment,
  person_address,
  person_group
)
VALUES (
	'Иванов И. И.',	'1990-02-12', true,	126, 'интернет', 'Можга', 'Работа'
);

INSERT INTO persons (
 person_full_name,
  person_birthday,
  person_status,
  person_phone,
  person_comment,
  person_address,
  person_group)
VALUES 
	('Иванов И. И.', '1990-02-12', true, '127', 'старый', 'Можга', 'Работа'),
	('Иванов И. И.', '2001-09-18', false, '527', 'личный', 'Санкт-Петербург', 'Школа'),
	('Петров П. П.', '2001-09-18', true, '234', 'личный', 'Москва', 'Родня'),
	('Петров П. П.', '1983-04-24', true, '235', 'рабочий', 'Москва', 'Родня'),
	('Васильев В. В.', '1998-05-21', false, '456', 'личный', 'Белгород', 'Друзья'),
	('Сидоров С.С.', '2007-07-13', false, '643', 'личный', 'Киров', 'Родня'),
	('Сидоров С.С.', '2007-07-13', false, '654', 'старый', 'Киров', 'Родня'),
	('Александров А.А.', '1987-03-05', true, '412', 'рабочий', 'Уфа', 'Друзья'),
	('Борисов Б.Б', '1989-08-16', false, '723', 'рабочий', 'Москва', 'Работа'),
	('Михайлов М.М.', '1997-01-08', true, '876', 'личный', 'Сочи', 'Университет'),
	('Михайлов М.М.', '1997-01-08', true, '875', 'рабочий', 'Сочи', 'Университет'),
	('Кириллов К.К.', '1996-12-03', false, '933', 'личный', 'Киров', 'Работа');
	
select * from peoples

CREATE TABLE peoples (
    people_id			varchar(10),
    people_full_name	varchar(100),
    people_birthday		date,
    people_status		bool
 )

 INSERT INTO peoples (
 	people_id,
    people_full_name,
    people_birthday,
    people_status
 )
 VALUES(
	'1', 'Иванов И. И.', '1990-02-12', TRUE),
	('2', 'Иванов И. И.', '2001-09-18', FALSE),
	('3', 'Петров П. П.', '1983-04-23', TRUE),
	('4', 'Васильев В. В.', '1998-05-21', FALSE),
	('25', 'Кузьмин К.К.', '2020-05-21', FALSE
 );

select * from address

CREATE TABLE address (
    address_people_id	varchar(10),
    address_city		varchar(100),
    address_comment		varchar(100)
 )

 INSERT INTO address (
    address_people_id,
    address_city,
    address_comment
 )
 values
 	('1', 'Можга', 'Место рождения'),
	('1', 'Казань', 'По прописке'),
	('1', 'Москва', 'Рабочий'),
	('2', 'Санкт-Петербург', 'По прописке'),
	('3', 'Москва', 'По прописке'),
	('4', 'Белгород', 'По прописке'),
	('5', 'Уфа', 'По прописке'),
	('6', 'Сочи', 'По прописке'),
	('7', 'Киров', 'Рабочий'),
	('8', 'Владивосток', 'Место рождения'),
	('9', 'Рязань', 'Рабочий'),
	('10', 'Хабаровск', 'Место рождения');

select * from phones

CREATE TABLE phones (
    phones_people_id	varchar(10),
    phones_tel_number		varchar(100),
    phones_comment		varchar(100)
 )

 INSERT INTO phones (
    phones_people_id,
    phones_tel_number,
    phones_comment
 )
 values
 	('1', '123', 'личный'),
	('1', '124', 'рабочий'),
	('1', '125', 'для поездок'),
	('1', '126', 'интернет'),
	('1', '127', 'старый'),
	('2', '527', 'личный'),
	('3', '234', 'личный'),
	('3', '235', 'рабочий'),
	('4', '456', 'личный'),
	('11', '999', 'личный'),
	('12', '997', 'рабочий'),
	('13', '995', 'личный'),
	('14', '993', 'для поездок'),
	('15', '991', 'для поездок');

select * from peoples inner join phones on people_id = phones_people_id

select * from peoples inner join address on people_id = address_people_id

select * from peoples left join phones on people_id = phones_people_id

select * from peoples left join address on people_id = address_people_id

select * from peoples right join phones on people_id = phones_people_id

select * from peoples right join address on people_id = address_people_id

select * from peoples full join phones on people_id = phones_people_id

select * from peoples full join address on people_id = address_people_id

select people_full_name, phones_tel_number, phones_comment from peoples left join phones on people_id = phones_people_id

select people_full_name, address_city, address_comment from peoples full join address on people_id = address_people_id
 