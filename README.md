# Library

####  C# and .NET Advanced Databases and Authentication - _01/22/2020_

#### _By **Uriel Gonzalez**_

## Description

DETAILED DESCRIPTION

The user can:

Add, view, edit, search and delete one or multiple authors.
Add, view, edit, search and delete one or multiple books.
The user can check-in / check-out.

## Setup/Installation Requirements

1. Clone this repository:
    ```
    $ git clone REPO URL HERE
    ```
2. Run the application
    ```
    $ dotnet run
    ```
## Database Setup

```sh
1. mysql start
2. Access MySql by executing the command: `mysql -uroot -pepicodus`
3. CREATE DATABASE `library`
4. USE `library`
5. CREATE TABLE `Authors` (`AuthorsId` int(11) NOT NULL AUTO_INCREMENT, `Name` varchar(255) DEFAULT NULL, PRIMARY KEY (`AuthorId`))
6. CREATE TABLE `Books` (`BookId` int(11) NOT NULL AUTO_INCREMENT, `Description` varchar(255), `UserId` int(11), PRIMARY KEY (`BookId`))
7. CREATE TABLE `AuthorBook` (`AuthorBookId` int(11) NOT NULL AUTO_INCREMENT, `BookId` int(11) NOT NULL, `AuthorId` int(11) NOT NULL, PRIMARY KEY (`AuthorBookId`))
8. Run program with dotnet run (or $ dotnet watch run).

```
OR
* > dotnet restore, dotnet ef migrations add addIdentity, dotnet ef migrations add Authorization, dotnet ef database update

## Known Bugs
* No known bugs at this time.

## Technologies Used
* C# / .NET

## Support and contact details

_Please contact Uriel Gonzalez with questions and comments._

### License

*GNU GPLv3*

Copyright (c) 2019 **_Uriel Gonzalez_**
