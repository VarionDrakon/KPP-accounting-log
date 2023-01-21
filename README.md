<hr>
Ru:

Программа для учёта посетителей проходящих через КПП. Имеет возможности смены профиля и простую запись в текстовые файлы. При записи учитывает время и дату (Автоматически), цель и ФИО посетителя (Вручную вписывается), при выходе посетителя указывается только ФИО вписывается, остальное подставляется автоматически, проект создан на .NetCore 6 консольное приложение. Проект создан в целях ознакомления и изучения таких принципов ООП в C# как - Абстракция, Наследование, Полиморфизм и Инкапсуляция.

Так как программа не содержит подключения к базам данных, всё хранится в текстовых файлах. Пароль и логин для авторизации  указывается вручную пользователем. Если не будет файла, программа скажет об этом.

Файл авторизации находится по пути "Users/token.txt". Сюда вписываются пользователи. Для того чтобы новый пользователь был добавлен после обновления файла, необходимо снова авторизироваться, то есть, программа не требует перезапуска при добавлении пользователей.

En:

A program for tracking visitors passing through the checkpoint. It has the ability to change the profile and a simple entry into text files. When recording, it takes into account the time and date (Automatically), the purpose and the visitor's full name (Manually entered), when the visitor exits, only the full name is entered, the rest is substituted automatically, the project is created on .NETCore 6 is a console application. The project was created in order to familiarize and study such principles of OOP in C# as Abstraction, Inheritance, Polymorphism and Encapsulation. 

Since the program does not contain database connections, everything is stored in text files. The password and login for authorization are specified manually by the user. If there is no file, the program will tell you about it.

The authorization file is located on the path "Users/token.txt ". Users fit in here. In order for a new user to be added after updating the file, it is necessary to log in again, that is, the program does not require restarting when adding users.
<hr>
Screenshots:

![Authotization Screen](https://user-images.githubusercontent.com/52794446/213883551-718d1d80-c6fd-4a2e-ad71-2a5176e17103.png) Authotization Screen

![LogFile](https://user-images.githubusercontent.com/52794446/213883552-47d4556c-8640-4653-8f93-9f0d8bf19f10.png) Log File 

![MainScreen](https://user-images.githubusercontent.com/52794446/213883553-1e15d565-6211-4efc-af27-49251868908b.png) Main Screen

![MainScreenEnterText](https://user-images.githubusercontent.com/52794446/213883554-2aa632ab-903a-4f0e-a661-058b2cbb6050.png) Main Screen Enter Text

![NotTokenFile](https://user-images.githubusercontent.com/52794446/213883557-416a9f44-b9e9-4d55-8196-e06998b0c095.png) Not Token File

![TokenFile](https://user-images.githubusercontent.com/52794446/213883560-1d0ead47-9561-41f4-85d3-b76ba8ab3b9a.png) Token File

<hr>
Licence:

Ru: Все ресурсы и код находятся под лицензией CC BY и в общественном достоянии, если не указано иное.

En: All assets and code are under the CC BY LICENSE and in the public domain unless specified otherwise.
