using System;

namespace Open_Lab_01._01
{
    public class Exercise
    {
        public bool IsLessThan10(string input)
        {
            int num = int.Parse(input);

            if (num < 10) {
                return true;
            }
            else {
                return false;
            }
            throw new NotImplementedException();
        }
    }
}
