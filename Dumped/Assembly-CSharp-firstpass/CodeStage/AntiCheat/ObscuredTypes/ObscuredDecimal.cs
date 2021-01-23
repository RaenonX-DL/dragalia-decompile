/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.Common;

// Image 54: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredDecimal : IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal>, IFormattable
	{
		// Fields
		private static long cryptoKey;
		private long currentCryptoKey;
		private ACTkByte16 hiddenValue;
		private bool inited;
		private decimal fakeValue;
		private bool fakeValueActive;
	
		// Nested types
		private struct DecimalLongBytesUnion
		{
			// Fields
			public decimal d;
			public long l1;
			public long l2;
			public ACTkByte16 b16;
		}
	
		// Constructors
		private ObscuredDecimal(decimal value);
		static ObscuredDecimal();
	
		// Methods
		public static void SetNewCryptoKey(long newKey);
		public static decimal Encrypt(decimal value);
		public static decimal Encrypt(decimal value, long key);
		private static ACTkByte16 InternalEncrypt(decimal value);
		private static ACTkByte16 InternalEncrypt(decimal value, long key);
		public static decimal Decrypt(decimal value);
		public static decimal Decrypt(decimal value, long key);
		public void ApplyNewCryptoKey();
		public void RandomizeCryptoKey();
		public decimal GetEncrypted();
		public void SetEncrypted(decimal encrypted);
		public decimal GetDecrypted();
		private decimal InternalDecrypt();
		public static implicit operator ObscuredDecimal(decimal value);
		public static implicit operator decimal(ObscuredDecimal value);
		public static explicit operator ObscuredDecimal(ObscuredFloat f);
		public static ObscuredDecimal operator ++(ObscuredDecimal input);
		public static ObscuredDecimal operator --(ObscuredDecimal input);
		public override string ToString();
		public string ToString(string format);
		public string ToString(IFormatProvider provider);
		public string ToString(string format, IFormatProvider provider);
		public override bool Equals(object obj);
		public bool Equals(ObscuredDecimal obj);
		public override int GetHashCode();
	}
}
