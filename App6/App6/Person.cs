using System;
using System.Collections.Generic;
using System.Text;

namespace App6
{
    public class Person: List<Employee>
    {
        public string Title { get; set; }
        public string ShortName { get; set; }
        public Person (string title, string shortName)
        {
            Title = title;
            ShortName = shortName;
        }
        public static IList<Person> All {  get; set; }
        
    }
}
