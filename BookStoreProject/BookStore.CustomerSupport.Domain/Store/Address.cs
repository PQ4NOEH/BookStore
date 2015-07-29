using BookStore.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BookStore.CustomerSupport.Domain.Store
{
    public class Address: IValueObject
    {
        public string Street { get; set; }
        public int Number { get; set; }
        public FlatNumber FlatNumber { get; set; }
    }

    public class FlatNumber
    {
        readonly List<string> _admitedValues = new List<string>
        {
            "floor"
        };
        private string _value;
        public string Value{
            get
            {
                return _value;
            } 
            set
            {
                ValidateValue(value);
                _value = value;
            }
        }
        
        public FlatNumber(string value)
        {
            Value = value;
        }

        protected void ValidateValue(string val)
        {
            int castedValue;
            if(int.TryParse(val, out castedValue))
            {
                if (castedValue < -1 && castedValue < 2)
                {
                    throw new InvalidFlatNumberException();
                }
            }
            else if (!_admitedValues.Any((v)=> v.Equals(val, StringComparison.OrdinalIgnoreCase)))
            {
                throw new InvalidFlatNumberException();
            }
        }
    }

    public class InvalidFlatNumberException:DomainException
    {
        public InvalidFlatNumberException() : base(1, "Only 1-100 numbers and floor values are admited") { }
    }
}
