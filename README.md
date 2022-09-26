[![Build .NET](https://github.com/michielpost/onlineafspraken.nl/actions/workflows/build.yml/badge.svg)](https://github.com/michielpost/onlineafspraken.nl/actions/workflows/build.yml)

# onlineafspraken.nl
C# SDK for onlineafspraken.nl   
Not all API methods are implemented, currently available:
- GetAgendas
- GetAppointments
- GetCustomers
- GetCustomer

PRs to add more API calls are welcome

Available on NuGet: https://www.nuget.org/packages/OnlineAfspraken.nl/


# How To Use
See the included API Tester.

Create a new `OnlineAfsprakenClient`

```cs
var client = new OnlineAfsprakenClient(apiKey, apiSecret);
```

Use the client
```cs
var agendas = await client.GetAgendas();

//All appointments for the coming year
var afspraken = await client.GetAppointments(agendaId, DateTimeOffset.UtcNow, DateTime.UtcNow.AddYears(1));

 //All customers that have been updated in the last year
var customers = await client.GetCustomers(DateTime.UtcNow.AddYears(-1));

 //Get a single customer
var singleCustomer = await client.GetCustomer(customerId);
```

# References
https://onlineafspraken.nl/nl_NL/developers
