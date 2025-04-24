namespace LibDemo1
{
    public class LibClass1
    {
        private string _message;
        public LibClass1(string message) 
        {
            _message = message;
        }
        public string GetMessage()
        {
            return $"{_message} from Library1";
        }
    }
}
