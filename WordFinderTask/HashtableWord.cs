using System.Collections.Generic;

namespace WordFinderTask
{
    public class HashtableWord 
    {
        private Dictionary<int, string> _dictionary = new Dictionary<int,string>();

        public HashtableWord() { }

        public void AddElement(int key, string value)
        {
            _dictionary.Add(key,value);
        }

        public bool GetWordByKey(int key,out string wordFound)
        {
            return _dictionary.TryGetValue(key, out wordFound);
        }
    }
}
