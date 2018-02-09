using System.Collections.Generic;

namespace SaiYuan
{
    class CmdParameter
    {
        string _shortName;
        string _value;
        string _description;
        string _errorMessage;
        bool _nessesary;

        public CmdParameter(string shortName, bool nessesary, string description, string errorMessage)
        {
            _shortName = shortName;
            _nessesary = nessesary;
            _description = description;
            _errorMessage = errorMessage;
        }

        public string GetName()
        {
            return _shortName;
        }

        public void SetValue(string value)
        {
            _value = value;
        }

        public string GetValue()
        {
            return _shortName;
        }

        public bool IsNessesary()
        {
            return _nessesary;
        }

        public string GetDescription()
        {
            return _description;
        }

        public string GetErrorMessage()
        {
            return _errorMessage;
        }
    }

    class ParameterParser
    {
        List<CmdParameter> paramLists = new List<CmdParameter>();

        public ParameterParser(object[,] arguments)
        {
            for (int i = 0; i < arguments.Length / 4/* CmdParameter 构造函数需要的参数个数 */; i ++ )
            {
                CmdParameter parameter = new CmdParameter((string)arguments[i, 0], (bool)arguments[i, 1], (string)arguments[i, 2], (string)arguments[i, 3]);
                paramLists.Add(parameter);
            }
        }

        private bool GetArguments(string key, string next)
        {
            bool result = false;
            for (int i = 0; i < paramLists.Count; i++)
            {
                if (paramLists[i].GetName().Equals(key))
                {
                    paramLists[i].SetValue(next);
                    result = true;
                }
            }
            return result;
        }

        private string CheckArguments()
        {
            for (int i = 0; i < paramLists.Count; i++)
            {
                CmdParameter parameter = paramLists[i];
                if (parameter.IsNessesary() && StringUtils.IsEmpty(parameter.GetValue()))
                {
                    return parameter.GetErrorMessage();
                }
            }
            return null;
        }

        public string Parse(string[] arguments)
        {
            for (int i = 0; i < arguments.Length; i++)
            {
                if (arguments[i].StartsWith("-"))
                {
                    string key = arguments[i].Substring(1);
                    if (GetArguments(key, arguments[i+1]))
                    {
                        ++i;
                    }
                    else
                    {
                        return Useage();
                    }
                }
                else
                {
                    return Useage();
                }
            }
            return CheckArguments();
        }

        public string Useage()
        {
            return null;
        }
    }
}