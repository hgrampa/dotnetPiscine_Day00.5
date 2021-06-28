# Day 00.5 Чек-листы

## Общее

1. Выполнены ли общие требования?
2. Проверяемый может объяснить работу программы?
3. Названы ли переменные осмысленно и функционально?
4. Отсутствуют ли в коде хардкод и &quot;магические числа&quot;?
5. Соответствует ли код [C# Coding Conventions](https://docs.microsoft.com/ru-ru/dotnet/csharp/programming-guide/inside-a-program/coding-conventions)?
6. Программа запускается?
7. Находится ли каждый класс в отдельном файле с соответствующим названием?

## Задание 00

1. Реализован ли в классе _Storage_ единственный конструктор, принимающий int значение и заполняющий им количество товаров склада?
2. Содержит ли класс _Storage_ метод _IsEmpty() =\&gt;_ возвращающий равенство количества товаров нулю?

## Задание 01

1. Содержит ли _Customer_ единственный конструктор класса, принимающий параметры типа string и int и заполняющий ими имя и номер покупателя?
2. Являются ли свойства, отражающие имя и номер класса _Customer,_ открытыми для чтения и закрытыми для редактирования вне класса?
3. Переопределен ли в классе метод ToString()?
4. Переопределен ли в классе метод Equals()?
5. Выведет ли следующий код true?

```
var customer1 = new Customer(&quot;Andrew&quot;, 1);

var customer2 = new Customer(&quot;Andrew&quot;, 1);

Console.WriteLine(customer1 == customer2);

```

## Задание 02

1. Является ли свойство, отражающие количество товаров класса _Customer,_ открытым для чтения и закрытым для редактирования вне класса?
2. Содержит ли класс _Customer_ метод _FillCart(),_ принимающий параметр типа int и заполняющий поле с количеством товаров рандомным числом от 1 до значения входного параметра?

## Задание 03

1. Содержит ли _CashRegister_ единственный конструктор класса, принимающий параметр типа int и заполняющий им заголовок кассы?
2. Является ли свойство, отражающие заголовок класса _CashRegister,_ открытым для чтения и закрытым для редактирования вне класса?
3. Переопределен ли в классе метод ToString()?
4. Переопределен ли в классе метод Equals()?
5. Содержит ли класс коллекцию Queue\&lt;Customer\&gt;?

## Задание 04

1. Реализован ли в классе _Store_ единственный конструктор, принимающий два различных int параметров и создающий для них склад с нужным количеством товаров и коллекцию нужного количества касс?
2. Содержит ли класс _Store_ метод _IsOpen() =\&gt;_ возвращающий значение заполненности склада?

## Задание 05

1. Является ли класс _CustomerExtensions_ статическим?
2. Реализован ли в классе _CustomerExtensions_ статический метод с параметрами _this Customer_ и коллекцией _CashRegister,_ выбирающий из списка касс кассу с наименьшим количеством покупателей в очереди?
3. Реализован ли в классе _CustomerExtensions_ статический метод с параметрами _this Customer_ и коллекцией _CashRegister,_ выбирающий из списка касс кассу с наименьшим количеством товаров у покупателей в очереди?

## Задание 06

1. Реализован ли цикл while с условием по значению метода Store.IsOpen() для каждого из двух описанных случаев?
2. Реализовано ли уменьшение количества товаров на складе при заполнении корзины покупателя товарами?
3. Реализован для каждого витка цикла вывод в консоль имени пользователя и его номера, количества товаров, выбранной им кассы и количества людей на кассе, количества товаров в корзинах очереди?