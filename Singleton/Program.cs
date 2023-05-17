
using Singleton;

// // Creational Patterns

// Singleton
CreditCardFactory factory = new CreditCardFactory();
var creditCard = factory.CreateCreditCard("MoneyBack");

creditCard.GetCardType();
creditCard.GetAnnualCharge();

var creditCard2 = factory.CreateCreditCard("Titanium");

creditCard2.GetCardType();
creditCard2.GetAnnualCharge();

// Builder
var houseBuilder = new MyBuilder();

var house = houseBuilder
                              .AddEntrance()
                              .AddDoors(8)
                              .SealHouse()
                              .Build();

Console.WriteLine(house.ToString());