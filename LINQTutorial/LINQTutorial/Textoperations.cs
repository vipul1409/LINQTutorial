using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQTutorial
{
    class Textoperations
    {
        public static void CountWords(string text, string searchTerm)
        {
            //Convert the string into an array of words 
            string[] source = text.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);

            // Create and execute the query. It executes immediately  
            // because a singleton value is produced. 
            // Use ToLowerInvariant to match "data" and "Data"  
            var matchQuery =
                source.Where(word => word.ToLowerInvariant() == searchTerm.ToLowerInvariant()).Select(word => word);

            // Count the matches. 
            int wordCount = matchQuery.Count();
            Console.WriteLine("{0} occurrences(s) of the search term \"{1}\" were found.", wordCount, searchTerm);

            // Keep console window open in debug mode
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
    /* Output:
       3 occurrences(s) of the search term "data" were found.
    */
}
