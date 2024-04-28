using System;
using UnityEngine;

namespace Glitch9
{
    [Serializable]
    public class StringVariable : Variable
    {
        public static implicit operator string(StringVariable suffix) => suffix?.Value;
        public static implicit operator StringVariable(string suffix) => new(suffix);

        [SerializeField] private string value;

        public string Value
        {
            get => value;
            set => this.value = value;
        }

        public override object GetValue() => Value;
        public override void SetValue(object value)
        {
            if (value is not string str) throw new ArgumentException("Value must be a string");
            Value = str;
        }

        public StringVariable()
        {
        }

        public StringVariable(string value)
        {
            Value = value;
        }
    }
}