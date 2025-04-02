using System.ComponentModel;

namespace MyFirstProj.Domain.Enums
{
    public enum ReflistTitle : long
    {
        [Description("Mr")]
        Mr=1,
        [Description("Mrs")]
        Mrs =2,
        [Description("Miss")]
        Miss =3,
        [Description("Other")]
        Other =4

    }
}
