using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Tropo
{
    class TropoREST
    {
        public string setupConference { get; set; } = "https://api.tropo.com/1.0/sessions?action=create&token=7a666d4d5859716851487852767067426957694a54436a4d55567248676a654f50616b454774747569756f6d";

        public string callMembers(string numberToDial)
        {
            string uri = string.Format("https://api.tropo.com/1.0/sessions?action=create&token=59445a55767479624845514f4864796176486b51446e6d7176716e6f4f696755637861444c55426f576b7758&numberToDial={0}&numberToCall=18033870024&conferenceID=1990", numberToDial);
            return uri;
        }

        public async Task<HttpResponseMessage> tropoRequest()
        {
            try
            {
                HttpClient client = new HttpClient();
                //var response = await client.GetAsync(setupConference);
                var response = await client.GetAsync(callMembers("16505333392"));
                Console.WriteLine(response);
                return response;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return null; 
            }
        }
    }
}
