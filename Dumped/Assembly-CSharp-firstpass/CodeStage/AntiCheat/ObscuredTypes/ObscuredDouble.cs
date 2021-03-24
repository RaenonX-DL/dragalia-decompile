/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.Common;
using UnityEngine;
using UnityEngine.Serialization;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredDouble : IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble>, IFormattable
	{
		// Fields
		private static long cryptoKey;
		[SerializeField]
		private long currentCryptoKey;
		[SerializeField]
		private ACTkByte8 hiddenValue;
		[FormerlySerializedAs]
		[SerializeField]
		private byte[] hiddenValueOld;
		[SerializeField]
		private bool inited;
		[SerializeField]
		private double fakeValue;
		[SerializeField]
		private bool fakeValueActive;
	
		// Nested types
		private struct DoubleLongBytesUnion
		{
			// Fields
			public double d;
			public long l;
			public ACTkByte8 b8;
		}
	
		// Constructors
		private ObscuredDouble(double value);
		static ObscuredDouble();
	
		// Methods
		public static void SetNewCryptoKey(long newKey);
		public static long Encrypt(double value);
		public static long Encrypt(double value, long key);
		private static ACTkByte8 InternalEncrypt(double value);
		private static ACTkByte8 InternalEncrypt(double value, long key);
		public static double Decrypt(long value);
		public static double Decrypt(long value, long key);
		public void ApplyNewCryptoKey();
		public void RandomizeCryptoKey();
		public long GetEncrypted();
		public void SetEncrypted(long encrypted);
		public double GetDecrypted();
		private double InternalDecrypt();
		public static implicit operator ObscuredDouble(double value);
		public static implicit operator double(ObscuredDouble value);
		public static ObscuredDouble operator ++(ObscuredDouble input);
		public static ObscuredDouble operator --(ObscuredDouble input);
		public override string ToString();
		public string ToString(string format);
		public string ToString(IFormatProvider provider);
		public string ToString(string format, IFormatProvider provider);
		public override bool Equals(object obj);
		public bool Equals(ObscuredDouble obj);
		public override int GetHashCode();
	}
}
