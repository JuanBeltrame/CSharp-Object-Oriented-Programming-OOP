﻿using Constructor_Overloading_Examples;
//-----Ejemplo 01--------
Persona persona1 = new Persona();
Persona persona2 = new Persona("Juan", DateTime.Now, 33334545);
Persona persona3 = new Persona("Juan", new DateTime(1998, 5, 9));
Persona persona4 = new Persona("Ariel", new DateTime(1998, 5, 9), 32713684);

Console.WriteLine(persona1.Mostrar());
Console.WriteLine(persona2.Mostrar());
Console.WriteLine(persona3.Mostrar());
Console.WriteLine(persona4.Mostrar());

Console.WriteLine(persona2 == persona4);
//-----Ejemplo 02--------
Tiempo tiempo01 = new Tiempo();
Tiempo tiempo02 = new Tiempo(19, 48, 23);
Tiempo tiempo03 = new Tiempo(12, 12, "XX:xx:XX");

//-----Ejemplo 03--------
Auto a1 = new Auto("azzz123", Colores.Rojo, 322231212);
Auto a2 = new Auto("azzz123", Colores.Negro, 322231212);
Auto a3 = new Auto("azzz123", Colores.Azul, 322231212);
Auto a4 = new Auto("azzz123", Colores.Gris, 322231212);

//-----Ejemplo 04--------
var account01 = new BankAccount("1234", "John Doe");
var account02 = new BankAccount(accountNumber: "12234",
                                          balance: 1000.00m,
                                          accountHolderName: "John Doe",
                                          accountType: "Savings"
                                          );

//-----Ejemplo 05--------
var employee = new Employee("Jannick", 30, true);