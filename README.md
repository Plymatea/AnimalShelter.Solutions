# Animal Shelter API

#### By Andy Plymate

#### Animal Shelter: Building an API   
* An API for use in a animal shelter. Specifically to intereact with Animals present.

## Technologies Used
* ASP.NET Core
* C#
* EF Core Migrations
* SQL
* MySQLWorkbench
* Swagger

## Description

A example project that uses RESTful api routing to display animals in an animal shelter. 

## Setup/Installation Requirements
* _Requires VSCode and MySql_

* _You can find the github repository [here](https://github.com/Plymatea/AnimalShelter.Solutions.git)_
* _In your preferred terminal, navigate to the directory you would like to store the project_
* _$ `git clone https://github.com/Plymatea/AnimalShelter.Solutions.git`_
* _Now that the repository is cloned to your computer, right click on the folder and click "open with vs code"_

_**In order to access a usable version of the sql database you will need to do the following:**_

* _Create a file named appsettings.json in the Bakery directory_
* _The file should contain this block of code with your own username and password for the server ( [ ] brackets as well as information inside brackets are private information and not included):_
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=to_do_list;uid=[Your Id Goes Here];pwd=[Your Password Here];"
  }
}
```
* _$ `dotnet build`_
* _$ `dotnet ef database update`_

 * _Once all of the above is completed you can view the project on your local server by running "dotnet run"_


## Swagger
* After running `dotnet run` command in your terminal you can see the swagger documentation at `http://localhost:5000/swagger` in your browser. 


## API Endpoints
* Base URL: `http://localhost:5000`

### **GET:** `/api/animalshelter/animals`
<pre>{
  "type": "string",
  "name": "string",
  "gender": "string",
  "age": 0
}</pre>
### **POST:** `/api/animalshelter/animals`
* 
<pre>{
  "type": "string",
  "name": "string",
  "gender": "string",
  "age": 0
}</pre>

### **GET:** ***/api/animalshelter/animals/{id}***
* To retrieve an individual animal

### **PUT:** ***/api/animalshelter/animals/{id}***
* 
<pre>{
  "animalId": 0
  "type": "string",
  "name": "string",
  "gender": "string",
  "age": 0
}</pre>

### **DELETE** ***/api/animalshelter/animals/{id}***
* To delete an animal

## Known Bugs

* No known bugs at this time.

## License - [MIT](https://opensource.org/licenses/MIT)


Copyright (c) _2022_ _Andy Plymate_