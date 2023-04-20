using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.block.Stack
{

    internal class DataStack
    {
        Dictionary<string, uType> stack;
        public DataStack(Dictionary<string, uType> stack)
        {
            this.stack = stack;
        }
        public DataStack()
        {
            stack = new Dictionary<string, uType>
            {
                {"f1", new uType("5", typeUData.Float) },
                {"f2", new uType("1", typeUData.Float) },
                {"s1", new uType("faw1", typeUData.String) },
                {"s2", new uType("Test2", typeUData.String) },
            };
        }
        public void AddToStack(uType value, string name)
        {
            stack.Add(name, value);
        }
        uType GetParam(string name)
        {
            if (stack.TryGetValue(name, out uType value))
            {
                return value;
            }
            return new uType(name, typeUData.String);
        }
        public float GetFloatValue(string name)
        {
            uType param = GetParam(name);
            object value = param.GetValue();
            if (value == null)
            {
                return 0f;
            }
            return (float)value;
        }
        public string GetStrValue(string name)
        {
            uType param = GetParam(name);
            object value = param.GetValue();
            if (value == null)
            {
                return "";
            }
            return (string)value;
        }
    }
}
