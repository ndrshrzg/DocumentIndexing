using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace IndexCalculations
{
    public class Document
    {
        private string _text;
        private int _numberofterms;

        public Document(string filepath)
        {
            _text = File.ReadAllText(filepath, Encoding.Default);
        }

        public string GetCleanText()
        {
            // credit patel.milanb
            string removeChars = "?&^$#@!()+-,:;<>’\'-_*.\"";
            string result = this._text;

            foreach (char c in removeChars)
            {
                result = result.Replace(c.ToString(), string.Empty);
            }

            return result;

        }

        public HashSet<String> GetUniqueTermsInSet()
        {
            HashSet<String> IndividualTerms = new HashSet<String>((this.GetCleanText()).ToLower().Split(' '));
            return IndividualTerms;
        }


        public int CalculateNumberOfTerms()
        {
            HashSet<String> UniqueIndividualTerms = this.GetUniqueTermsInSet();
            int _numberOfTerms = UniqueIndividualTerms.Count;
            return _numberOfTerms;  
        }

    }
}
