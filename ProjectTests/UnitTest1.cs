using System;
using NUnit.Framework;
using SchoolProject.Util;

namespace ProjectTests
{
    public class Tests
    {
        [Test]
        public void PasswordCheck()
        {
            Assert.AreEqual("V9eJtVVoXu2fJfkfh9mEE0LPRmezL5UjwvVb2QhPzFmtBnkd152kv//nZQfetGFGSAqhK/kKzuecb7zZeriMcg==",PassEncrypt.Encrypt("myPasswordIsVeryLong", "someSalt"));
        }

        [Test]
        public void Trimming()
        {
            Assert.AreEqual("b_______________b", StringUtils.TrimStr(@"B\:;/'"+"\""+"{[()]}=!@B"));
        }
    }
}