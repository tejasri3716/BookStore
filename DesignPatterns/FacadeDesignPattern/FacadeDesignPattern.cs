//--------------------------------------------------------------------------------------------------------------------
// <copyright file="FacadeDesignPattern.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.FacadeDesignPattern
{
    /// <summary>
    /// FacadeDesignPattern class uses IShopping interface
    /// </summary>
    public class FacadeDesignPattern
    {
        /// <summary>
        /// The headphones
        /// </summary>
        private IShopping headphones;

        /// <summary>
        /// The mobile
        /// </summary>
        private IShopping mobile;

        /// <summary>
        /// The laptop
        /// </summary>
        private IShopping laptop;

        /// <summary>
        /// Initializes a new instance of the <see cref="FacadeDesignPattern"/> class.
        /// </summary>
        public FacadeDesignPattern()
        {
            this.headphones = new HeadPhones();
            this.mobile = new Mobile();
            this.laptop = new Laptop();
        }

        /// <summary>
        /// Buys the head phones.
        /// </summary>
        public void BuyHeadPhones()
        {
            this.headphones.BuyItem();
        }

        /// <summary>
        /// Buys the mobile.
        /// </summary>
        public void BuyMobile()
        {
            this.mobile.BuyItem();
        }

        /// <summary>
        /// Buys the laptop.
        /// </summary>
        public void BuyLaptop()
        {
            this.laptop.BuyItem();
        }
    }
}