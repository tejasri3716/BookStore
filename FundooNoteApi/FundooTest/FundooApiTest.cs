using Manager.Manager;
using Model.UserModel;
using NUnit.Framework;
using Repository.Repository;

namespace FundooTest
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void LoginTest()
        {
            AccountRepository repository = new AccountRepository();
            LoginModel login = new LoginModel
            {
                Email = "radha@gmail.com",
                Password="radha@3716"
            };
            Assert.IsNotNull(repository.Login(login));
        }
    }
}