namespace Vehicle;

public abstract class SystemError
{
    private List<ErrorMessage> errorMessages = new List<ErrorMessage>();

    public void AddErrorMessage(ErrorMessage errorMessage)
    {
        errorMessages.Add(errorMessage);
    }

    public void ListErrorMessages()
    {
        if (errorMessages.Count == 0)
        {
            Console.WriteLine("No system errors.");
            return;
        }

        foreach (var error in errorMessages)
        {
            Console.WriteLine(error.ToString());
        }
    }


    public abstract class ErrorMessage
    {
        public abstract override string ToString();
    }

    public class EngineFailureError : ErrorMessage
    {
        public override string ToString()
        {
            return "Engine error. Check engine status!";
        }
    }

    public class BrakeFailureError : ErrorMessage
    {
        public override string ToString()
        {
            return "Brake error. The vehicle is unsafe to drive!";
        }
    }

    public class TransmissionError : ErrorMessage
    {
        public override string ToString()
        {
            return "Transmission error. Repair required!";
        }
    }
}