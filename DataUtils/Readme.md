# DataUtils SQL Database Helper For C# Blazor

---

Made by [HeartwarmingFox](https://github.com/fluffballdev)


How to use:

1. Add a reference to this library after downloading it.
2. Add a connection string to ```Appsettings.json``` and ```Appsettings.Development.json```

Example:
```
"ConnectionStrings": {
"Default": "Server=MyServerAddress;Database=MyDatabaseName;Uid=MyUser;Pwd=MyPass;"
}
```
3. Add the sql manager to your ```Program.cs``` or configuration code <br> with <pre>"ConnectionStrings": {
       "Default": "Server=MyServerAddress;Database=MyDatabaseName;Uid=MyUser;Pwd=MyPass;"
   }</pre>
4. To add models & Data see ```Example``` folder.

---

#### Dependencies
This was built using [Dapper](https://www.nuget.org/packages/Dapper/). & [MYSQL.Data](https://www.nuget.org/packages/MySql.Data).

###### DataUtils Version 0.2.0