using System.ComponentModel.DataAnnotations;

namespace RestApi.Models
{
    public class UserModel
    {
        [Key]
        public int USER_ID { get; set; }

        public string USER_NAME { get; set; }


        public string USER_PASSWORD { get; set; }
        public string USER_FIRSTNAME { get; set; }
        public string USER_LASTNAME { get; set; }

        public string USER_ROLE { get; set; }
    }
}
