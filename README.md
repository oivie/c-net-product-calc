# c-net-product-calc

# Product Management System - C#.NET Windows Forms Application

## Description:

This application allows users to manage a collection of products. The solution demonstrates the utilization of a linked list data structure to perform various operations on products such as adding, removing, and displaying details. It provides a graphical user interface (GUI) using C#.NET's Windows Forms to interact with the underlying data structure.

## Objectives:

### User Input:
Allow users to input product details, including:

- Product Code
- Product Name
- Product Price

### Linked List Operations:
Implement operations on a linked list of products:

- Add a product in an order based on its price.
- Remove a product based on its name.
- Display all products.

### Data Presentation:
Showcase a tabulated view of all the products, including average price calculations.

### Error Handling:
Implement error handling mechanisms for scenarios like incorrect price format, missing product details, or operations that can't be executed due to linked list constraints (like trying to remove a product that doesn't exist).

## How it's achieved:

### Windows Forms GUI:
The GUI provides text boxes for users to input product details, buttons to perform specific operations, and a grid view to display all the products.

### Event-Driven Programming:
Each button press on the form triggers an associated event handler that processes the user's request and provides feedback.

### Data Structure:
A `LinkedList<Product>` named `products` stores all the products. The `Product` class represents individual products with properties like ProductCode, Name, and Price.

### Product Insertion:

- If the products list is empty, the new product is added as the first element.
- Otherwise, the position to insert the new product is determined to keep the list ordered by price.

### Product Removal:

- Users can remove a product by its name. The app searches for the product and removes it if found.

### Data Retrieval:

- The `btnDisplay_Click` event handler fetches all the products from the linked list and binds them to a grid view for display. It also calculates and displays the total number of products and their average price.

### Error Handling and Feedback:

- Error handling is achieved using try-catch blocks to capture exceptions that might arise.
- Feedback messages, either confirming successful operations or indicating errors, are displayed using `MessageBox`.

## Conclusion:

This application provides a comprehensive demonstration of manipulating a linked list data structure in a real-world scenario using C#.NET. By integrating event-driven GUI programming with business logic implementation, the app offers an efficient and user-friendly system for managing products.

