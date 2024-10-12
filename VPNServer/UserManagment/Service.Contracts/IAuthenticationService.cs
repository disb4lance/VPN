﻿using Microsoft.AspNetCore.Identity;
using Shared.TransferObjects;


namespace Service.Contracts
{
    public interface IAuthenticationService
    {
        Task<IdentityResult> RegisterUser(UserForRegistrationDto userForRegistration);
        Task<bool> ValidateUser(UserForAuthenticationDto userForAuth);

    }
}
