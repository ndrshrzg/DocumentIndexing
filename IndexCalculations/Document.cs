using System;
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
            StringBuilder sb = new StringBuilder();

            foreach (char c in _text)
            {
                if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == ' ' || c == '\n')
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

        public string[] GetIndividualTermsInList()
        {
            string[] IndividualTerms = (this.GetCleanText()).ToLower().Split(' ');

            return IndividualTerms;
        }


        //public int CalculateNumberOfTerms()
        //{
        //    _text.
        //}

    }
}
