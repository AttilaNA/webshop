# WebShop

## Goal of the project

* Create an ASP.NET Core web application using an in-memory database through the DAO (Data Access Object) pattern.
* Use the DAO design pattern and dependency injection.
* Handle fractional monetary unit appropriately with decimal.
* Advanced OOP concepts, such as inheritance, are used in the project. There is at least one interface implemented.
* The project maintains the MVC architectural pattern.
* The project maintains the three-layer structure of controllers handling HTTP, service objects handling business logic, and DAOs handling data access.

## Tasks

### *Create environment*

I want to have a version-controlled project, where a webserver serves requests. This allows me to start developing in a sandboxed environment.

1. When starting up the ASP.NET Core application web-server, the server returns an index page.

### *Product list*

I want to have an index page, where I can see the list of Products.

1. Opening the root URL (/) displays a list of all Products with details such as product title, description, image, price.

### *Products by Category*

I want to have an index page, where I can filter Products by Product Categories.

1. There are Products and Product Categories listed on the index page.
2. Clicking on the title of a Category displays Products only in the selected Category.

### *Products by Supplier*

I want to have an index page where I can filter Products by Suppliers.

1. There are Products and Suppliers listed on the index page.
2. Clicking on the name of a Supplier displays the Products only for the selected Supplier.

### *Add to Cart*

I want to have a Shopping Cart so that I can add products which I want to buy.

1. In the Product list, the Products have an "Add to cart" button. Clicking the "Add to cart" button creates a new Order for storing cart data and a new LineItem with the quantity (default: 1) of the Product. This data is stored on the server.
2. In the Product list, the Products have an "Add to cart" button. Clicking the "Add to cart" button displays the number of cart items in the Page header

### *Review cart*

As a User, I want to review the contents of my Shopping Cart before checking out.

1. When the Shopping Cart has items in it, clicking "Shopping cart" in the Page header displays the items with their data, such as name of the Product, quantity, unit price / subtotal price.
2. When the Shopping Cart has items in it, clicking "Shopping cart" in the Page header displays the total price of all the items in the cart.

### *Edit cart*

As a User, I want to edit the quantity of items, or remove items from my Shopping Cart.

1. On the Shopping Cart review page, the items are displayed, and the quantities are displayed as well. Changing the quantity of an item stores the new quantity of the items.
2. On the Shopping Cart review page, items are displayed, and the quantities are displayed as well. Changing the quantity of an item to 0 removes the item from the cart.