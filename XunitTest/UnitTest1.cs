using Calculater;

namespace XunitTest
{
    public class UnitTest1
    {
        MyCalculation objMyCal = new MyCalculation();
        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4, objMyCal.Add(2, 2));
        }

        [Fact]
        public void FailingTest()
        {
            Assert.Equal(5, objMyCal.Add(2, 2));
        }


        [Fact]
        public void SubPassingTest()
        {
            Assert.Equal(2, objMyCal.Sub(5, 3));
        }

        [Fact]
        public void SubFailingTest()
        {
            Assert.NotEqual(5, objMyCal.Sub(5, 3));
        }


        [Fact]
        public void MultPassingTest()
        {
            Assert.Equal(15, objMyCal.Mullti(5, 3));
        }

        [Fact]
        public void MultFailingTest()
        {
            Assert.Equal(5, objMyCal.Mullti(5, 3));
        }
    }
}