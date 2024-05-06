# DesignPatternsLabs (Письменюк)

Представлено розроблений інтернет-магазин, орієнтований на продаж таблеток.
>- Користувач при відкритті магазину бачить список доступних товарів, їхні ціни та виробника даного товару.
>- Після вибору товару, користувачу надається вибір способу оплати, який зручніший клієнту. У магазині ідентифіковано такі способи оплати як банківський переказ, оплата кредитною картою та PayPal.
>- Після вибору способу оплати, клієнт може обрати спосіб доставки. Доставки відбуваються через мережі "УкрПошта" та "НоваПошта". Відповідно до послуг, які можуть бути надані даними поштами користувач може обрати курьерську доставку, забрати з вибраного відділення пошти, а також з поштомата (доступно лише для мережі "Нова пошта").
>- Користувачу надано можливість авторизації та отримування сповіщень про наявність товару, за яким користувач стежив.
>- Адміністратору надано інструменти для підтверження замовлень.
>- Надано інструменти для робоити зі списком товарів (додававання товару у список, виведення списку товарів, отримання інформації про кількість товарів).
>- Користувачу надано можливість переглядати стан замовлення( нове, оплачене та відправлене).
>- Адміністратору надано інструменти системи обробки запитів(запити на виконання замовлення, оплату та покупку).
>- Користувачу надано можливість виконувати пошук таблеток у магазині(за виробником, назвою, ціною та типом, використовуючи логічні "І" та "Або").
>- Адміністратору надано можливість проводити знижки на товари у магазині(від початку знижки ціна знижується, а після закінчення - повертається до початкової).
>- Адміністратору надано інструменти звітності(створюється звіт про продажі магазину).
>- Користувачу надано можливість отримати підтримку через центр підтримки користувачів(гаряча лінія та електронна пошта).
   
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

#### **Лабораторна робота №5.**
##### > Паттерн Ітератор застосований для надання інструментів роботи зі списком товарів(додававання товару у список, виведення списку товарів, отримання інформації про кількість товарів).
_Коли необхідно надати кілька альтернативних варіантів перебору одного і того ж об'єкта та коли є набір складових об'єктів, і треба забезпечити єдиний інтерфейс
для їх перебору_
>- IAbstractIterator: визначає інтерфейс для обходу складових об'єктів.
>- IAbstractCollection: визначає інтерфейс для створення об'єкта-ітератора.
>- Iterator: конкретна реалізація ітератора для обходу об'єкта IAbstractCollection. Для фіксації індексу поточного перебраного елемента використовує цілочисельну змінну Current.
>- ProductList: конкретна реалізація IAbstractCollection. Зберігає елементи, які треба буде перебирати.
>- Program: використовує об'єкт IAbstractCollection і ітератор для його обходу.
##### > Паттерн Стан застосований для створення можливості користувачу переглядати стан замовлення(нове/оплачене/відправлене).
_Коли поведінка об'єкта повинна залежати від його стану і може змінюватися динамічно під час виконання_
>-  IOrderState: визначає інтерфейс стану.
>-  Класи NewOrderState, PaidState і SentOrderState - конкретні реалізації станів.
>- Order: представляє об'єкт, поведінка якого має динамічно змінюватися відповідно до стану. Виконання ж конкретних дій делегується об'єкту стану.
##### > Паттерн Ланцюжок Обов'язків застосований для надання інструментів створення системи обробки запитів(запити на виконання замовлення, оплату та покупку).
_Коли є більше одного об'єкта, який може обробити певний запит_
>- RequestHandler: визначає інтерфейс для обробки запиту. Також може визначати посилання на наступний оброблювач запиту.
>- OrderHandler, PaymentHandler і ShoppingHandler: конкретні обробники, які реалізують функціонал для обробки запиту. При неможливості обробки і наявності посилання на наступний оброблювач, передають запит цьому оброблювачу.
>- Client: відправляє запит об'єкту Handler.

