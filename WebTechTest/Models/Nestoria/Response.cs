using System.Collections.Generic;

namespace WebTechTest.Models.Nestoria
{
    public class Response
    {
        public string application_response_code { get; set; }
        public string application_response_text { get; set; }
        public Attribution attribution { get; set; }
        public string created_http { get; set; }
        public int created_unix { get; set; }
        public string link_to_url { get; set; }
        public List<Listing> listings { get; set; }
        public List<Location> locations { get; set; }
        public int page { get; set; }
        public string sort { get; set; }
        public string status_code { get; set; }
        public string status_text { get; set; }
        public string thanks { get; set; }
        public int total_pages { get; set; }
        public int total_results { get; set; }
        public string listing_type { get; set; }
    }
}