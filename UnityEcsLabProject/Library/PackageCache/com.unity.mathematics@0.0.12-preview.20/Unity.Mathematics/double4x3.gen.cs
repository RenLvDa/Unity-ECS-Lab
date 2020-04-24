// GENERATED CODE
using System;
using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [System.Serializable]
    public partial struct double4x3 : System.IEquatable<double4x3>, IFormattable
    {
        public double4 c0;
        public double4 c1;
        public double4 c2;

        /// <summary>double4x3 zero value.</summary>
        public static readonly double4x3 zero;

        /// <summary>Constructs a double4x3 matrix from three double4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double4x3(double4 c0, double4 c1, double4 c2)
        { 
            this.c0 = c0;
            this.c1 = c1;
            this.c2 = c2;
        }

        /// <summary>Constructs a double4x3 matrix from 12 double values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double4x3(double m00, double m01, double m02,
                         double m10, double m11, double m12,
                         double m20, double m21, double m22,
                         double m30, double m31, double m32)
        { 
            this.c0 = new double4(m00, m10, m20, m30);
            this.c1 = new double4(m01, m11, m21, m31);
            this.c2 = new double4(m02, m12, m22, m32);
        }

        /// <summary>Constructs a double4x3 matrix from a single double value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double4x3(double v)
        {
            this.c0 = v;
            this.c1 = v;
            this.c2 = v;
        }

        /// <summary>Constructs a double4x3 matrix from a single bool value by converting it to double and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double4x3(bool v)
        {
            this.c0 = math.select(new double4(0.0), new double4(1.0), v);
            this.c1 = math.select(new double4(0.0), new double4(1.0), v);
            this.c2 = math.select(new double4(0.0), new double4(1.0), v);
        }

        /// <summary>Constructs a double4x3 matrix from a bool4x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double4x3(bool4x3 v)
        {
            this.c0 = math.select(new double4(0.0), new double4(1.0), v.c0);
            this.c1 = math.select(new double4(0.0), new double4(1.0), v.c1);
            this.c2 = math.select(new double4(0.0), new double4(1.0), v.c2);
        }

        /// <summary>Constructs a double4x3 matrix from a single int value by converting it to double and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double4x3(int v)
        {
            this.c0 = v;
            this.c1 = v;
            this.c2 = v;
        }

        /// <summary>Constructs a double4x3 matrix from a int4x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double4x3(int4x3 v)
        {
            this.c0 = v.c0;
            this.c1 = v.c1;
            this.c2 = v.c2;
        }

        /// <summary>Constructs a double4x3 matrix from a single uint value by converting it to double and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double4x3(uint v)
        {
            this.c0 = v;
            this.c1 = v;
            this.c2 = v;
        }

        /// <summary>Constructs a double4x3 matrix from a uint4x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double4x3(uint4x3 v)
        {
            this.c0 = v.c0;
            this.c1 = v.c1;
            this.c2 = v.c2;
        }

        /// <summary>Constructs a double4x3 matrix from a single float value by converting it to double and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double4x3(float v)
        {
            this.c0 = v;
            this.c1 = v;
            this.c2 = v;
        }

        /// <summary>Constructs a double4x3 matrix from a float4x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double4x3(float4x3 v)
        {
            this.c0 = v.c0;
            this.c1 = v.c1;
            this.c2 = v.c2;
        }


        /// <summary>Implicitly converts a single double value to a double4x3 matrix by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double4x3(double v) { return new double4x3(v); }

        /// <summary>Explicitly converts a single bool value to a double4x3 matrix by converting it to double and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double4x3(bool v) { return new double4x3(v); }

        /// <summary>Explicitly converts a bool4x3 matrix to a double4x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double4x3(bool4x3 v) { return new double4x3(v); }

        /// <summary>Implicitly converts a single int value to a double4x3 matrix by converting it to double and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double4x3(int v) { return new double4x3(v); }

        /// <summary>Implicitly converts a int4x3 matrix to a double4x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double4x3(int4x3 v) { return new double4x3(v); }

        /// <summary>Implicitly converts a single uint value to a double4x3 matrix by converting it to double and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double4x3(uint v) { return new double4x3(v); }

        /// <summary>Implicitly converts a uint4x3 matrix to a double4x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double4x3(uint4x3 v) { return new double4x3(v); }

        /// <summary>Implicitly converts a single float value to a double4x3 matrix by converting it to double and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double4x3(float v) { return new double4x3(v); }

        /// <summary>Implicitly converts a float4x3 matrix to a double4x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double4x3(float4x3 v) { return new double4x3(v); }


        /// <summary>Returns the result of a componentwise multiplication operation on two double4x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x3 operator * (double4x3 lhs, double4x3 rhs) { return new double4x3 (lhs.c0 * rhs.c0, lhs.c1 * rhs.c1, lhs.c2 * rhs.c2); }

        /// <summary>Returns the result of a componentwise multiplication operation on a double4x3 matrix and a double value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x3 operator * (double4x3 lhs, double rhs) { return new double4x3 (lhs.c0 * rhs, lhs.c1 * rhs, lhs.c2 * rhs); }

        /// <summary>Returns the result of a componentwise multiplication operation on a double value and a double4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x3 operator * (double lhs, double4x3 rhs) { return new double4x3 (lhs * rhs.c0, lhs * rhs.c1, lhs * rhs.c2); }


        /// <summary>Returns the result of a componentwise addition operation on two double4x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x3 operator + (double4x3 lhs, double4x3 rhs) { return new double4x3 (lhs.c0 + rhs.c0, lhs.c1 + rhs.c1, lhs.c2 + rhs.c2); }

        /// <summary>Returns the result of a componentwise addition operation on a double4x3 matrix and a double value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x3 operator + (double4x3 lhs, double rhs) { return new double4x3 (lhs.c0 + rhs, lhs.c1 + rhs, lhs.c2 + rhs); }

        /// <summary>Returns the result of a componentwise addition operation on a double value and a double4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x3 operator + (double lhs, double4x3 rhs) { return new double4x3 (lhs + rhs.c0, lhs + rhs.c1, lhs + rhs.c2); }


        /// <summary>Returns the result of a componentwise subtraction operation on two double4x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x3 operator - (double4x3 lhs, double4x3 rhs) { return new double4x3 (lhs.c0 - rhs.c0, lhs.c1 - rhs.c1, lhs.c2 - rhs.c2); }

        /// <summary>Returns the result of a componentwise subtraction operation on a double4x3 matrix and a double value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x3 operator - (double4x3 lhs, double rhs) { return new double4x3 (lhs.c0 - rhs, lhs.c1 - rhs, lhs.c2 - rhs); }

        /// <summary>Returns the result of a componentwise subtraction operation on a double value and a double4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x3 operator - (double lhs, double4x3 rhs) { return new double4x3 (lhs - rhs.c0, lhs - rhs.c1, lhs - rhs.c2); }


        /// <summary>Returns the result of a componentwise division operation on two double4x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x3 operator / (double4x3 lhs, double4x3 rhs) { return new double4x3 (lhs.c0 / rhs.c0, lhs.c1 / rhs.c1, lhs.c2 / rhs.c2); }

        /// <summary>Returns the result of a componentwise division operation on a double4x3 matrix and a double value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x3 operator / (double4x3 lhs, double rhs) { return new double4x3 (lhs.c0 / rhs, lhs.c1 / rhs, lhs.c2 / rhs); }

        /// <summary>Returns the result of a componentwise division operation on a double value and a double4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x3 operator / (double lhs, double4x3 rhs) { return new double4x3 (lhs / rhs.c0, lhs / rhs.c1, lhs / rhs.c2); }


        /// <summary>Returns the result of a componentwise modulus operation on two double4x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x3 operator % (double4x3 lhs, double4x3 rhs) { return new double4x3 (lhs.c0 % rhs.c0, lhs.c1 % rhs.c1, lhs.c2 % rhs.c2); }

        /// <summary>Returns the result of a componentwise modulus operation on a double4x3 matrix and a double value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x3 operator % (double4x3 lhs, double rhs) { return new double4x3 (lhs.c0 % rhs, lhs.c1 % rhs, lhs.c2 % rhs); }

        /// <summary>Returns the result of a componentwise modulus operation on a double value and a double4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x3 operator % (double lhs, double4x3 rhs) { return new double4x3 (lhs % rhs.c0, lhs % rhs.c1, lhs % rhs.c2); }


        /// <summary>Returns the result of a componentwise increment operation on a double4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x3 operator ++ (double4x3 val) { return new double4x3 (++val.c0, ++val.c1, ++val.c2); }


        /// <summary>Returns the result of a componentwise decrement operation on a double4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x3 operator -- (double4x3 val) { return new double4x3 (--val.c0, --val.c1, --val.c2); }


        /// <summary>Returns the result of a componentwise less than operation on two double4x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator < (double4x3 lhs, double4x3 rhs) { return new bool4x3 (lhs.c0 < rhs.c0, lhs.c1 < rhs.c1, lhs.c2 < rhs.c2); }

        /// <summary>Returns the result of a componentwise less than operation on a double4x3 matrix and a double value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator < (double4x3 lhs, double rhs) { return new bool4x3 (lhs.c0 < rhs, lhs.c1 < rhs, lhs.c2 < rhs); }

        /// <summary>Returns the result of a componentwise less than operation on a double value and a double4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator < (double lhs, double4x3 rhs) { return new bool4x3 (lhs < rhs.c0, lhs < rhs.c1, lhs < rhs.c2); }


        /// <summary>Returns the result of a componentwise less or equal operation on two double4x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator <= (double4x3 lhs, double4x3 rhs) { return new bool4x3 (lhs.c0 <= rhs.c0, lhs.c1 <= rhs.c1, lhs.c2 <= rhs.c2); }

        /// <summary>Returns the result of a componentwise less or equal operation on a double4x3 matrix and a double value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator <= (double4x3 lhs, double rhs) { return new bool4x3 (lhs.c0 <= rhs, lhs.c1 <= rhs, lhs.c2 <= rhs); }

        /// <summary>Returns the result of a componentwise less or equal operation on a double value and a double4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator <= (double lhs, double4x3 rhs) { return new bool4x3 (lhs <= rhs.c0, lhs <= rhs.c1, lhs <= rhs.c2); }


        /// <summary>Returns the result of a componentwise greater than operation on two double4x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator > (double4x3 lhs, double4x3 rhs) { return new bool4x3 (lhs.c0 > rhs.c0, lhs.c1 > rhs.c1, lhs.c2 > rhs.c2); }

        /// <summary>Returns the result of a componentwise greater than operation on a double4x3 matrix and a double value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator > (double4x3 lhs, double rhs) { return new bool4x3 (lhs.c0 > rhs, lhs.c1 > rhs, lhs.c2 > rhs); }

        /// <summary>Returns the result of a componentwise greater than operation on a double value and a double4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator > (double lhs, double4x3 rhs) { return new bool4x3 (lhs > rhs.c0, lhs > rhs.c1, lhs > rhs.c2); }


        /// <summary>Returns the result of a componentwise greater or equal operation on two double4x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator >= (double4x3 lhs, double4x3 rhs) { return new bool4x3 (lhs.c0 >= rhs.c0, lhs.c1 >= rhs.c1, lhs.c2 >= rhs.c2); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a double4x3 matrix and a double value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator >= (double4x3 lhs, double rhs) { return new bool4x3 (lhs.c0 >= rhs, lhs.c1 >= rhs, lhs.c2 >= rhs); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a double value and a double4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator >= (double lhs, double4x3 rhs) { return new bool4x3 (lhs >= rhs.c0, lhs >= rhs.c1, lhs >= rhs.c2); }


        /// <summary>Returns the result of a componentwise unary minus operation on a double4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x3 operator - (double4x3 val) { return new double4x3 (-val.c0, -val.c1, -val.c2); }


        /// <summary>Returns the result of a componentwise unary plus operation on a double4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x3 operator + (double4x3 val) { return new double4x3 (+val.c0, +val.c1, +val.c2); }


        /// <summary>Returns the result of a componentwise equality operation on two double4x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator == (double4x3 lhs, double4x3 rhs) { return new bool4x3 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1, lhs.c2 == rhs.c2); }

        /// <summary>Returns the result of a componentwise equality operation on a double4x3 matrix and a double value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator == (double4x3 lhs, double rhs) { return new bool4x3 (lhs.c0 == rhs, lhs.c1 == rhs, lhs.c2 == rhs); }

        /// <summary>Returns the result of a componentwise equality operation on a double value and a double4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator == (double lhs, double4x3 rhs) { return new bool4x3 (lhs == rhs.c0, lhs == rhs.c1, lhs == rhs.c2); }


        /// <summary>Returns the result of a componentwise not equal operation on two double4x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator != (double4x3 lhs, double4x3 rhs) { return new bool4x3 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1, lhs.c2 != rhs.c2); }

        /// <summary>Returns the result of a componentwise not equal operation on a double4x3 matrix and a double value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator != (double4x3 lhs, double rhs) { return new bool4x3 (lhs.c0 != rhs, lhs.c1 != rhs, lhs.c2 != rhs); }

        /// <summary>Returns the result of a componentwise not equal operation on a double value and a double4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator != (double lhs, double4x3 rhs) { return new bool4x3 (lhs != rhs.c0, lhs != rhs.c1, lhs != rhs.c2); }



        /// <summary>Returns the double4 element at a specified index.</summary>
        unsafe public double4 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 3)
                    throw new System.ArgumentException("index must be between[0...2]");
