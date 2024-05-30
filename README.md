Краткая спецификация модуля учета заявок на ремонт бытовой техники

Проект: Модуль учета заявок на ремонт бытовой техники
Заказчик: ООО "БытСервис"
Исполнитель: Сервисный центр "IT-Соm"
Приложение для учета заявок на ремонт бытовой техники обеспечивает возможность авторизации для трех типов пользователей: заказчика, оператора и мастера. После успешной авторизации заказчик может просматривать список заявок, добавлять новые, редактировать заявки и отслеживать статусы своих заявок. Оператор, после авторизации, имеет доступ к списку заявок, может назначать мастера на выполнение заявки, изменять статусы заявок и их описание, а также заказывать необходимые запчасти по запросу мастера. Мастер может просматривать заявки, добавлять комментарии к ним и фиксировать информацию о недостающих запчастях и использованных в ремонте. Приложение также предоставляет возможность расчета количества заявок для оператора.
Входные данные:
•	Данные для авторизации (логин, пароль) для заказчика, оператора и мастера.
•	Заявки на ремонт бытовой техники: информация о неисправностях, типе техники, контактные данные заказчика.
Выходные данные:
•	Список заявок для заказчика.
•	Уникальный идентификатор заявки.
•	Статус заявки (в процессе, выполнено, отклонено и т. д.).
•	Отслеживание изменений статуса и комментариев для всех участников (заказчик, оператор, мастер).
•	Информация о запчастях, необходимых для ремонта.
•	Расчет количества заявок для оператора.
____________
Протокол тестирования

Общие сведения:
Тестируемое приложение: Учет заявок на ремонт бытовой техники.
Версия приложения: 1.0
Цель тестирования:
Проверить функциональность и безопасность приложения, а также убедиться в соответствии его требованиям.

Тестовые случаи
Тестирование авторизации:
Ожидаемый результат: Все типы пользователей (заказчик, оператор, мастер, менеджер) успешно авторизуются с корректными учетными данными.
Фактический результат: Все типы пользователей успешно авторизовались без проблем.

Тестирование управления заявками:
Ожидаемый результат: Заказчик может добавить новую заявку, оператор может изменить статус и описание заявки, мастер может добавить комментарий к заявке.
Фактический результат: Все действия по управлению заявками прошли успешно и без ошибок.

Тестирование управления мастерами:
Ожидаемый результат: Оператор может назначить мастера на выполнение заявки.
Фактический результат: Все действия по управлению мастерами выполнены успешно.

Результаты тестирования:
Все ожидаемые результаты совпали с фактическими.
Приложение полностью соответствует требованиям и готово к выкатке на продуктивный сервер.
_____________
Руководство системного программиста

Введение
Это руководство предназначено для системного программиста, который будет разрабатывать приложение для учета заявок на ремонт бытовой техники. Приложение будет предоставлять возможность авторизации для четырех типов пользователей: заказчиков, операторов, мастеров и менеджеров. 

1.	Общие сведения о программе
Это приложение предназначено для учета заявок на ремонт бытовой техники. Оно обеспечивает возможность авторизации для заказчиков, операторов, менеджеров и мастеров, а также управление заявками и их статусами.

2.	Структура программы
Программа содержит модули.
  1.	Модуль авторизации:
  Обеспечивает функционал аутентификации пользователей и управление их сеансами.
  2.	Модуль управления заявками:
  Включает в себя функции добавления, редактирования и отслеживания статусов заявок.
  3.	Модуль управления мастерами:
  Позволяет операторам назначать мастеров на выполнение заявок и управлять их активностью.
  4.	Модуль управления запчастями: 
  Предоставляет возможность заказа необходимых запчастей для ремонта.
  5.	Модуль отслеживания изменений:
  Регистрирует и хранит историю изменений статусов заявок и комментариев к ним.

3.	Настройка программы
Создайте базу данных и определите необходимые таблицы в соответствии с требованиями приложения.
Укажите параметры подключения к базе данных и другие настройки в файле конфигурации для обеспечения корректной работы приложения.

4.	Проверка программы
Необходимо выполнить тестирование функционала, протестируйте каждый модуль на соответствие требованиям и корректность работы, чтобы обеспечить надежную работу всего приложения.

5.	Дополнительные возможности
Добавьте возможность оплаты услуг ремонта прямо через приложение.
Разработайте мобильное приложение, которое обеспечит удобный доступ к системе учета заявок на ремонт бытовой техники с мобильных устройств.

6.	Сообщения системному программисту
Не забывайте вести документацию по коду, чтобы облегчить понимание проекта другим разработчикам.
Внимательно изучайте обратную связь от пользователей и исправляйте выявленные проблемы в своевременном режиме.
_________________
блок-схема 1

@startuml
title Основной алгоритм учета заявок на ремонт бытовой техники
start
:Авторизация;
if (Авторизовался заказчик?) then (да)
    :Проверка базы данных на наличие заявок;
    if (Заявки есть?) then (да)
        :Отображение списка заявок;
    else (нет)
    endif
    :Добавление новой заявки;
    :Ввод данных заявки;
    :Присвоение уникального идентификатора заявке;
    :Поиск заявки по номеру или параметрам;
    :Редактирование заявки;
    :Отслеживание статуса заявки;
