using AlgorithmsApp.Fundamentals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class FundamentalTests
    {
        [Fact]
        public void ValidateRef()
        {
            Heredada heredada = new Heredada();
            var actual = typeof(MyStruct2);
            Assert.Equal("ValueType",actual.BaseType?.Name );
            var other = typeof(AlgorithmsApp.Fundamentals.Enum);
            Assert.Equal("ValueType", other.BaseType?.Name);
            MyStruct2 my = new MyStruct2();
            my.Process();

       }
    }
}
