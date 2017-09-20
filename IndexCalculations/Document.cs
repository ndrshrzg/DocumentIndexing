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
            // TODO Redo this Method from scratch
            StringBuilder sb = new StringBuilder();

            foreach (char c in _text)
            {
                if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == ' ' || c == '\n' || c == 'ü' || c == 'ä' || c == 'ö')
                {
                    if (c == '\n')
                    {
                        sb.Append(' ');
                    }
                    else
                    {
                        sb.Append(c);
                    }
                }

            }

            return sb.ToString();

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
