﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winwink.LearnCsharpCollection.chapter5
{
    public class ArithMeticExpression
    {
        private Stack<double> _numbers;
        private Stack<string> _operators;
        private string _expression;
        public ArithMeticExpression()
        {
            _numbers = new Stack<double>();
            _operators = new Stack<string>();
        }

        //"10 + 5 - 6 * 7"
        //没有考虑括号和算术优先级
        public ArithMeticExpression(string expression)
        {
            _numbers = new Stack<double>();
            _operators = new Stack<string>();
            _expression = expression;
        }

        //private void ParseExpression(string expression)
        //{
        //    var arr = expression.Split(new string[] { " " }, StringSplitOptions.None);
        //    for(int i=0;i<arr.Length;i++)
        //    {
        //        var value = arr[i];
        //        var result = IsInteger(value);
        //        if(result.Item1)
        //        {
        //            _numbers.Push(result.Item2);
        //        }
        //        else
        //        {
        //            _operators.Push(value);
        //        }
        //    }
        //}

        public double Result()
        {
            var arr = _expression.Split(new string[] { " " }, StringSplitOptions.None);
            Queue<string> qu = new Queue<string>(arr);
            while(qu.Count>0 || _numbers.Count>1)
            {
                if(_numbers.Count ==2)
                {
                    var value2 = _numbers.Pop();
                    var value1 = _numbers.Pop();
                    var op = _operators.Pop();
                    var result = Calc(value1, value2, op);
                    _numbers.Push(result);
                }
                else
                {
                    var s = qu.Dequeue();
                    var isInt = IsInteger(s);
                    if(isInt.Item1)
                    {
                        _numbers.Push(isInt.Item2);
                    }
                    else
                    {
                        _operators.Push(s);
                    }
                }
            }
            return _numbers.Peek();
        }

        private Tuple<bool,int> IsInteger(string value)
        {
            int result = 0;
            var isInteger = false;
            if(int.TryParse(value, out result))
            {
                isInteger = true;
            }

            return new Tuple<bool, int>(isInteger, result);
        }

        private double Calc(double value1, double value2, string op)
        {
            double result = 0.0;
            switch(op)
            {
                case "+":
                    result = value1 + value2;
                    break;
                case "-":
                    result = value1 - value2;
                    break;
                case "*":
                    result = value1 * value2;
                    break;
                case "/":
                    result = value1 / value2;
                    break;
                default:
                    throw new ArgumentException("Not support operator:" + op);
                    break;
            }
            return result;
        }


    }


}
