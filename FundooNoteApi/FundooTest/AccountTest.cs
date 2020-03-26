using Manager.Manager;
using Model.UserModel;
using NUnit.Framework;
using Repository.RepositoryClasses;
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
                Email = "radhag@gmail.com",
                Password = "radha@3716"
            };
            Assert.IsNotNull(repository.Login(login));
        }

        [Test]
        public void RegisterTest()
        {
            RegisterModel register = new RegisterModel();
            register.FirstName = "a";
            register.LastName = "aa";
            register.Email = "aa@gmail.com";
            register.Password = "a@3716";
            AccountManager manager = new AccountManager();
            Assert.IsNotNull(manager.Register(register));
        }

        [Test]
        public void ForgotPassword()
        {
            ForgotPassword forgot = new ForgotPassword();
            forgot.Email = "tejasmiley129@gmail.com";
            var result = new AccountManager();
            Assert.IsNotNull(result.ForgotPassword(forgot));
        }

        [Test]
        public void ResetPasswordTest()
        {
            ResetPassword reset = new ResetPassword()
            {
                Email = "tejasmiely129@gmail.com",
                Password = "hello",
                NewPassword = "hell@3716",
                ConfirmPassword = "hell@3716"
            };
            AccountManager manager = new AccountManager();
            Assert.IsNotNull(manager.ResetPassword(reset));
        }

        [Test]
        public void EmailLoginTest()
        {
            LoginModel login = new LoginModel()
            {
                Email = "tejasmiley129@gmail.com",
                Password = "hell@3716"
            };
            AccountManager manager = new AccountManager();
            Assert.IsNotNull(manager.EmailLogin(login));
        }

        [Test]
        public void FaceBookLoginTest()
        {
            LoginModel login = new LoginModel()
            {
                Email = "tejasmiley129@gmail.com",
                Password = "hello@3716"
            };
            AccountManager manager = new AccountManager();
            Assert.IsNotNull(manager.FaceBookLogin(login));
        }
    }
}