using System;
using System.ComponentModel.DataAnnotations;

namespace RestApi.Models
{
    public class TicketModel
    {
        [Key]
        public int TICKET_ID { get; set; }

        public string USER_NAME { get; set; }


        public string DATE { get; set; }
        public string ISSUE { get; set; }
        public bool STATUS { get; set; }
        public string SOLUTION { get; set; }


    }
}
