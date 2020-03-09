namespace Model.UserModel
{
    /// <summary>
    /// JwtSettings class is used to set and the secret key
    /// </summary>
    public class JwtSettings
    {
        /// <summary>
        /// The secret
        /// </summary>
        private string secret;

        /// <summary>
        /// Gets or sets the secret.
        /// </summary>
        /// <value>
        /// The secret.
        /// </value>
        public string Secret { get => this.secret; set => this.secret = value; }
    }
}