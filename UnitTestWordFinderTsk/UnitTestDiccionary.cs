using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using WordFinderTask;

namespace UnitTestWordFinderTsk
{
    [TestClass]
    public class UnitTestDiccionary
    {
        private HashtableWord _HashtableWord;

        [TestInitialize]
        public void Init()
        {
            _HashtableWord = new HashtableWord();
        }

        [TestMethod]
        public void Add_new_element()
        {
            var wordAdded = string.Empty;
            _HashtableWord.AddElement(1, "value1");
            _HashtableWord.GetWordByKey(1, out wordAdded);

            Assert.IsNotNull(wordAdded);
        }

        [TestMethod]
        public void Look_for_element_by_key()
        {
            var wordAdded = string.Empty;
            _HashtableWord.AddElement(1, "value1");
            _HashtableWord.AddElement(2, "value2");
            _HashtableWord.AddElement(3, "value3");

            _HashtableWord.GetWordByKey(3, out wordAdded);

            Assert.AreSame("value3", wordAdded);
        }
    }
}
