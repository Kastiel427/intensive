use GutyrchikIntensive
go
insert into Projects
values (1, 'Ресторан Синий берег')
insert into Projects
values (2, 'Компания VirtualSystem')
insert into Projects
values (3, 'Автосервис Гаечка')
insert into Projects
values (4, 'Cервис Летай, как бабочка')
insert into Projects
values (5, 'Обучение клиентов')

insert into Tasks
values (1, 'Создать базу данных', 'Выделить сущности и связи, задать ограничения')
insert into Tasks
values (2, 'Написать сайт', 'Оформить страницы, подключить анимацию')
insert into Tasks
values (3, 'Написать сервер', 'Сфокусировать внимание на быстродействии')
insert into Tasks
values (4, 'Альфа-тестирование', 'Провести тестирование среди ограниченного количества людей и выявить пролбемы')
insert into Tasks
values (5, 'Бета-тестирование', 'Провести открытое тестирование и выявить окончательные проблемы')

insert into [Tasks in Projects]
values(1, 1, 'Нет', '08/1/2016')
insert into [Tasks in Projects]
values(1, 2, 'Нет','09/1/2016')
insert into [Tasks in Projects]
values(1, 3, 'Нет', '11/15/2016')
insert into [Tasks in Projects]
values(2, 1, 'Нет', '07/23/2016')
insert into [Tasks in Projects]
values(2, 2, 'Нет', '08/1/2016')
insert into [Tasks in Projects]
values(2, 3, 'Нет', '11/10/2016')
insert into [Tasks in Projects]
values(2, 4, 'Нет', '12/1/2016')
insert into [Tasks in Projects]
values(2, 5, 'Нет', '01/31/2017')
insert into [Tasks in Projects]
values(3, 1, 'Нет', '01/31/2017')
insert into [Tasks in Projects]
values(3, 2, 'Нет', '02/23/2017')
insert into [Tasks in Projects]
values(3, 3, 'Нет', '03/1/2017')
insert into [Tasks in Projects]
values(4, 2, 'Нет', '03/1/2017')
insert into [Tasks in Projects]
values(5, 2, 'Нет', '08/1/2016')


