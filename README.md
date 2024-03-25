# DesignPatternsLabs (Письменюк)

Представлено розроблений інтернет-магазин, орієнтований на продаж таблеток.
>- Користувач при відкритті магазину бачить список доступних товарів, їхні ціни та виробника даного товару.
>- Після вибору товару, користувачу надається вибір способу оплати, який зручніший клієнту. У магазині ідентифіковано такі способи оплати як банківський переказ, оплата кредитною картою та PayPal.
>- Після вибору способу оплати, клієнт може обрати спосіб доставки. Доставки відбуваються через мережі "УкрПошта" та "НоваПошта". Відповідно до послуг, які можуть бути надані даними поштами користувач може обрати курьерську доставку, забрати з вибраного відділення пошти, а також з поштомата (доступно лише для мережі "Нова пошта").
>- Користувачу надано можливість авторизації.
   
#### **Лабораторна робота №1.** 	
##### > Фабричний метод застосований для вибору способу оплати(адже логіка роботи підкласів однакова, а конкретний підклас з'ясовується тільки під час виконання програми).
>- Абстрактний клас PaymentMethod визначає інтерфейс класу, об'єкти якого треба створювати.
>- Конкретні класи BankPayment, PayPalPayment і CreditCardPayment представляють реалізацію класу PaymentMethod.
>- Клас PaymentMethodFactory визначає фабричний метод CreatePayment(), який повертає об'єкти BankTransferPayment, CreditCardPayment, PaypalPayMent.
>- У Program.cs створюється об'єкт способу оплати, використовуючи фабричний метод
`PaymentMethod paymentMethod = PaymentMethodFactory.CreatePaymentMethod(selectedPaymentMethodIndex);`
##### > Абстрактна фабрика застосована для вибору способу доставки(групує  фабрики логічно зв'язані одна з одною, а створювані об'єкти використовуються разом і є взаємопов'язаними).
>- Абстрактний клас Delivery визначає інтерфейс для класів, об'єкти яких будуть створюватися в програмі.
>- Конкретні класи BranchDelivery / CourierDelivery і PostomatDelivery представляють конкретну реалізацію абстрактних класів.
>- Абстрактний клас фабрики DeliveryFactory визначає методи для створення об'єктів. Причому методи повертають абстрактні продукти, а не їх конкретні реалізації.
>- Конкретні класи  фабрик NovaPoshtaDeliveryFactory і UkrposhtaDeliveryFactory реалізують абстрактні методи базового класу і безпосередньо визначають які конкретні продукти використовувати.
>- Клієнт використовує клас фабрики для створення об'єктів. При цьому він використовує виключно абстрактний клас фабрики DeliveryFactory і абстрактний клас доставки Delivery ніяк не залежить від їх конкретних реалізацій.  

#### **Лабораторна робота №2.** 	
##### > Паттерн Прототип застосований для реалізації покупки(створення об'єкта для покупки, де буде визначено кількість замовлених таблеток).
_Об'єкт може приймати лише невелике обмежене число станів, а клонування є кращим варіантом, ніж ініціалізація конструктором_
>- PillPrototype: визначає інтерфейс для клонування самого себе, який представляє метод Clone ().
>- Pill - конкретна реалізація прототипу. Реалізує метод Clone ().
>- PillShop: створює об'єкти прототипів за допомогою методу Clone ().
##### > Паттерн Будівельник застосований для створення клієнта(можливість введення даних для ідентифікації користувача).
_Ствоерння нового об'єкта не повиненно залежати від того, з яких частин цей об'єкт складається і як ці частини пов'язані між собою_
>- Client: представляє об'єкт, який повинен бути створений.
>- IClientBuilder: визначає інтерфейс для створення різних частин об'єкта Client.
>- ClientBuilder: конкретна реалізація Buildera. Створює об'єкт Product івизначає інтерфейс для доступу до нього.
>- ClientDirector: розпорядник - створює об'єкт, використовуючи об'єкти ClientBuilder.

