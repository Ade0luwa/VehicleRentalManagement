# PROG 8051 ASSIGNMENT 3

Application Name: Ade Vehicle Rental System

Programming Language used: C#

This application is a Vehicle Rental Management System designed using the following object-oriented principles: inheritance, abstraction, and encapsulation. The classes are developed to represent the different vehicles available and a rental agency. There is a vehicle class containing generic information about all vehicles, a car class that inherits from the vehicle class and also contains specific information about cars, a truck class inheriting from the vehicle class and specific information about trucks, a motorcycle class inheriting from the vehicle class and specific information about motorcycles, and a rental agency class that contains methods to add vehicles to the fleet, remove vehicles from the fleet, and rent vehicles. 

SETUP INSTRUCTIONS

1) Navigate this repository on GitHub

2) Clone the repository

3) Run the application on your IDE

Sample demo

Welcome to Ade Vehicle Rental System

Choose an action from the below menu options

Main Menu Options:
1. Add vehicles to inventory
2. Display all vehicles in the inventory
3. Remove vehicles from inventory
4. Rent a vehicle from inventory
5. Display total revenue earned from rental
6. Exit the application

//To add a vehicle to your fleet or inventory, select option 1 

1

You can only add a maximum of 6 vehicles to the fleet

Select the type of vehicle to add:
1. Car
2. Truck
3. Motorcycle
   
Enter your choice: 1

Enter the number of vehicles to add: 1

Enter details for Car 1:

Model: Model S

Manufacturer: Tesla

Year: 2021

Rental Price: 10288.065

Seats: 2

Engine Type: Electric

Transmission: Electric

Is the vehicle a convertible (true/false): false

Congratulations!!! You have successfully added Model S to your fleet

//after adding a vehicle, the options are presented again to the user

Choose an action from the below menu options
Main Menu Options:
1. Add vehicles to inventory
2. Display all vehicles in the inventory
3. Remove vehicles from inventory
4. Rent a vehicle from inventory
5. Display total revenue earned from rental
6. Exit the application

//to view all vehicles in the inventory, select option 2

2

Your fleet has 6 slots.

Vehicle 1:

The vehicle details are:

Model: Model S

Manufacturer: Tesla

Year: 2021

Rental Price: $10,288.065

The car specific details are:

Seats: 2

Engine Type: Electric

Transmission: Electric

Convertible: No

No vehicles currently in slot 2.

No vehicles currently in slot 3.

No vehicles currently in slot 4.

No vehicles currently in slot 5.

No vehicles currently in slot 6.

Choose an action from the below menu options

Main Menu Options:
1. Add vehicles to inventory
2. Display all vehicles in the inventory
3. Remove vehicles from inventory
4. Rent a vehicle from inventory
5. Display total revenue earned from rental
6. Exit the application

3

Enter the index of the vehicle to remove: 0

Vehicle has been removed from inventory.

Choose an action from the below menu options

Main Menu Options:
1. Add vehicles to inventory
2. Display all vehicles in the inventory
3. Remove vehicles from inventory
4. Rent a vehicle from inventory
5. Display total revenue earned from rental
6. Exit the application

4

Enter the index of the vehicle to be rented: 1

The vehicle details are:

Model: Model S

Manufacturer: Tesla

Year: 2022

Rental Price: $123,456.78

The car specific details are:

Seats: 4

Engine Type: electric

Transmission: electric

Convertible: No

Enter the duration of the rental (in months): 3

Rental cost for 3 months: $30864.195

Do you want to proceed with the rental? (yes/No): yes

Congratulations you have successfully rented the vehicle for 3 months

Total Revenue from rental: $30864.195

Choose an action from the below menu options

Main Menu Options:
1. Add vehicles to inventory
2. Display all vehicles in the inventory
3. Remove vehicles from inventory
4. Rent a vehicle from inventory
5. Display total revenue earned from rental
6. Exit the application

5

Total Revenue from rental: $30864.195

Choose an action from the below menu options

Main Menu Options:
1. Add vehicles to inventory
2. Display all vehicles in the inventory
3. Remove vehicles from inventory
4. Rent a vehicle from inventory
5. Display total revenue earned from rental
6. Exit the application

6

Thank you for using Ade Vehicle Rental System. Hope to see you soon
