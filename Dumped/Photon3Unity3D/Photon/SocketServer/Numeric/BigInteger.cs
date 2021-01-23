/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 42: Photon3Unity3D.dll - Assembly: Photon3Unity3D, Version=4.1.1.2, Culture=neutral, PublicKeyToken=null

namespace Photon.SocketServer.Numeric
{
	internal class BigInteger
	{
		// Fields
		public static readonly int[] primesBelow2000;
		private uint[] data;
		public int dataLength;
	
		// Constructors
		public BigInteger();
		public BigInteger(long value);
		public BigInteger(BigInteger bi);
		public BigInteger(byte[] inData);
		public BigInteger(uint[] inData);
		static BigInteger();
	
		// Methods
		public static implicit operator BigInteger(long value);
		public static implicit operator BigInteger(int value);
		public static BigInteger operator +(BigInteger bi1, BigInteger bi2);
		public static BigInteger operator -(BigInteger bi1, BigInteger bi2);
		public static BigInteger operator *(BigInteger bi1, BigInteger bi2);
		public static BigInteger operator <<(BigInteger bi1, int shiftVal);
		private static int shiftLeft(uint[] buffer, int shiftVal);
		private static int shiftRight(uint[] buffer, int shiftVal);
		public static BigInteger operator -(BigInteger bi1);
		public static bool operator ==(BigInteger bi1, BigInteger bi2);
		public override bool Equals(object o);
		public override int GetHashCode();
		public static bool operator >(BigInteger bi1, BigInteger bi2);
		public static bool operator <(BigInteger bi1, BigInteger bi2);
		public static bool operator >=(BigInteger bi1, BigInteger bi2);
		private static void multiByteDivide(BigInteger bi1, BigInteger bi2, BigInteger outQuotient, BigInteger outRemainder);
		private static void singleByteDivide(BigInteger bi1, BigInteger bi2, BigInteger outQuotient, BigInteger outRemainder);
		public static BigInteger operator /(BigInteger bi1, BigInteger bi2);
		public static BigInteger operator %(BigInteger bi1, BigInteger bi2);
		public override string ToString();
		public string ToString(int radix);
		public BigInteger ModPow(BigInteger exp, BigInteger n);
		private BigInteger BarrettReduction(BigInteger x, BigInteger n, BigInteger constant);
		public static BigInteger GenerateRandom(int bits);
		public void genRandomBits(int bits, Random rand);
		public int bitCount();
		public byte[] GetBytes();
	}
}
