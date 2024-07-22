# Vehicle Management API

This is a .NET Core Web API project designed to manage a repository of vehicles, including cars, boats, and buses. Vehicles have various attributes such as color, and cars specifically have wheels and headlights. The API allows users to perform CRUD operations and filter vehicles by their attributes.

- **GET**: Retrieve cars, boats, and buses by color.
- **POST**: Turn on/off the headlights of a car by its ID.
- **DELETE**: Delete a car from the repository.

# API Endpoints
***GetById***
- **Endpoint**: `/api/vehicle{Car,Bus,Boat}/GetById/{id}`
- **Method**: `GET`
- **Path Parameters**:
  - `id`: The ID of the vehicle to retrieve
    
***GetAll***
- **Endpoint**: `/api/vehicle{Car,Bus,Boat}/GetAll`
- **Method**: `GET`

***Create***
- **Endpoint**: `/api/vehicle{Car,Bus,Boat}/Create`
- **Method**: `POST`
- **Body Parameters**:
  - Vehicle details (depends on type of vehicle)
    
***Update***
- **Endpoint**: `/api/vehicle{Car,Bus,Boat}/Update`
- **Method**: `PUT`
- **Body Parameters**:
  - Updated vehicle details
    
***Delete***
- **Endpoint**: `/api/vehicle{Car,Bus,Boat}/Delete/{id}`
- **Method**: `DELETE`
- **Path Parameters**:
  - `id`: The ID of the vehicle to delete
    
***GetByColor***
- **Endpoint**: `/api/vehicle{Car,Bus,Boat}/GetByColor/{color}`
- **Method**: `GET`
- **Query Parameters**:
  - `color`: The color of the vehicle (e.g., `red`, `blue`, `black`, `white`)
  
 # Testing with Postman
 
GetAll
![car_getall](https://github.com/user-attachments/assets/8985942b-b69e-4040-b48f-d8826d930d4d)

Create Car
![car_create](https://github.com/user-attachments/assets/79a9f4d5-ffe6-4cd8-838e-044fd8be6baa)

GetByColor
![boat_getbycolor](https://github.com/user-attachments/assets/06950a20-5aab-413b-9700-057323fec183)

![bus_getbycolor](https://github.com/user-attachments/assets/162cb443-5b50-45b5-b1bf-946a28fdb5b9)

![car_getbycolor](https://github.com/user-attachments/assets/357d2d90-f815-4952-8d52-2386ffbf76b7)

Delete Car

![car_delete](https://github.com/user-attachments/assets/3757a8c2-6dbe-4123-a428-4b4e5cb2dbf3)

Car HeadLights on/off with id
![car_headlights1](https://github.com/user-attachments/assets/6f107b70-1333-4da5-9472-6187edb0ef8d)

![car_headlights2](https://github.com/user-attachments/assets/7722e9e3-a209-4cd4-9cd5-8cf06f50dc86)


### Prerequisites

- [.NET Core SDK](https://dotnet.microsoft.com/download) (version 6.0 or later)
- [Postman](https://www.postman.com/downloads/) for testing the API
- The API will be available at "https://localhost:7293".
