namespace AspectDemo.Exceptions
{
    public class CustomerAlreadyExistsException: ApplicationException
        {
            public CustomerAlreadyExistsException() { }
            public CustomerAlreadyExistsException(string msg) : base(msg) { }
        }
    
}
