namespace HR.LeaveManagement.Application.Exceptions;

public class BadRequestException : ApplicationException
{
    public BadRequestException(string messsage) : base(messsage)
    {
        
    }
}
