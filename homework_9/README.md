1. Day Schedule System
-----------------------
Enum: DayOfWeek { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }
Struct: Schedule { DayOfWeek Day; string Task; }
Task: Create 3 schedules and print their contents.
2. Traffic Light Simulation
----------------------------
Enum: TrafficLight { Red, Yellow, Green }
Struct: Intersection { string Name; TrafficLight CurrentLight; }
Task: Create a light cycle method to simulate light changes.
3. Student Grade Levels
------------------------
Enum: GradeLevel { Freshman, Sophomore, Junior, Senior }
Struct: Student { string Name; int Age; GradeLevel Grade; }
Task: Create and display two students with different grade levels.
4. Weather Reporting
---------------------
Enum: WeatherType { Sunny, Rainy, Cloudy, Stormy, Snowy }
Struct: WeatherReport { string City; WeatherType Weather; int Temperature; }
Task: Create and print weather reports for 3 cities.
5. Light Bulb State Tracker
----------------------------
Enum: BulbState { On, Off, Broken }
Struct: LightBulb { string Room; BulbState State; int Wattage; }
Task: Create a light bulb inventory for a house.
6. Vehicle Registration
------------------------
Enum: FuelType { Petrol, Diesel, Electric, Hybrid }
Struct: Vehicle { string License; FuelType Fuel; int Year; }
Task: Create 5 vehicle entries and sort them by year.
7. Bank Account Types
----------------------
Enum: AccountType { Checking, Savings, Business }
Struct: Account { string Holder; AccountType Type; decimal Balance; }
Task: Create 3 accounts and calculate total balance.
8. Product Inventory System
----------------------------
Enum: ProductCategory { Electronics, Clothing, Food, Tools }
Struct: Product { string Name; ProductCategory Category; int Quantity; }
Task: Count how many items exist in each category.
9. Patient Blood Type Registry
-------------------------------
Enum: BloodType { A, B, AB, O }
Struct: Patient { string Name; BloodType Type; bool RhPositive; }
Task: Group patients by blood type and Rh factor.
10. Movie Library
------------------
Enum: Genre { Action, Drama, Comedy, Horror, SciFi }
Struct: Movie { string Title; Genre Genre; double Rating; }
Task: Filter movies with rating above 7.5 and group by genre.
11. Order Processing System
----------------------------
Enum: OrderStatus { Pending, Processing, Shipped, Delivered, Cancelled }
Struct: Order { int Id; string Product; OrderStatus Status; }
Task: Create a list of orders and show how many are pending.
12. Parking Lot Tracker
------------------------
Enum: SpotSize { Small, Medium, Large }
Struct: ParkingSpot { int Number; SpotSize Size; bool Occupied; }
Task: Count how many spots are available by size.
13. Library Book Lending System
--------------------------------
Enum: BookStatus { Available, CheckedOut, Reserved }
Struct: Book { string Title; string Author; BookStatus Status; }
Task: Simulate lending a book and update its status.
14. Hotel Room Booking
-----------------------
Enum: RoomType { Single, Double, Suite }
Struct: Room { int Number; RoomType Type; bool IsBooked; }
Task: List all unbooked rooms sorted by type.
15. Car Manufacturing Tracker
------------------------------
Enum: CarModel { Sedan, SUV, Truck, Coupe }
Enum: FuelType { Petrol, Diesel, Electric, Hybrid }
Struct: Car { string VIN; CarModel Model; FuelType Fuel; DateTime ManufactureDate; }
Task: Generate 5 cars and group by model.
16. Stock Movement Logging
---------------------------
Enum: MovementType { Inbound, Outbound, Transfer }
Struct: StockMovement { string SKU; MovementType Type; DateTime Date; int Quantity; }
Task: Calculate total inbound and outbound quantity for a product.
17. Airline Seat Allocation
----------------------------
Enum: SeatClass { Economy, Business, First }
Struct: FlightSeat { int SeatNumber; SeatClass Class; bool IsBooked; }
Task: Allocate and count remaining available seats by class.
18. Employee Shift Scheduler
-----------------------------
Enum: ShiftType { Morning, Evening, Night }
Struct: Shift { string Employee; ShiftType Shift; DateTime Date; }
Task: Group employees by shift and count them.
19. City Transport Routes
--------------------------
Enum: TransportType { Bus, Tram, Metro, Ferry }
Struct: Route { int RouteId; TransportType Type; int Stops; }
Task: Calculate average number of stops by transport type.
20. Smart Home Device Monitor
------------------------------
Enum: DeviceType { Light, Thermostat, DoorLock }
Enum: DeviceState { On, Off, Standby, Malfunctioning }
Struct: SmartDevice { string Name; DeviceType Type; DeviceState State; }
Task: Change device states based on conditions and count offline devices.

==========================================================

C# Homework: Structs with Methods (10 Tasks)
===========================================
1. Student Struct
-----------------
Method: PrintInfo()
Task: Display student name and grade.
2. Circle Struct
----------------
Field: Radius
Method: GetArea(), GetCircumference()
3. Currency Converter
---------------------
Fields: Amount, Currency
Method: ConvertTo(string targetCurrency)
Task: Return converted amount (use mock conversion rates).
4. Email Validator
------------------
Field: Email
Method: IsValidEmail() (use Contains('@') && Contains('.'))
5. Discount Calculator
----------------------
Fields: Price, DiscountPercentage
Method: GetFinalPrice()
6. Time Interval
----------------
Fields: StartTime, EndTime
Method: GetDuration() (returns TimeSpan)
7. Rectangle Comparison
------------------------
Method: IsSquare(), IsLargerThan(Rectangle other)
8. Temperature Conversion
-------------------------
Fields: Celsius
Methods: ToFahrenheit(), ToKelvin()
9. Voting Eligibility
---------------------
Field: Age
Method: CanVote() → returns true if age ≥ 18
10. Invoice Total
-----------------
Fields: UnitPrice, Quantity
Method: GetTotal() → returns UnitPrice * Quantity

======================================================

C# Homework: Structs with Constructors (10 Tasks)
=================================================
1. Book Struct
--------------
Struct: Book { string Title; string Author; int Year; }
Task: Create a constructor to initialize all properties.
2. Rectangle Area Calculator
----------------------------
Struct: Rectangle { int Width; int Height; }
Task: Create a constructor to initialize width/height and a method to return area.
3. Point in 2D Space
--------------------
Struct: Point2D { double X; double Y; }
Task: Use a constructor for coordinates and print them.
4. Employee Info
----------------
Struct: Employee { string Name; int Id; decimal Salary; }
Task: Use a constructor to initialize name, ID, and salary.
5. Temperature Record
---------------------
Struct: Temperature { string City; double Celsius; DateTime Date; }
Task: Constructor takes all three values.
6. Gadget Stock Entry
---------------------
Struct: Gadget { string Name; string Brand; decimal Price; int Quantity; }
Task: Create a constructor to quickly add gadgets to stock.
7. Bank Transaction
-------------------
Struct: Transaction { int Id; decimal Amount; DateTime Timestamp; }
Task: Constructor auto-sets current DateTime for timestamp.
8. Course Enrollment
--------------------
Struct: Course { string Code; string Title; int Credit; }
Task: Use constructor to create multiple course objects.
9. GeoLocation
--------------
Struct: Location { double Latitude; double Longitude; }
Task: Constructor must validate that lat/lon are in valid range.
10. User Profile
----------------
Struct: User { string Username; string Email; DateTime CreatedAt; }
Task: CreatedAt is set automatically in constructor to DateTime.Now.