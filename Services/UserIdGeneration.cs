namespace ProductsValidation.Services
{
    public class UserIdGeneration
    {
        private static int id = 0;

        public static int GetIdForUser()
        {
            return ++id;
        }
    }
}