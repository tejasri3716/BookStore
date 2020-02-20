//--------------------------------------------------------------------------------------------------------------------
// <copyright file="ComputerFactory.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------

namespace DesignPatterns.FacadeDesignPattern
{
    class FacadeDesignPattern
    {

        private IShopping headphones;
        private IShopping mobile;
        private IShopping laptop;
        public FacadeDesignPattern()
        {
            headphones = new HeadPhones();
            mobile = new Mobile();
            laptop = new Laptop();
        }
        public void BuyHeadPhones()
        {
            headphones.BuyItem();
        }
        public void BuyMobile()
        {
            mobile.BuyItem();
        }
        public void BuyLaptop()
        {
            laptop.BuyItem();
        }
    }
}

