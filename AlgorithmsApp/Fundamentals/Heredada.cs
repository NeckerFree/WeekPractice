using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsApp.Fundamentals
{
    public class Heredada: Abstracta
    {
        public override void Method1()
        {
            base.Method1();
        }
        public Heredada()
        {
            int val = 49;
            ModifyVal(ref val);
        }

        private void ModifyVal(ref int val)
        {
            val = 99;
        }
    }

    public interface IMyStruct
    {
        void Process();
        public void Save();
    }
    public struct MyStruct2 : IMyStruct
    {
        public void Process()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
    public
        enum Enum : int
        {
        First,
        Second,
        Third,
        }
}