#endif
                fixed (double4x3* array = &this) { return ((double4*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 3)
                    throw new System.ArgumentException("index must be between[0...2]");
#endif
                fixed (double4* array = &c0) { array[index] = value; }
            }
        }

        /// <summary>Returns true if the double4x3 is equal to a given double4x3, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(double4x3 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1) && c2.Equals(rhs.c2); }

        /// <summary>Returns true if the double4x3 is equal to a given double4x3, false otherwise.</summary>
        public override bool Equals(object o) { return Equals((double4x3)o); }


        /// <summary>Returns a hash code for the double4x3.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)math.hash(this); }


        /// <summary>Returns a string representation of the double4x3.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("double4x3({0}, {1}, {2},  {3}, {4}, {5},  {6}, {7}, {8},  {9}, {10}, {11})", c0.x, c1.x, c2.x, c0.y, c1.y, c2.y, c0.z, c1.z, c2.z, c0.w, c1.w, c2.w);
        }

        /// <summary>Returns a string representation of the double4x3 using a specified format and culture-specific format information.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("double4x3({0}, {1}, {2},  {3}, {4}, {5},  {6}, {7}, {8},  {9}, {10}, {11})", c0.x.ToString(format, formatProvider), c1.x.ToString(format, formatProvider), c2.x.ToString(format, formatProvider), c0.y.ToString(format, formatProvider), c1.y.ToString(format, formatProvider), c2.y.ToString(format, formatProvider), c0.z.ToString(format, formatProvider), c1.z.ToString(format, formatProvider), c2.z.ToString(format, formatProvider), c0.w.ToString(format, formatProvider), c1.w.ToString(format, formatProvider), c2.w.ToString(format, formatProvider));
        }

    }

    public static partial class math
    {
        /// <summary>Returns a double4x3 matrix constructed from three double4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x3 double4x3(double4 c0, double4 c1, double4 c2) { return new double4x3(c0, c1, c2); }

        /// <summary>Returns a double4x3 matrix constructed from from 12 double values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x3 double4x3(double m00, double m01, double m02,
                                          double m10, double m11, double m12,
                                          double m20, double m21, double m22,
                                          double m30, double m31, double m32)
        {
            return new double4x3(m00, m01, m02,
                                 m10, m11, m12,
                                 m20, m21, m22,
                                 m30, m31, m32);
        }

        /// <summary>Returns a double4x3 matrix constructed from a single double value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x3 double4x3(double v) { return new double4x3(v); }

        /// <summary>Returns a double4x3 matrix constructed from a single bool value by converting it to double and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x3 double4x3(bool v) { return new double4x3(v); }

        /// <summary>Return a double4x3 matrix constructed from a bool4x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x3 double4x3(bool4x3 v) { return new double4x3(v); }

        /// <summary>Returns a double4x3 matrix constructed from a single int value by converting it to double and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x3 double4x3(int v) { return new double4x3(v); }

        /// <summary>Return a double4x3 matrix constructed from a int4x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x3 double4x3(int4x3 v) { return new double4x3(v); }

        /// <summary>Returns a double4x3 matrix constructed from a single uint value by converting it to double and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x3 double4x3(uint v) { return new double4x3(v); }

        /// <summary>Return a double4x3 matrix constructed from a uint4x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x3 double4x3(uint4x3 v) { return new double4x3(v); }

        /// <summary>Returns a double4x3 matrix constructed from a single float value by converting it to double and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x3 double4x3(float v) { return new double4x3(v); }

        /// <summary>Return a double4x3 matrix constructed from a float4x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x3 double4x3(float4x3 v) { return new double4x3(v); }

        /// <summary>Return the double3x4 transpose of a double4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x4 transpose(double4x3 v)
        {
            return double3x4(
                v.c0.x, v.c0.y, v.c0.z, v.c0.w,
                v.c1.x, v.c1.y, v.c1.z, v.c1.w,
                v.c2.x, v.c2.y, v.c2.z, v.c2.w);
        }

        /// <summary>Returns a uint hash code of a double4x3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(double4x3 v)
        {
            return csum(fold_to_uint(v.c0) * uint4(0x7AA07CD3u, 0xAF642BA9u, 0xA8F2213Bu, 0x9F3FDC37u) + 
                        fold_to_uint(v.c1) * uint4(0xAC60D0C3u, 0x9263662Fu, 0xE69626FFu, 0xBD010EEBu) + 
                        fold_to_uint(v.c2) * uint4(0x9CEDE1D1u, 0x43BE0B51u, 0xAF836EE1u, 0xB130C137u)) + 0x54834775u;
        }

        /// <summary>
        /// Returns a uint4 vector hash code of a double4x3 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 hashwide(double4x3 v)
        {
            return (fold_to_uint(v.c0) * uint4(0x7C022221u, 0xA2D00EDFu, 0xA8977779u, 0x9F1C739Bu) + 
                    fold_to_uint(v.c1) * uint4(0x4B1BD187u, 0x9DF50593u, 0xF18EEB85u, 0x9E19BFC3u) + 
                    fold_to_uint(v.c2) * uint4(0x8196B06Fu, 0xD24EFA19u, 0x7D8048BBu, 0x713BD06Fu)) + 0x753AD6ADu;
        }

    }
}
