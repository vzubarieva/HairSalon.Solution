# Hair Salon "Eau Claire's Salon"

#### By: Viktoriia Zubarieva

## Description

MVC web application is cleated to help manage hair salon employees (stylists) and their clients. An owner should be able to add a list of stylists working at the salon, and for each stylist, add clients who see that stylist. The stylists have specific specialties, so each client can only see (belong to) a single stylist.

![schema-hair-salon](/img/schema.png)

## Technologies Used

- C#
- .Net 5.0
- git
- ASP.NET Core MVC
- Entity Framework
- My SQL Workbench

## Technology Requirements

.NET 5
A text editor like VS Code

## Setup/Installation Requirements

- Clone this project to your desktop with the link provided on the its Github [repository](https://github.com/vzubarieva/HairSalon.Solution)
- Navigate to the top level of the directory
- Create appsettings.json in main project directory /HairSalon.Solution/HairSalon/
- Copy this code into appsettings.json, replacing YOUR_PASSWORD with your MySQL password
  {
  "ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Port=3306;database=viktoriia_zubarieva;uid=root;pwd=YOUR_PASSWORD;"
  }
  }
- open new terminal and run SQL $ mysql -uroot -p{your_password}
- open MySQL Workbench
- In the Navigator > Administration window, select Data Import/Restore.
- In Import Options select Import from Self-Contained File
- Navigate to viktoriia_zubarieva.sql
- Under Default Schema to be Imported To, select the New button & Enter viktoriia_zubarieva as name of database
- Click Ok
- Navigate to the tab called Import Progress and click Start Import at the bottom right corner of the window
- After you are finished with the above steps, reopen the Navigator > Schemas tab. Right click and select Refresh All. The viktoriia_zubarieva database should appear.
- In terminal, navigate into HairSalon.Solution/HairSalon/ and enter the command $ dotnet restore, to install necessary packages
- enter command $ dotnet build, to build program
- enter command $ dotnet run, to view application in your browser

## Known Bugs

- _No known bugs_

## License

_Message to viktoria.dubinina@gmail.com with any comments or contributions. This software is licensed under the MIT license_

Copyright (c) _July 2022_ _Viktoriia Zubarieva_
cd
