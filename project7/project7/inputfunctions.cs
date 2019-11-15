using System;

public class InputFunctions
{
	public InputFunctions()
	{

	}

    public bool verifyEmail(string email)
    {
        try
        {
            var address = new System.Net.Mail.MailAddress(email);
        }
        catch
        {
            return false;
        }
        return true;
    }
}
