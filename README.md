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

#### **Лабораторна робота №3.**
##### > Паттерн Стратегія застосований для реалізації вибору оплати(готівка або картка).
_Є кілька споріднених класів, які відрізняються поведінкою. Можна задати один основний клас, а різні варіанти поведінки винести в окремі класи і при необхідності їх застосовувати_
>- Інтерфейс IPaymentStrategy, який визначає метод Pay (). Це загальний інтерфейс для всіх реалізуючих його алгоритмів. Замість інтерфейсу тут також можна було б використовувати абстрактний клас.
>- Класи CreditCard і Cash, які реалізують інтерфейс IPaymentStrategy, надаючи свою версію методу Pay (). Подібних класів-реалізацій може бути безліч.
>- Клас PaymentS зберігає посилання на об'єкт IPaymentStrategy і пов'язаний з інтерфейсом IPaymentStrategy ставленням агрегації(адже вкладений об'єкт може існувати незалежно від класу, тобто не є складовою класу).
##### > Паттерн Спостерігач застосований для створення можливості спостереження за наявністю товарамів(користувач отримує повідомлення при наявність товару за яким він стежив).
_Коли загальна схема взаємодії об'єктів передбачає дві сторони: одна розсилає повідомлення і є головним, інша отримує повідомлення і реагує на них_
>- IProduct: представляє спостережуваний об'єкт. Визначає три методи: AddObserver () (для додавання спостерігача), RemoveObserver () (видалення спостерігача) і NotifyObservers () (повідомлення спостерігачів).
>- Product: конкретна реалізація інтерфейсу IProduct. Визначає колекцію об'єктів спостерігачів.
>- IObserver: представляє спостерігача, який підписується на всі повідомлення, що спостерігається. Визначає метод Update (), який викликається спостережуваним об'єктом для повідомлення спостерігача.
>- Observer: конкретна реалізація інтерфейсу IObserver.
##### > Паттерн Команда застосований для створення можливості користувачу взаємодіяти з кошиком(додавання, віднімання та видалення товарів з нього).
_Необхідно забезпечити виконання у черзі запитів, а також їх можливе скасування_
>- ICommand: інтерфейс, який представляє команду. Визначає метод Execute () для виконання дії.
>- AddCommand/DeleteCommand/SubtractCommand: конкретна реалізація команди, реалізує метод Execute (), в якому викликається певний метод, визначений в класі CartProduct.
>- CartProduct: одержувач команди. Визначає дії, які повинні виконуватися в результаті запиту.
>- CartProductOption: ініціатор команди - викликає команду для виконання певного запиту.

#### **Лабораторна робота №4.**
##### > Паттерн Макрокоманди застосований для надання інструментів керування адміністратору(перевірка оплати, підтвердження замовлення, відправлення замовлення до клієнта (для виконання декількох команд використовується MacroCommands). При помилці передбачено метод, що скасовує всі команди).
_Для управління набором команд_
>- Command: інтерфейс, який представляє команду. Визначає метод Execute () для виконання дії та Undo () для скасування.
>- Клас MacroCommands, ініціатор - додає в список виконання команди.
>- Класи OrderConfirmationCommand/OrderShippingCommand/PaymentCheckCommand реалізують команди перевірки Order та виконують методи наслідувані з інтерфейсу Command: Execute () та Undo (), а також є отримувачами команди.
>- Клас Order містить інформацію про замовлення.
##### > Паттерн Шаблонний метод застосований для створення програми лояльності покупців(проста версія та преміум).
_Коли загальна схема взаємодії об'єктів передбачає дві сторони: одна розсилає повідомлення і є головним, інша отримує повідомлення і реагує на них_
>- LoyaltyProgramTemplate: визначає шаблонний метод RewardCustomer (), який реалізує алгоритм. Алгоритм може складатися з послідовності викликів інших методів(GiveDiscount/GiveFreeItem/GivePoints), які є абстрактними і перевизначаються в класах-наслідниках. При цьому сам метод RewardCustomer (), що представляє структуру алгоритму, не перевизначається.
>- EverydayVersionLoyalty/PremiumVersionLoyalty: підкласи, які перевизначають різні методи батьківського класу.
>- Customer: клас, який містить дані про загальні покупки, кількість запрошень, знижку та бали. Також виконує дії, які призводять до нагородження.
