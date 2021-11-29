namespace PracticalSecureCodingTraining.Classes;

public class StrongPasswordWithScore
{

    // Naji El Kotob
    // This is for demo only, please don't use it in production

    public enum PasswordScore
    {
        Blank,
        VeryWeak,
        Weak,
        Medium,
        Strong,
        VeryStrong
    }

    public static PasswordScore ValidateStrongPassword(string password, int minLength = 8)
    {
        // Set all checks to false
        var isUpper = false;
        var isLower = false;
        var isNumber = false;
        var isSpecialCharacters = false;
        var isMinimumLength = false;

        var score = 0;

        const string specialCharacters = @"!@#$%^&*()[]{}<>_-=+/\|'`~;,.";


        // Validated if blank
        if (password.Trim().Length == 0)
        {
            return PasswordScore.Blank;
        }


        // Validate all conditions
        if (password.Any(char.IsUpper))
        {
            isUpper = true;
            score++;
        }
        if (password.Any(char.IsLower))
        {
            isLower = true;
            score++;
        }
        if (password.Any(char.IsNumber))
        {
            isNumber = true;
            score++;
        }
        if (password.IndexOfAny(specialCharacters.ToCharArray()) != -1)
        {
            isSpecialCharacters = true;
            score++;
        }
        if (password.Length >= minLength)
        {
            isMinimumLength = true;
            score++;
        }

        //Validate strong password
        if (isUpper && isLower && isNumber && isSpecialCharacters && isMinimumLength)
        {
            return PasswordScore.VeryStrong;
        }
        else
        {          
            switch (score)
            {
                case 1:
                    return PasswordScore.VeryWeak;
                case 2:
                    return PasswordScore.Weak;
                case 3:
                    return PasswordScore.Medium;
                case 4:
                    return PasswordScore.Strong;
                default:
                    return PasswordScore.VeryWeak;
            }
        }
    }
}


