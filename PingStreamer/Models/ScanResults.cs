using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingStreamer.Models
{
    public class ScanResults : List<ScanResult>
    {
        // To remove after Tests!!!
        public ScanResults GetTestInstance()
        {
            RandomBool randomBool = new RandomBool();
            Random random = new Random();
            var testList = new ScanResults();
            
            int count = random.Next(10, 40);
            for (int i = 0; i < count; i++)
            {   
                var result = new ScanResult(random.Next(0, 500), randomBool.NextBoolean(), null);
                result.Info = CheckInfo.GetTestInstance();
                testList.Add(result);
            }
            return testList;
        }
    }
    public class RandomBool: Random
    {
        private uint _boolBits;

        public RandomBool() : base() { }
        public RandomBool(int seed) : base(seed) { }

        public bool NextBoolean()
        {
            _boolBits >>= 1;
            if (_boolBits <= 1) _boolBits = (uint)~this.Next();
            return (_boolBits & 1) == 0;
        }
    }
}
