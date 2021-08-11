using Azure.Identity;
using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiGraph.Services
{
    public class GraphServices
    {
        public static string clientId = "bdaba269-9551-4bb9-843e-6ec0d528a1d9";
        public static string clientSecret = "-Xor.lc6_i0Zm82hubyK_~7po_p4ooFDlA";
        public static string tenantId = "58a9ad3d-abd0-479b-adf1-2591bd993068";

        public async Task<IGraphServiceUsersCollectionPage> GetAllUsers()
        {
            var clientSecretCredential = new ClientSecretCredential(tenantId, clientId, clientSecret);
            var graphClient = new GraphServiceClient(clientSecretCredential);
            var users = await graphClient.Users.Request().GetAsync();
            return users;
        }
    }
}
