using OnlineAfspraken;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTester
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("OnlineAfspraken.nl API tester");

            Console.WriteLine("Enter API Key:");
            var apiKey = Console.ReadLine();

            Console.WriteLine("Enter API Secret:");
            var apiSecret = Console.ReadLine();

            var client = new OnlineAfsprakenClient(apiKey, apiSecret);
            var agendas = await client.GetAgendas();

            Console.WriteLine($"Found {agendas.Objects.Length} agendas");

            var agendaId = agendas.Objects.First().Id;

            //All appointments for the coming year
            var afspraken = await client.GetAppointments(agendaId, DateTimeOffset.UtcNow, DateTime.UtcNow.AddYears(1), includeCancelled: 1);

            Console.WriteLine($"Found {afspraken.Objects.Length} afspraken");

            //All customers that have been updated in the last year
            var customers = await client.GetCustomers(DateTime.UtcNow.AddYears(-1));

            Console.WriteLine($"Found {customers.Objects.Length} cusomters updated in last year");

            var customerId = customers.Objects.First().Id;

            //Get a single customer
            var singleCustomer = await client.GetCustomer(customerId);

            Console.WriteLine($"CustomerId {customerId} has name: {singleCustomer.Customer.FirstName}");

            Console.ReadLine();

        }
    }
}
