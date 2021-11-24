namespace PracticalSecureCodingTraining.Classes;

public static class StrongPassword
{
    public static bool ValidateStrongPassword(string password, int minLength = 8)
    {
        // Set all checks to false
        var isUpper = false;
        var isLower = false;
        var isNumber = false;
        var isSpecialCharacters = false;
        var isMinimumLength = false;

        const string specialCharacters = @"!@#$%^&*()[]{}<>_-=+/\|'`~;,.";

        // Validate all conditions
        if (password.Any(char.IsUpper))
        {
            isUpper = true;
        }
        if (password.Any(char.IsLower))
        {
            isLower = true;
        }
        if (password.Any(char.IsNumber))
        {
            isNumber = true;
        }
        if (password.IndexOfAny(specialCharacters.ToCharArray()) != -1)
        {
            isSpecialCharacters = true;
        }
        if (password.Length >= minLength)
        {
            isMinimumLength = true;
        }
        
        //Validate strong password
        if (isUpper && isLower && isNumber && isSpecialCharacters && isMinimumLength)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}


