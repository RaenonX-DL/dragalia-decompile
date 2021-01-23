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
	public struct ObscuredULong : IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredULong>, IFormattable
	{
		// Fields
		private static ulong cryptoKey;
		[SerializeField]
		private ulong currentCryptoKey;
		[SerializeField]
		private ulong hiddenValue;
		[SerializeField]
		private bool inited;
		[SerializeField]
		private ulong fakeValue;
		[SerializeField]
		private bool fakeValueActive;
	
		// Constructors
		private ObscuredULong(ulong value);
		static ObscuredULong();
	
		// Methods
		public static void SetNewCryptoKey(ulong newKey);
		public static ulong Encrypt(ulong value);
		public static ulong Decrypt(ulong value);
		public static ulong Encrypt(ulong value, ulong key);
		public static ulong Decrypt(ulong value, ulong key);
		public void ApplyNewCryptoKey();
		public void RandomizeCryptoKey();
		public ulong GetEncrypted();
		public void SetEncrypted(ulong encrypted);
		public ulong GetDecrypted();
		private ulong InternalDecrypt();
		public static implicit operator ObscuredULong(ulong value);
		public static implicit operator ulong(ObscuredULong value);
		public static ObscuredULong operator ++(ObscuredULong input);
		public static ObscuredULong operator --(ObscuredULong input);
		public override bool Equals(object obj);
		public bool Equals(ObscuredULong obj);
		public override int GetHashCode();
		public override string ToString();
		public string ToString(string format);
		public string ToString(IFormatProvider provider);
		public string ToString(string format, IFormatProvider provider);
	}
}
