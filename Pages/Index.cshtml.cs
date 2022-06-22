using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HelloWorld_ASP_Razor.Pages
{
    [BindProperties]
    public class IndexModel : PageModel
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Result { get; set; }
        public void OnPost()
        {
            Result = CalculateAnswer(Age, Name);

        }

        private string CalculateAnswer(int age, string name)
        {
            Age++;
            return Name + " " + Age.ToString();

        }


        //make a change to my code
        //make another change to my code 


        //adds data when the page is loded
        public void OnGet()
        {
        }
        //processes the page when you hit submit





    }
}