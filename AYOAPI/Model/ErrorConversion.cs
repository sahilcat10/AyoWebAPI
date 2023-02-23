using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AYOAPI.Model
{
    public class ErrorConversion
    {

        [Display(Name = "Message")]
        public string Message { get; set; }

        [Display(Name = "Inner Exception")]
        public string InnerException { get; set; }

        [Display(Name = "Stack Trace")]
        public string StackTrace { get; set; }

    }
}
