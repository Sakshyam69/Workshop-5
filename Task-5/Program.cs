using System;

ElectronicsStore store = new ElectronicsStore();

Laptop l1 = new Laptop("Acer", 210000);
Smartphone s1 = new Smartphone("Techno Spark", 21000);

store.AddDevice(l1);
store.AddDevice(s1);

store.ShowAllDeviceDetails();