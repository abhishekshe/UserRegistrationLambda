using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistrationProblem
{
    public class UserRegistrationCustomException : Exception
    {

        public enum ExceptionType
        {
            invalid_name, invalid_email, invalid_phone, invalid_password, EMPTY_MESSAGE
        }
        private readonly ExceptionType type;

        public UserRegistrationCustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
