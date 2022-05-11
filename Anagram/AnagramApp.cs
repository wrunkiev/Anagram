using System;
using System.Collections.Generic;
using System.Text;

namespace Anagram
{
    public class AnagramApp
    {
        private string ReverseWord(string word)
        {
            char[] charResult = new char[word.Length];    
            

            int j = word.Length - 1;

            for (int i = 0; i < word.Length; i++)
            {
                if (Char.IsLetter(word[i]))
                {
                    while (j >= 0)
                    {
                        if (Char.IsLetter(word[j]))
                        {
                            charResult[j] = word[i];
                            j--;
                            break;
                        }    
                        
                        j--;                        
                    }
                }
                else
                {
                    charResult[i] = word[i];
                }
            }           

            return new string(charResult);
        }

        public string Reverse(string line)
        {
            if (String.IsNullOrEmpty(line))
            {
                return "String is null";
            }

            if (String.IsNullOrWhiteSpace(line.Trim()))
            {
                return "String is empty";
            }

            string strResult = line;

            string[] wordArr = line.Split(' ');            

            for (int i = 0; i < wordArr.Length; i++)
            {
                if (wordArr[i].Trim().Length > 0)
                {
                    if (line.Contains(wordArr[i].Trim()))
                    {
                        strResult = strResult.Replace(wordArr[i].Trim(), ReverseWord(wordArr[i].Trim()));                        
                    }                   
                }
            }

            return strResult;            
        }
    }
}
