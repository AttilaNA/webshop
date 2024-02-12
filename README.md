# WebShop

## Goal of the project

* Create an ASP.NET Core web application using an in-memory database through the DAO (Data Access Object) pattern.
* Use the DAO design pattern and dependency injection.
* Log data in a specified format.
* Handle fractional monetary unit appropriately with decimal.
* Advanced OOP concepts, such as inheritance, are used in the project. There is at least one interface implemented.
* The project maintains the MVC architectural pattern.
* The project maintains the three-layer structure of controllers handling HTTP, service objects handling business logic, and DAOs handling data access.
* Use fake payment implementations. It is not required to integrate real payment services.

## Tasks

### _Create environment_

I want to have a version-controlled project, where a webserver serves requests. This allows me to start developing in a sandboxed environment.

1. When starting up the ASP.NET Core application web-server, the server returns an index page.

### _Product list_

I want to have an index page, where I can see the list of Products in a default Product Category.

1. There are Products and a default Product Category in the application. Opening the root URL (/) displays a list of Products with details such as product title, description, image, price.



### _..._