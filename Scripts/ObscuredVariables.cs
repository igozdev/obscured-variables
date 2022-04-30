using UnityEngine;

namespace ObscuredVariables
{
    /// <summary>
    /// Obscured version of data type int
    /// </summary>
    public struct OInt
    {
        private int ModifiedValue;
        private int Modifier;

        public OInt(int Value = 0)
        {   
            Modifier = Random.Range(-5000, 5000);
            ModifiedValue = Value + Modifier;
        }
        
        public int Value()
        {
            return ModifiedValue - Modifier;
        }

        public static OInt operator +(OInt x, OInt y)
        {
            return new OInt(x.Value() + y.Value());
        }

        public static OInt operator -(OInt x, OInt y)
        {
            return new OInt(x.Value() - y.Value());
        }

        public static OInt operator *(OInt x, OInt y)
        {
            return new OInt(x.Value() * y.Value());
        }

        public static OInt operator /(OInt x, OInt y)
        {
            return new OInt(x.Value() / y.Value());
        }

        public static OInt operator %(OInt x, OInt y)
        {
            return new OInt(x.Value() % y.Value());
        }

        public static OInt operator ++(OInt x)
        {
            return new OInt(x.Value() + 1);
        }

        public static OInt operator --(OInt x)
        {
            return new OInt(x.Value() - 1);
        }
    }

    /// <summary>
    /// Obscured version of data type uint
    /// </summary>
    public struct OUInt
    {
        private uint ModifiedValue;
        private uint Modifier;

        public OUInt(uint Value = 0)
        {
            Modifier = (uint)Random.Range(0, 10000);
            ModifiedValue = Value + Modifier;
        }

        public uint Value()
        {
            return ModifiedValue - Modifier;
        }

        public static OUInt operator +(OUInt x, OUInt y)
        {
            return new OUInt(x.Value() + y.Value());
        }

        public static OUInt operator -(OUInt x, OUInt y)
        {
            return new OUInt(x.Value() - y.Value());
        }

        public static OUInt operator *(OUInt x, OUInt y)
        {
            return new OUInt(x.Value() * y.Value());
        }

        public static OUInt operator /(OUInt x, OUInt y)
        {
            return new OUInt(x.Value() / y.Value());
        }

        public static OUInt operator %(OUInt x, OUInt y)
        {
            return new OUInt(x.Value() % y.Value());
        }

        public static OUInt operator ++(OUInt x)
        {
            return new OUInt(x.Value() + 1);
        }

        public static OUInt operator --(OUInt x)
        {
            return new OUInt(x.Value() - 1);
        }
    }

    /// <summary>
    /// Obscured version of data type long
    /// </summary>
    public struct OLong
    {
        private long ModifiedValue;
        private long Modifier;

        public OLong(long Value = 0)
        {
            Modifier = Random.Range(-50000, 50000);
            ModifiedValue = Value + Modifier;
        }

        public long Value()
        {
            return ModifiedValue - Modifier;
        }

        public static OLong operator +(OLong x, OLong y)
        {
            return new OLong(x.Value() + y.Value());
        }

        public static OLong operator -(OLong x, OLong y)
        {
            return new OLong(x.Value() - y.Value());
        }

        public static OLong operator *(OLong x, OLong y)
        {
            return new OLong(x.Value() * y.Value());
        }

        public static OLong operator /(OLong x, OLong y)
        {
            return new OLong(x.Value() / y.Value());
        }

        public static OLong operator %(OLong x, OLong y)
        {
            return new OLong(x.Value() % y.Value());
        }

        public static OLong operator ++(OLong x)
        {
            return new OLong(x.Value() + 1);
        }

        public static OLong operator --(OLong x)
        {
            return new OLong(x.Value() - 1);
        }
    }

    /// <summary>
    /// Obscured version of data type ulong
    /// </summary>
    public struct OULong
    {
        private ulong ModifiedValue;
        private ulong Modifier;

