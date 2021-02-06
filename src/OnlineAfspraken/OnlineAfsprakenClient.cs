using OnlineAfspraken.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAfspraken
{
    public class OnlineAfsprakenClient
    {
        private readonly string baseUrl = "https://agenda.onlineafspraken.nl/APIREST";
        private readonly string apiKey;
        private readonly string apiSecret;

        public OnlineAfsprakenClient(string apiKey, string apiSecret)
        {
            this.apiKey = apiKey;
            this.apiSecret = apiSecret;
        }

        public async Task<GetAgendasResponse?> GetAgendas()
        {
            var obj = await SubmitRequest<GetAgendasResponse>("getAgendas");

            return obj;
        }

        public async Task<GetAppointmentsResponse?> GetAppointments(int agendaId, DateTimeOffset startDate, DateTimeOffset endDate, 
            int? appointmentTypeId = null, int? includeCancelled = null, int? limit = null, int? offset = null)
        {
            var queryParams = new Dictionary<string, string>();
            queryParams.Add("AgendaId", agendaId.ToString());
            queryParams.Add("StartDate", startDate.ToString("yyyy-MM-dd"));
            queryParams.Add("EndDate", endDate.ToString("yyyy-MM-dd"));

            if(appointmentTypeId != null)
                queryParams.Add("AppointmentTypeId", appointmentTypeId.ToString());
            if (includeCancelled != null)
                queryParams.Add("IncludeCancelled", includeCancelled.ToString());
            if (limit != null)
                queryParams.Add("Limit", limit.ToString());
            if (offset != null)
                queryParams.Add("Offset", offset.ToString());

            var obj = await SubmitRequest<GetAppointmentsResponse>("getAppointments", queryParams);

            return obj;
        }

        public async Task<GetCustomersResponse?> GetCustomers(DateTimeOffset? updatedAfter = null, int? limit = null, int? offset = null)
        {
            var queryParams = new Dictionary<string, string>();
            if (updatedAfter.HasValue)
                queryParams.Add("UpdatedAfter", updatedAfter.Value.ToString("yyyy-MM-dd hh:mm:ss"));
            if (limit != null)
                queryParams.Add("Limit", limit.ToString());
            if (offset != null)
                queryParams.Add("Offset", offset.ToString());

            var obj = await SubmitRequest<GetCustomersResponse>("getCustomers", queryParams);

            return obj;
        }

        public async Task<GetCustomerResponse?> GetCustomer(long id)
        {
            var queryParams = new Dictionary<string, string>();
            queryParams.Add("id", id.ToString());

            var obj = await SubmitRequest<GetCustomerResponse>("getCustomer", queryParams);

            return obj;
        }


        private async Task<T?> SubmitRequest<T>(string method, Dictionary<string, string>? queryParams = null) where T : BaseResponse
        {
            queryParams ??= new Dictionary<string, string>();

            var sig = GetSignature(queryParams, method);
            StringBuilder sb = new StringBuilder();
            foreach (var q in queryParams.OrderBy(x => x.Key))
            {
                sb.Append($"&{q.Key}={q.Value}");
            }

            var url = $"{baseUrl}?api_key={apiKey}&api_signature={sig.hash}&api_salt={sig.salt}{sb.ToString()}";


            HttpClient client = new HttpClient();

            var resonse = await client.GetAsync(url);

            var responseString = await resonse.Content.ReadAsStringAsync();

            var obj = SerializerHelper.XmlDeserialize<T>(responseString);
            return obj;
        }

        private (string salt, string hash) GetSignature(Dictionary<string, string> queryParams, string method)
        {
            queryParams.Add("method", method);

            StringBuilder sb = new StringBuilder();
            foreach(var q in queryParams.OrderBy(x => x.Key))
            {
                sb.Append(q.Key);
                sb.Append(q.Value);
            }

            string salt = DateTimeOffset.UtcNow.ToUnixTimeSeconds().ToString();
            string toSign = $"{sb.ToString()}{this.apiSecret}{salt}".Replace(" ", string.Empty);

            var hash = Hash(toSign);

            return (salt, hash);
        }

        private static string Hash(string input)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    // can be "x2" if you want lowercase
                    sb.Append(b.ToString("X2"));
                }

                return sb.ToString();
            }
        }
    }
}
