﻿using ExamDemo.Contracts;
using ExamDemo.Database.Contracts;
using ExamDemo.Model;
using System;

namespace ExamDemo.BusinessSevices.Services
{
    public class TokenService : IToken
    {
        private readonly ITokenDataService _tokenDataService;

        public TokenService(ITokenDataService tokenDataService)
        {
            _tokenDataService = tokenDataService;
        }
        public Users CreateToken(Users users)
        {
            try
            {
                var TokenData = _tokenDataService.CreateToken(users);
                if (TokenData == null)
                {
                    return null;
                }
                return TokenData;
            }
            catch(Exception ex)
            {
                throw (ex);
            }
            
        }
    }
}
