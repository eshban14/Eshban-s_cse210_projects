using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JournalApp
{
    public class JournalEntry
    {
        public string Prompt {get; set;}
        public string Response {get; set;}
        public string Date {get; set;}

        public JournalEntry(string prompt, string response){
            Prompt = prompt;
            Response = response;
            Date = DateTime.Now.ToString("yyyy-mm-dd");

        }
        public override string ToString()
        {
            return $"{Date} - Prompt: {Prompt}\nResponse: {Response}\n";
        }
    }
}