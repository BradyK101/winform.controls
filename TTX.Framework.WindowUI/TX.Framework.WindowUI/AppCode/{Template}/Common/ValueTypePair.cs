#region COPYRIGHT
//
//     THIS IS GENERATED BY TEMPLATE
//     
//     AUTHOR  :     ROYE
//     DATE       :     2010
//
//     COPYRIGHT (C) 2010, TIANXIAHOTEL TECHNOLOGIES CO., LTD. ALL RIGHTS RESERVED.
//
#endregion

using System;
using System.Collections.Generic;
using System.Text;

namespace System.Text.Template
{
    public class ValueTypePair : IValueType
    {
        private object _Value;
        private Type _Type;

        public ValueTypePair()
            : this(null, typeof(object))
        {
        }

        public ValueTypePair(object value)
            : this(value, (value == null) ? typeof(object) : value.GetType())
        {
        }

        public ValueTypePair(object value, Type type)
        {
            _Value = value;
            _Type = type;
        }

        public object Value
        {
            get { return this._Value; }
            set { this._Value = value; }
        }

        public Type Type
        {
            get { return this._Type; }
            set { this._Type = value; }
        }
    }
}
