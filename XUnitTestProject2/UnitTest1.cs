using System;
using Xunit;
using Lab2;

namespace XUnitTestProject2
{
    public class UnitTest1
    {
        [Fact]
        public void DoesWithdrawalWork()
        {
            //arrange
            Program.balance = 100;

            //act
            Program.Withdrawal(20);

            //assert
            Assert.Equal(80, Program.balance);
        }

        [Fact]
        public void DoesWithdrawalNotWorkWork()
        {
            //arrange

            Program.balance = 100;
            //act

            Program.Withdrawal(140);
            //assert

            Assert.Equal(100, Program.balance);
        }


        [Fact]
        public void DoesDepositWork()
        {
            //arrange
            Program.balance = 100;

            //act
            Program.Deposit(20);

            //assert
            Assert.Equal(120, Program.balance);
        }

        [Fact]
        public void DoesDepositNotWorkWork()
        {
            //arrange
            Program.balance = 100;

            //act
            Program.Deposit(-15);

            //assert
            Assert.Equal(100, Program.balance);
        }
    }

}
