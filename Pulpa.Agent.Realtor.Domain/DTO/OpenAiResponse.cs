using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pulpa.Agent.Realtor.Domain.DTO
{
    public class OpenAiResponse
    {
        public List<Choice> Choices { get; set; }
        public OpenAiResponse()
        {
            Choices = new List<Choice>();
        }
        public class Choice
        {
            public string? Text { get; set; }
        }
    }
}
