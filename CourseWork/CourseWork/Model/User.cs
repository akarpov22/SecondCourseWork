
namespace CourseWork.Model
{
    class User
    {
        private static string _passwordLVL1 = null;
        private static string _passwordLVL2 = null;

        public static string PasswordLVL1 { get => _passwordLVL1; set => _passwordLVL1 = value; }
        public static string PasswordLVL2 { get => _passwordLVL2; set => _passwordLVL2 = value; }
    }
}
