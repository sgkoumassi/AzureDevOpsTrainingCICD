using NUnit.Framework;
using System;
using OcR;

namespace OcR.Test
{
    public class Story1
    {
        private Story StoryFile = new Story(); 

        [Test]
        public void shoulReturnLine()
        {
            Assert.AreEqual(true, Story.fileRed());
        }
    }
}
