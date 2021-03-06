﻿namespace Egnyte.Api.Users
{
    public class ExistingUser
    {
        internal ExistingUser(
            string userName,
            string externalId,
            string email,
            string familyName,
            string givenName,
            bool active,
            UserAuthType authType,
            UserType userType,
            string role,
            string idpUserId,
            string userPrincipalName,
            long id,
            bool locked)
        {
            UserName = userName;
            ExternalId = externalId;
            Email = email;
            FamilyName = familyName;
            GivenName = givenName;
            Active = active;
            AuthType = authType;
            UserType = userType;
            Role = role;
            IdpUserId = idpUserId;
            UserPrincipalName = userPrincipalName;
            Id = id;
            Locked = locked;
        }

        /// <summary>
        /// Required. The Egnyte username for the user. Username must start with a letter or digit.
        /// Special characters are not supported (with the exception of periods, hyphens, and underscores)
        /// </summary>
        public string UserName { get; private set; }

        /// <summary>
        /// Required. This is an immutable unique identifier provided by the API consumer.
        /// Any plain text (e.g. S-1-5-21-3623811015-3361044348-30300820-1013)
        /// </summary>
        public string ExternalId { get; private set; }

        /// <summary>
        /// Required. The email address of the user. Any valid email address (e.g. admin@acme.com)
        /// </summary>
        public string Email { get; private set; }

        /// <summary>
        /// Required. The last name of the user. Any plain text (e.g. Smith)
        /// </summary>
        public string FamilyName { get; private set; }

        /// <summary>
        /// Required. The first name of the user. Any plain text (e.g. John)
        /// </summary>
        public string GivenName { get; private set; }

        /// <summary>
        /// Required. Whether the user is active or inactive
        /// </summary>
        public bool Active { get; private set; }

        /// <summary>
        /// Required. The authentication type for the user
        /// </summary>
        public UserAuthType AuthType { get; private set; }

        /// <summary>
        /// Required. The type of the user
        /// </summary>
        public UserType UserType { get; private set; }

        /// <summary>
        /// Optional. The role assigned to the user. Only applicable for Power Users.
        /// Value can be 'Default' or custom role name
        /// </summary>
        public string Role { get; private set; }

        /// <summary>
        /// Optional. Only required if the user is SSO authenticated and not using default user mapping.
        /// Do not specify if user is not SSO authenticated. This is the way the user is identified within
        /// the SAML Response from an SSO Identity Provider, i.e. the SAML Subject (e.g. jsmith)
        /// </summary>
        public string IdpUserId { get; private set; }

        /// <summary>
        /// Optional. Do not specify if user is not AD authenticated. Used to bind child authentication policies
        /// to a user when using Active Directory authentication in a multi-domain setup (e.g. jmiller@example.com)
        /// </summary>
        public string UserPrincipalName { get; private set; }

        /// <summary>
        /// An opaque, immutable, unique identifier for the user, generated by Egnyte.
        /// This identifier is used to refer to the user in all API calls
        /// </summary>
        public long Id { get; private set; }

        /// <summary>
        /// If user is locked
        /// </summary>
        public bool Locked { get; private set; }
    }
}
