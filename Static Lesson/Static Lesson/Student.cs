using System;
using System.Collections.Generic;
using System.Text;

namespace Static_Lesson
{
    internal class Student
    {
        public Student()
        {
            _mainNo++;
            No = _mainNo;
        }
        public readonly int No;
        public string Fullname;
        private string _groupNo;
        private static int _mainNo;

        public string GroupNo
        {
            get => _groupNo;
            set
            {
                if (CheckGroupNo(value))
                {
                    _groupNo = value;
                }
            }

            
        }
        public static bool CheckGroupNo(string value)
        {
            if (Char.IsLetter(value[0]) && value.Length == 4)
            {
                for (int i = 1; i < value.Length; i++)
                {
                    if (!Char.IsDigit(value[i]))
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }


    }
}
