# Test_Task
In this project, the backend and frontend are located in the same directory, but they must be run separately.

In order to start working with Backend, you need to have a visual studio installed.

You need to open the file "Test_Task.sln" through the visual studio.

Then wait for the Nuget packages to be automatically installed.

Then in the Solution Platform select from all options only "Test_Task", start the project. If you have done everything correctly, a tab will start in the browser, which will be accessed by the frontend via http requests.

In order to start working with the Frontend part you need to have the visual studio code program installed, as well as Node.js

You need to open the ClientApp folder in the visual studio code.

In the terminal must enter - "npm install", then it will automatically download all the necessary packages.

To start the project (after installing all the required packages), enter the term in the terminal - "npm start".

This will launch Frontend, which will contact Backend via HTTP requests and the page will display the data received from Backend.

*SQL queries that tested the application

*INSERT INTO Users (Name, Age) VALUES('Vadem', 44)
*DELETE FROM Users WHERE Id = 7
*UPDATE Users SET Name = 'Viktoria', Age = 75 WHERE Id = 5
*SELECT * FROM Users WHERE Id = 5
*SELECT * FROM Users WHERE Name= 'Vova'
*INSERT INTO Users (Name, Age) VALUES('Vova', 44)
*SELECT * FROM Users WHERE Name= 'Vova'
*DELETE FROM Users WHERE Name = 'Vadem'
