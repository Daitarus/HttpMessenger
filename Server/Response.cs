using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpMessenger.Server
{
    public class Response
    {
        public Uri Uri { get; set; }
        public HttpMethod Method { get; set; }
        public string Message { get; set; }

        public Response(Uri uri, HttpMethod method, string message)
        {
            Uri = uri;
            Method = method;
            Message = message;
        }
    }
}
