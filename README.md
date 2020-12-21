# Test_Task
In this project, the backend and interface are located in the same directory, but they must be run separately.

In order to start working with Backend, you need to install a visual studio.

You need to open the file "Test_Task.sln" through the visual studio.

Then wait for Nuget packages to be installed automatically.

In the "Package Manager Console" enter the command "update-database", the migrations created by me will automatically create a database for you.
* So we do not need a backup of the database

Then on Solution Platform select from all parameters only "IIS Express", start the project. If you did everything correctly, a tab will start in the browser, to which the frontend will have access via http-requests.
* My device automatically opens Google Chrome, the address of the frontend connection to the backend will be highlighted in the address field, it looks like this: https://localhost:44398/api/Users

To get started with the Frontend part, you need to install the Visual Studio code program as well as Node.js

You need to open the ClientApp folder in the Visual Studio code.

You need to enter "npm install" in the terminal, then it will automatically download all the necessary packages.

* If we want to change the frontend connection addresses, we need to open the config.json file. Path to this file: Test_Task\Test_Task\clientapp\src\components\config\config.json

To start the project (after installing all the necessary packages), enter the term in the terminal - "npm start".

This will launch Frontend, which will contact Backend via HTTP requests, and the page will display the data received from Backend.

SQL queries to test the application:

* INSERT INTO Users (Name, Age) VALUES('Vadem', 44)
* DELETE FROM Users WHERE Id = 7
* UPDATE Users SET Name = 'Viktoria', Age = 75 WHERE Id = 5
* SELECT * FROM Users WHERE Id = 5
* SELECT * FROM Users WHERE Name= 'Vova'
* INSERT INTO Users (Name, Age) VALUES('Vova', 44)
* SELECT * FROM Users WHERE Name= 'Vova'
* DELETE FROM Users WHERE Name = 'Vadem'
