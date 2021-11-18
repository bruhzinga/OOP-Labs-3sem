// See https://aka.ms/new-console-template for more information
using System.Reflection;
using LABA3;
using laba12;

/*Reflector.ClearFile();
Reflector.GetAssemeblyName(typeof(Airline));
Reflector.HasPublicConstr(typeof(Airline));
Reflector.GetAllPublicMethods(typeof(Airline));
Reflector.GetPropertiesAndFileds(typeof(Airline));
Reflector.GetInterfaces(typeof(Airline));
Reflector.GetSpecifiedParametrType(typeof(Airline), "System.String value");
Reflector.Invoke("Laba12.Sum", "FindSum");
var NewObj = Reflector.Create(typeof(Airline));*/
/*Console.WriteLine(NewObj);*/
Reflector.ClearFile();
Reflector.GetAssemeblyName(typeof(Reflector));
Reflector.HasPublicConstr(typeof(Reflector));
Reflector.GetAllPublicMethods(typeof(Reflector));
Reflector.GetPropertiesAndFileds(typeof(Reflector));
Reflector.GetInterfaces(typeof(Reflector));
Reflector.GetSpecifiedParametrType(typeof(Reflector), "System.String value");