else (нет)
    if (Авторизовался оператор?) then (да)
        :Назначение мастера к заявке;
        :Изменение описания и статуса заявки;
        :Заказ запчастей по запросу мастера;
        :Расчет количества заявок;
    else (нет)
        if (Авторизовался мастер?) then (да)
            :Добавление комментариев к заявке;
            :Фиксация информации о запчастях;
        else (нет)
        endif
    endif
endif
stop
@enduml
______________
блок-схема 2

@startuml
title Расчет количества заявок
start
:Авторизация оператора;
if (Оператор авторизован?) then (да)
    :Ввод параметра расчета;
    :Запрос к базе данных на определение количества заявок;
    :Отображение результатов расчета;
else (нет)
endif
stop
@enduml
_________________
ТАБЛИЦЫ БД

USE RepairRequests;
-- Таблица для хранения информации о пользователях
CREATE TABLE Users(
    userID INT PRIMARY KEY,
    fio VARCHAR(255) NOT NULL,
    phone VARCHAR(20) NOT NULL,
  	login VARCHAR(50) NOT NULL,
  	password VARCHAR(20) NOT NULL,
  	type VARCHAR(30) NOT NULL
);
-- Таблица для хранения информации об операторах
CREATE TABLE Operators (
    operatorID INT PRIMARY KEY,
    operatorName VARCHAR(100) NOT NULL,
    operatoPhone VARCHAR(20) NOT NULL,
	  userID INT NOT NULL,
    FOREIGN KEY (userID) REFERENCES Users(userID)
);
-- Таблица для хранения информации о мастерах
CREATE TABLE Masters (
    masterID INT PRIMARY KEY,
	  masterType VARCHAR(100) NOT NULL,
    masterName VARCHAR(100) NOT NULL,
    masterPhone VARCHAR(20) NOT NULL,
	  userID INT NOT NULL,
    FOREIGN KEY (userID) REFERENCES Users(userID)
);
-- Таблица для хранения информации о клиентах
CREATE TABLE Clients (
    clientID INT PRIMARY KEY,
    clientName VARCHAR(100) NOT NULL,
    clientPhone VARCHAR(20) NOT NULL, 
	  userID INT NOT NULL,
    FOREIGN KEY (userID) REFERENCES Users(userID)
);
-- Таблица для хранения информации о заявках
CREATE TABLE Requests (
	  requestID INT IDENTITY(1,1) PRIMARY KEY,
    startDate DATE NOT NULL,
    homeTechType VARCHAR(50) NOT NULL,
    homeTechModel VARCHAR(70) NOT NULL,
    problemDescription VARCHAR(200) NOT NULL,
  	requestStatus VARCHAR(50) NOT NULL,
  	completionDate DATE,
  	repairParts VARCHAR(200),
    masterID INT,
    clientID INT NOT NULL,
  	FOREIGN KEY (clientID) REFERENCES Clients(clientID),
  	FOREIGN KEY (masterID) REFERENCES Masters(masterID) 
);
-- Таблица для хранения комментариев мастеров
CREATE TABLE MasterComments (
    сommentID INT PRIMARY KEY,
  	message VARCHAR(255) NOT NULL,
  	masterID INT NOT NULL,
    requestID INT NOT NULL,
    FOREIGN KEY (requestID) REFERENCES Requests(requestID),
    FOREIGN KEY (masterID) REFERENCES Masters(masterID)
);
-- Таблица менеджеров по качеству
CREATE TABLE Managers (
    managerID INT PRIMARY KEY,
    managerName VARCHAR(255) NOT NULL,
    managerPhone VARCHAR(50) NOT NULL,
	  userID INT NOT NULL,
    FOREIGN KEY (userID) REFERENCES Users(userID)
);
-- Таблица запчастей
CREATE TABLE Parts (
    partID INT PRIMARY KEY,
    partsName VARCHAR(100) NOT NULL,
    partsDescription VARCHAR(255) NOT NULL,
    stockQuantity INT NOT NULL,
    price DECIMAL(10, 2) NOT NULL
);
-- Таблица для хранения информации о заказанных запчастях и материалах
CREATE TABLE PartsOrders (
    orderID INT PRIMARY KEY,
    requestID INT NOT NULL,
  	partID INT NOT NULL,
  	quantity INT NOT NULL,
    orderDate DATE NOT NULL,
    FOREIGN KEY (requestID) REFERENCES Requests(requestID),
	  FOREIGN KEY (partID) REFERENCES Parts(partID)
);
-- Таблица отзывов клиентов
CREATE TABLE ClientsReviews (
    reviewID INT PRIMARY KEY,
    requestID INT NOT NULL,
    rating INT NOT NULL,
    comment VARCHAR(255) NOT NULL,
    reviewDate DATE NOT NULL,
    qrCode VARCHAR(255) NOT NULL,
    FOREIGN KEY (requestID) REFERENCES Requests(requestID)
);
--Таблица для связи мастеров и менеджеров по качеству 
CREATE TABLE MasterQualityManager (
    connectID INT PRIMARY KEY,
    masterID INT NOT NULL,
    managerID INT NOT NULL,
    requestID INT NOT NULL,
    appealReason VARCHAR(255) NOT NULL,
    appealDate DATE NOT NULL,
    FOREIGN KEY (masterID) REFERENCES Masters(masterID),
    FOREIGN KEY (managerID) REFERENCES Managers(managerID),
    FOREIGN KEY (requestID) REFERENCES Requests(requestID)
);

