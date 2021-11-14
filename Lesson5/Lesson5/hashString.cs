using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Collections.Generic;

namespace Lesson4
{
    public class hashString:Program
    {
        public string ramdomStr { get; set; }

        public override bool Equals(object obj)
        {
            var user = obj as hashString;

            if (user == null)
                return false;

            return ramdomStr == user.ramdomStr;
        }

        public override int GetHashCode()
        {
            int firtsNameHashCode = ramdomStr?.GetHashCode() ?? 0;
            return firtsNameHashCode;
        }

        [Benchmark]
        public void Testquest()
        {
            var hashSet = new HashSet<hashString>();

            for (int i = 0; i < SrtCnt; i++)
            {
                var rString = "";
                for (var j = 0; j < 5; j++) rString += ((char)(rmd.Next(1, 26) + 64)).ToString().ToLower();
                var user = new hashString() { ramdomStr = rString };
                hashSet.Add(user);
            }

            hashSet.Equals("sdfsd");
        }
    }
}
