using NUnit.Framework;
using System;
using Assets.Classes;

namespace GameTests
{
    [TestFixture]
    public class DialogueTests
    {
        [Test]
        public void notNull()
        {
            new DialoguePart();
        }
    }
}
