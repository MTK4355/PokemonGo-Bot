﻿using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace PokemonGo.RocketAPI.Helpers
{
    public static class HttpClientHelper
    {
        public static async Task<TResponse> PostFormEncodedAsync<TResponse>(string url,
            params KeyValuePair<string, string>[] keyValuePairs)
        {
            var handler = new HttpClientHandler
            {
                AutomaticDecompression = DecompressionMethods.GZip,
                AllowAutoRedirect = false,
                UseProxy = Client.proxy != null,
                Proxy = Client.proxy
            };

            using (var tempHttpClient = new System.Net.Http.HttpClient(handler))
            {
                var response = await tempHttpClient.PostAsync(url, new FormUrlEncodedContent(keyValuePairs)).ConfigureAwait(false);
                return await response.Content.ReadAsAsync<TResponse>().ConfigureAwait(false);
            }
        }
    }
}