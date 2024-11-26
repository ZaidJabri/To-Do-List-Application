# To-Do List Application
This is a basic To-Do Application built using ASP.NET Core MVC 8.

The approach I have used involves the following steps:

1- Create the Model (TaskItem), which contains the following properties:
   - ID
   - Title 
   - IsCompleted

2- Create a Service and Interface, then inject them into the Controller to separate business logic from data access.

3- Create a Task Controller to call the Service and handle the business logic.

4- Implement the Index View, where I created the necessary logic to store tasks in a List without persisting the data.

# Optional Enhancements:
I added functionality to persist the data in Local Storage, along with basic validation.
# Note
In the Index View, you will find only the logic for persisting the data.