        public OULong(ulong Value = 0)
        {
            Modifier = (ulong)Random.Range(0, 100000);
            ModifiedValue = Value + Modifier;
        }

        public ulong Value()
        {
            return ModifiedValue - Modifier;
        }

        public static OULong operator +(OULong x, OULong y)
        {
            return new OULong(x.Value() + y.Value());
        }

        public static OULong operator -(OULong x, OULong y)
        {
            return new OULong(x.Value() - y.Value());
        }

        public static OULong operator *(OULong x, OULong y)
        {
            return new OULong(x.Value() * y.Value());
        }

        public static OULong operator /(OULong x, OULong y)
        {
            return new OULong(x.Value() / y.Value());
        }

        public static OULong operator %(OULong x, OULong y)
        {
            return new OULong(x.Value() % y.Value());
        }

        public static OULong operator ++(OULong x)
        {
            return new OULong(x.Value() + 1);
        }

        public static OULong operator --(OULong x)
        {
            return new OULong(x.Value() - 1);
        }
    }

    /// <summary>
    /// Obscured version of data type float
    /// </summary>
    public struct OFloat
    {
        private float ModifiedValue;
        private float Modifier;

        public OFloat(float Value = 0)
        {
            Modifier = Random.Range(-1000f, 1000f);
            ModifiedValue = Value + Modifier;
        }

        public float Value()
        {
            return ModifiedValue - Modifier;
        }

        public static OFloat operator +(OFloat x, OFloat y)
        {
            return new OFloat(x.Value() + y.Value());
        }

        public static OFloat operator -(OFloat x, OFloat y)
        {
            return new OFloat(x.Value() - y.Value());
        }

        public static OFloat operator *(OFloat x, OFloat y)
        {
            return new OFloat(x.Value() * y.Value());
        }

        public static OFloat operator /(OFloat x, OFloat y)
        {
            return new OFloat(x.Value() / y.Value());
        }

        public static OFloat operator %(OFloat x, OFloat y)
        {
            return new OFloat(x.Value() % y.Value());
        }

        public static OFloat operator ++(OFloat x)
        {
            return new OFloat(x.Value() + 1);
        }

        public static OFloat operator --(OFloat x)
        {
            return new OFloat(x.Value() - 1);
        }
    }

    /// <summary>
    /// Obscured version of data type double
    /// </summary>
    public struct ODouble
    {
        private double ModifiedValue;
        private double Modifier;

        public ODouble(double Value = 0)
        {
            Modifier = Random.Range(-1000f, 1000f);
            ModifiedValue = Value + Modifier;
        }

        public double Value()
        {
            return ModifiedValue - Modifier;
        }

        public static ODouble operator +(ODouble x, ODouble y)
        {
            return new ODouble(x.Value() + y.Value());
        }

        public static ODouble operator -(ODouble x, ODouble y)
        {
            return new ODouble(x.Value() - y.Value());
        }

        public static ODouble operator *(ODouble x, ODouble y)
        {
            return new ODouble(x.Value() * y.Value());
        }

        public static ODouble operator /(ODouble x, ODouble y)
        {
            return new ODouble(x.Value() / y.Value());
        }

        public static ODouble operator %(ODouble x, ODouble y)
        {
            return new ODouble(x.Value() % y.Value());
        }

        public static ODouble operator ++(ODouble x)
        {
            return new ODouble(x.Value() + 1);
        }

        public static ODouble operator --(ODouble x)
        {
            return new ODouble(x.Value() - 1);
        }
    }

    /// <summary>
    /// Obscured version of data type char
    /// </summary>
    public struct OChar
    {
        private int ModifiedValue;
        private int Modifier;

        public OChar(char Value = '\0')
        {
            Modifier = Random.Range(-5000, 5000);
            ModifiedValue = Value + Modifier;
        }

        public char Value()
        {
            return (char)(ModifiedValue - Modifier);
        }
    }
}
