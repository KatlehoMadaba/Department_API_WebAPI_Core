using System;

namespace MyFirstProj.Domain.Attributes
{
    public class DiscriminatorValue:Attribute
    {
        public  object Value { get; set; }

        public DiscriminatorValue( object value)
        {
            Value=value;
        }
    }
}
