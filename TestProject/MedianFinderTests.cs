using AlgorithmsApp.MathTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class MedianFinderTests
    {

        [Fact]
        public void ValidateMediaFinder()
        {
            MedianFinder medianFinder = new MedianFinder();
            medianFinder.AddNum(2);    // arr = [1]
            medianFinder.AddNum(3);    // arr = [1, 2]
            medianFinder.AddNum(6);
            medianFinder.AddNum(5);
            medianFinder.AddNum(0);
            double actual = medianFinder.FindMedian();
            Assert.Equal(2.0, actual);

        } 
  
    }
}
