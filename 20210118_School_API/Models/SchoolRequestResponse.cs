using System.Collections.Generic;

namespace _20210118_School_API.Models
{
    public class SchoolRequestResponse : APIRequestResponse
    {
        public SchoolRequestResponse()
        {
            Errors = new Dictionary<string, string>()
            {
                {"0", "No errors" },
                {"1", "There is no School with supplied Id argument" },
                {"2", "Item already deleted" }

            };
        }
        public string Status { get; set; }
        public string ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
        
        public Dictionary <string, string> Errors { get; set; }
        public string GetErrorText(string key)
        {
            return Errors[key];
        }
    }
}