#### **Лабораторна робота №6.**
##### > Паттерн Інтерпретатор застосований для надання можливості користувачам виконувати пошук таблеток у магазині(за виробником, назвою, ціною та типом, використовуючи логічні "І" та "Або").
_Коли застосовується для часто повторюваних операцій і треба визначити власний синтаксис_
>- AbstractExpression: визначає інтерфейс вираження, оголошує метод Interpret ().
>- TerminalExpression (ProducerExpression/TitleExpression/PriceExpression/TypeExpression): термінальний вираз, реалізує метод Interpret () для термінальних символів граматики. Для кожного символу граматики створюється свій об'єкт TerminalExpression
>- NonterminalExpression (AndExpression/OrExpression): нетермінальний вираз, представляє правило граматики. Для кожного окремого правила граматики створюється свій об'єкт NonterminalExpression.(продовжується вглиб по всім входящим вершинам/аргументам)
>- Context: містить загальну для інтерпретатора інформацію. Може використовуватися об'єктами термінальних і нетермінальних виразів для збереження стану операцій і подальшого доступу до збереженого стану.
>- Program: будує речення мови з даною граматикою у вигляді абстрактного синтаксичного дерева, вузлами якого є об'єкти TerminalExpression і NonterminalExpression.
##### > Паттерн Посередник застосований для оплати замовлення, яке є у кошику(PayPal або кредитна картка).
_Коли є безліч взаємопов'язаність об'єктів, зв'язки між якими складні і заплутані_
>- Mediator: представляє інтерфейс для взаємодії з об'єктами Cart.
>- Cart: представляє клас для взаємодії з об'єктом Mediator.
>- IPayment: інтерфейс, який визначає можливість та тип оплати.
>- PayPalPayment і CreditCardPayment: конкретні класи оплати, які обмінюються між собою та Cart через об'єкт Mediator.

#### **Лабораторна робота №7.**
##### > Паттерн Зберігач застосований для створення можливості проводити знижки на товари у магазині(від початку знижки ціна знижується, а після закінчення - повертається до початкової).
_Коли потрібно зберегти стан об'єкта для можливого подальшого відновлення_
>- Memento: охоронець, який зберігає стан об'єкта Product і надає повний доступ тільки цього об'єкту Product.
>- Product: створює об'єкт зберігача для збереження свого стану.
>- Caretaker: виконує тільки функцію зберігання об'єкта Memento, в той же час у нього немає повного доступу до зберігача і ніяких інших операцій над зберігачем, крім власного збереження, він не виробляє.
##### > Паттерн Відвідувач застосований для створення інструменту для звітності(створюється звіт про продажі магазину).
_Коли класам необхідно додати однаковий набір операцій без зміни цих класів_
>- IVisitor: інтерфейс користувача, який визначає метод Visit () для кожного об'єкта Order.
>- SalesReportVisitor: конкретний клас відвідувача, реалізує інтерфейс, визначений в Visitor.
>- Order: визначає та реалізує метод Accept (), в якому в якості параметра приймається об'єкт Visitor.

#### **Лабораторна робота №8.**
##### > Паттерн Фасад застосований для спрощення реалізації реєстрації клієнта(введення даних, відправлення листа на пошту, підтвердження).
_Коли є складна система, і необхідно спростити з нею роботу. Фасад дозволить визначити одну точку взаємодії між клієнтом і системою_
>- Класи CustomerDataAccessLayer/Email/Validator є компонентами складної підсистеми, з якими повинен взаємодіяти клієнт.
>- Customer взаємодіє з компонентами підсистеми.
>- CustomerRegistration - безпосередньо фасад, який надає інтерфейс клієнта для роботи з компонентами.
##### > Паттерн Замісник застосований для реалізації зовнішнього вигляду товару(зображення на сторінці товару).
_Коли потрібно управляти доступом до ресурсу, створення якого вимагає великих витрат. Реальний об'єкт створюється тільки тоді, коли він дійсно може знадобиться, а до цього всі запити до нього обробляє проксі-об'єкт._
>- IImageLoader: визначає загальний інтерфейс для Proxy і RealSubject. Тому ImageLoaderProxy може використовуватися замість ImageLoader.
>- ImageLoader: представляє реальний об'єкт, для якого створюється проксі
>- ImageLoaderProxy: замісник реального об'єкта. Зберігає посилання на реальний об'єкт, контролює до нього доступ, може управляти його створенням і видаленням. При необхідності ImageLoaderProxy переадресує запити об'єкту ImageLoader.
>- Program: клас у якому створюється об'єкт Customer, який використовує об'єкт ImageLoaderProxy для доступу до об'єкта ImageLoader.
##### > Паттерн Міст застосований для реалізації підтримки користувачів(гаряча лінія та електронна пошта).
_Коли треба уникнути постійної прив'язки абстракції до реалізації_
>- ContactCustomerSupport: зберігає посилання на об'єкт ContactCenter. Виконання операцій в Customer делегується методам об'єкта ContactCenter.
>- ContactCenter: визначає базовий інтерфейс для конкретних реалізацій. Як правило, ContactCenter визначає тільки примітивні операції.
>- EmailContactCenter і PhoneContactCenter: конкретні реалізації, які наслідуванні від ContactCenter.
>- Customer: використовує об'єкти ContactCustomerSupport.


