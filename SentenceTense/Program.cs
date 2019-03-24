using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using SentenceTense;

namespace POSTagging
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            SentTense.TagSents();

            //var words = new[] { "клупа", "одел", "куќа" };
            //string pattern = @"*[л]$";

            //MatchCollection matches = Regex.Matches("клупа, одел, куќа", pattern);


            //Console.WriteLine("{0} matches", matches.Count);
            //POSTaggingRules.TagWords();
            //string sentences = System.IO.File.ReadAllText(@"D:\NLP\StoryTelling\StoryTelling\splittedText.txt");

            //var subsentences = sentences.Split(',');

            //using (System.IO.StreamWriter file =
            //new System.IO.StreamWriter(@"D:\NLP\subsentences.txt", true))
            //{
            //    foreach(var s in subsentences)
            //    {
            //        file.WriteLine(s);
            //    }

            //}
        }
    }
}
