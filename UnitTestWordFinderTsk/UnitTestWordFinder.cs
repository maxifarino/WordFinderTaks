using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using WordFinderTask;

namespace UnitTestWordFinderTsk
{
    [TestClass]
    public class UnitTestWordFinder
    {
        private IWordFinder _wordFinder;
        private IEnumerable<string> _matrix;
        private IEnumerable<string> _wordsTream;

        [TestInitialize]
        public void Init()
        {
            _matrix = new string[] { "abcdm", "fgwia", "chilx", "pqnsi", "uvdxy" };
            _wordsTream = new string[] { "chill", "cold", "wind", "maxi" };
            _wordFinder = new WordFinder(_matrix);
        }

        [TestMethod]
        public void Length_matrix() {
            
        }

    }
}
