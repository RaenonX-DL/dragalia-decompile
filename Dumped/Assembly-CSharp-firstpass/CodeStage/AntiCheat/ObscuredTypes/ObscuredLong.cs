/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 54: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredLong : IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredLong>, IFormattable
	{
		// Fields
		private static long cryptoKey;
		[SerializeField]
		private long currentCryptoKey;
		[SerializeField]
		private long hiddenValue;
		[SerializeField]
		private bool inited;
		[SerializeField]
		private long fakeValue;
		[SerializeField]
		private bool fakeValueActive;
	
		// Constructors
		private ObscuredLong(long value);
		static ObscuredLong();
	
		// Methods
		public static void SetNewCryptoKey(long newKey);
		public static long Encrypt(long value);
		public static long Decrypt(long value);
		public static long Encrypt(long value, long key);
		public static long Decrypt(long value, long key);
		public void ApplyNewCryptoKey();
		public void RandomizeCryptoKey();
		public long GetEncrypted();
		public void SetEncrypted(long encrypted);
		public long GetDecrypted();
		private long InternalDecrypt();
		public static implicit operator ObscuredLong(long value);
		public static implicit operator long(ObscuredLong value);
		public static ObscuredLong operator ++(ObscuredLong input);
		public static ObscuredLong operator --(ObscuredLong input);
		public override bool Equals(object obj);
		public bool Equals(ObscuredLong obj);
		public override int GetHashCode();
		public override string ToString();
		public string ToString(string format);
		public string ToString(IFormatProvider provider);
		public string ToString(string format, IFormatProvider provider);
	}
}
