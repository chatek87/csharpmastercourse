namespace FrameworkLibrary
{
    public class Generators
    {
        public string WelcomeMessage(string prefix, string lastName)
        {
            return $"Welcome to our demo application, {prefix} {lastName}";
        }
        
        public string FarewellMessage(string prefix, string lastName)
        {
            return $"I hope you enjoted your time with us, {prefix} {lastName}. Please come back soon.";
        }
    }
}