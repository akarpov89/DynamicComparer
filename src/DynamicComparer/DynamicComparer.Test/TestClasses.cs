using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DynamicComparer.Test
{
    public class Primitive
    {
        public int A { get; set; }
        public uint B { get; set; }
        public long C { get; set; }
        public ulong D { get; set; }
        public short E { get; set; }
        public ushort F { get; set; }
        public byte G { get; set; }
        public sbyte H { get; set; }
        public char I { get; set; } 
        public double J { get; set; }
        public float K { get; set; }
        public IntPtr L { get; set; }
        public UIntPtr M { get; set; }
        public bool N { get; set; }

        public static Primitive Create()
        {
            return new Primitive
            {
                A = 1, B = 2, C = 3, D = 4, E = 5, F = 6, G = 7, H = 8, I = '9',
                J = 10.0, K = 11.0f, L = new IntPtr(12), M = new UIntPtr(13), N = true
            };
        }

        public Primitive WithNaNs()
        {
            J = double.NaN;
            K = float.NaN;
            return this;
        }

        public Primitive Clone()
        {
            return new Primitive
            {
                A = A, B = B, C = C, D = D, E = E, F = F, G = G, H = H, I = I,
                J = J, K = K, L = L, M = M, N = N
            };
        }
    }

}
