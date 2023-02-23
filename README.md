# AyoWebAPI

AYOAPI

Its a Web API project used to convert Metric units to Imperial units and vice versa. This visual studio solutions contains two project
1. Web API
2. xUnit Testing Project

Project Screen Shot(s)
Example:
![image](https://user-images.githubusercontent.com/10631138/220929349-6d7af830-6357-4d7a-bcb8-a83a94c417bb.png)

![image](https://user-images.githubusercontent.com/10631138/220929965-2b36ee96-8564-4301-a004-288a99788afb.png)

Installation and Setup Instructions
Example:
Clone down this repository. You will need visual studio installed on your machine.

1. Open the solution file (AYOAPI.sln) using visual studio.
2. Change the connection string for sql server database connection in appsettings.json file. (Note: only change the server name and sql server login credentials)
3. Build the soultion and install all the dependecies after changing the connection string.
4. Open Package Manager Console in visual studio menu
![image](https://user-images.githubusercontent.com/10631138/220937213-35260940-5c24-460f-af78-088b43d574e8.png)
5. Type the update database command of the entity framework i.e. Update-Database inside the Package Manager Console and hit enter.
![image](https://user-images.githubusercontent.com/10631138/220938375-6d76fbc0-e9e0-4c3e-b0f5-aa3111895ef1.png)
6. This command will create the database and unit conversion rate table.
7. Now run the application thorugh the Ctrl+F5 or using the below snapshot and convert the metric units to imperial units.
![image](https://user-images.githubusercontent.com/10631138/220939670-162923b7-5d5b-428e-a441-a88830229e4d.png)
8. User can also test the code from xUnit test project.

Note: User can successfully convert the only unit which are defined below. For others usings, It will show a message $"Conversion rate is not defined for the unit {fromUnit} to {toUnit}.";

   Metric units <=> Imperial units
1. kilometer <=> mile
2. kilometer <=> foot
3. meter <=> foot
4. meter <=> inch
5. centimeter <=> inch
6. millimeter <=> inch
7. liter <=> quart
8. liter <=> gallon
9. milliliter <=> cup
10. milliliter <=> ounce
11. celsius <=> fahrenheit
12. kilogram <=> ton
13. kilogram <=> pound
14. gram <=> ounce
15. gram <=> pound
16. milligram <=> ounce
