using System;

namespace ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            char    _OPERATOR;
            int     _FirstParam;
            int     _SecoundParam;
            double  _RESULT;
            Console.WriteLine("Enter first param : ");
            _FirstParam =  int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Secound Param : ");
            _SecoundParam = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter OP : ");
            _OPERATOR = char.Parse(Console.ReadLine());
            
            if (_OPERATOR == '+')
            {
                _RESULT = _FirstParam + _SecoundParam;
            }
            else if(_OPERATOR == '-')
            {
                _RESULT = _FirstParam - _SecoundParam;
            }
            else if(_OPERATOR == '*')
            {
                _RESULT = _FirstParam * _SecoundParam;
            }
            else if (_OPERATOR == '/')
            {
                 _RESULT = _FirstParam / _SecoundParam;
            }
            else
            {
                 _RESULT = _FirstParam % _SecoundParam;
            }
            Console.WriteLine($"YOUR RESULT : {_RESULT}");
        }
    }
}
