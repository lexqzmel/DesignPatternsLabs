# DesignPatternsLabs

Представлено розроблений інтернет-магазин, орієнтований на продаж таблеток.
>- Користувач при відкритті магазину бачить список доступних товарів, їхні ціни та виробника даного товару.
>- Після вибору товару, користувачу надається вибір способу оплати, який зручніший клієнту. У магазині ідентифіковано такі способи оплати як банківський переказ, оплата кредитною картою та PayPal.
>- Після вибору способу оплати, клієнт може обрати спосіб доставки. Доставки відбуваються через мережі "УкрПошта" та "НоваПошта". Відповідно до послуг, які можуть бути надані даними поштами користувач може обрати курьерську доставку, забрати з вибраного відділення пошти, а також з поштомата (доступно лише для мережі "Нова пошта").
   
#### **Лабораторна робота №1.** 	
##### > Фабричний метод застосований для вибору способу оплати.
>- Абстрактний клас PaymentMethod визначає інтерфейс класу, об'єкти якого треба створювати.
>- Конкретні класи BankPayment, PayPalPayment і CreditCardPayment представляють
реалізацію класу PaymentMethod.
>- Клас PaymentMethodFactory визначає фабричний метод CreatePayment(), який повертає об'єкт Product.
>- Конкретні класи ConcreteCreatorA і ConcreteCreatorB - спадкоємці класу Creator, що визначають свою реалізацію методу FactoryMethod (). Причому метод FactoryMethod () кожного окремого класу-творця повертає певний конкретний тип продукту. Для кожного конкретного класу продукту визначається свій конкретний клас творця.
##### > Абстрактна фабрика застосована для вибору способу доставки.
  
