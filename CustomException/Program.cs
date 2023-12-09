using System;
using System.IO;
using System.Runtime.Serialization;

public class CustomException
{
    public static void Main()
    {
        try
        {
            throw new UserAlreadyLoggedInException("User is logged in - no duplicate session allowed");
        }
        catch(UserAlreadyLoggedInException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

[Serializable]
public class UserAlreadyLoggedInException : Exception
{
    public UserAlreadyLoggedInException(): base()
    {

    }
    public UserAlreadyLoggedInException(string message) : base(message)
    {

    }
    public UserAlreadyLoggedInException(string message, Exception innerException) : base(message, innerException)
    {
    }

    public UserAlreadyLoggedInException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}