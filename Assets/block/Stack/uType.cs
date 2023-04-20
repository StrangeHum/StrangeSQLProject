using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.block.Stack
{
    /// <summary>
    /// Кастомный тип данных для блок схемы
    /// </summary>
    internal class uType
    {
        string value;
        typeUData type;
        
        public uType(string value, typeUData type)
        {
            this.value = value;
            this.type = type;
        }

        public object GetValue()
        {
            switch (type)
            {
                case typeUData.Float:
                    return float.Parse(value);
                case typeUData.String:
                    return value;
            }
            return null;
        }
    }
}
