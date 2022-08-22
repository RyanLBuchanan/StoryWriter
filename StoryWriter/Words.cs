//(Random Sentences and Story Writer) Write an app that uses random-number generation to create
//sentences. Use four arrays of strings, called article, noun, verb and preposition. Create a
//sentence by selecting a word at random from each array in the following order:
//article, noun, verb, preposition, article, noun.As each word is picked, concatenate it to
//the previous words in the sentence. The words should be separated by spaces. When the sentence
//is output, it should start with a capital letter and end with a period. The program should
//generate 10 sentences and output them to a text box.

//The arrays should be filled as follows: The article array should contain
//the articles "the", "a", "one", "some" and "any";
//the nouns "boy", "girl", "dog", "town" and "car";
//the verbs "drove", "jumped", "ran", "walked" and "skipped";
//the prepositions "to", "from", "over", "under" and "on";

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryWriter
{
    class Words
    {
        private Random rand;

        // Constructor to initialize arrays with pre-defined words
        public Words()
        {
            Article = new string[] { "the", "a", "one", "some", "any" };
            Noun = new string[] { "boy", "girl", "dog", "town", "car" };
            Verb = new string[] { "drove", "jumped", "ran", "walked","skipped" };
            Preposition = new string[] { "to", "from", "over", "under","on" };
        }

        public readonly string[] Article;
        public readonly string[] Noun;
        public readonly string[] Verb;
        public readonly string[] Preposition;

        // Generates sentence from 6 words 
        private string GenerateSentence()
        {
            string word1 = GetWord("Article");
            word1 = Capitalize(word1);
            string word2 = GetWord("Noun");
            string word3 = GetWord("Verb");
            string word4 = GetWord("Preposition");

            return String.Format($"{word1} {word2} {word3} {word4} {word1} {word2}.");
        }

        // Get random word from pre-defined array 
        private string GetWord(string arrayName)
        {
            switch (arrayName)
            {
                case "Article":
                    return Article[rand.Next(0, 5)];
                case "Noun":
                    return Noun[rand.Next(0, 5)];
                case "Verb":
                    return Verb[rand.Next(0, 5)];
                case "Preposition":
                    return Preposition[rand.Next(0, 5)];
                default:
                    return "Please restart application";

            }
        }

        // Capitalize the first letter of first word in each sentence
        private string Capitalize(string word)
        {
            char firstLetter = ' ';
            string capitalizedWord = "";

            firstLetter = Convert.ToChar(word.Substring(0, 1));
            capitalizedWord = firstLetter.ToString().ToUpper() + word.Substring(1);

            return capitalizedWord;
        }
    }
}
