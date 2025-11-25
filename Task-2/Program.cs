using System;

Car car = new Car { Brand = "Toyota", Speed = 120, Seats = 5 };
Motorcycle bike = new Motorcycle { Brand = "Honda", Speed = 80, HasCarrier = true };

car.Start();
car.DisplayInfo();
car.Stop();

bike.Start();
bike.DisplayInfo();
bike.Stop();