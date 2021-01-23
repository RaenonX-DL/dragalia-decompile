/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 54: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredUShort : IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredUShort>, IFormattable
	{
		// Fields
		private static ushort cryptoKey;
		private ushort currentCryptoKey;
		private ushort hiddenValue;
		private bool inited;
		private ushort fakeValue;
		private bool fakeValueActive;
	
		// Constructors
		private ObscuredUShort(ushort value);
		static ObscuredUShort();
	
		// Methods
		public static void SetNewCryptoKey(ushort newKey);
		public static ushort EncryptDecrypt(ushort value);
		public static ushort EncryptDecrypt(ushort value, ushort key);
		public void ApplyNewCryptoKey();
		public void RandomizeCryptoKey();
		public ushort GetEncrypted();
		public void SetEncrypted(ushort encrypted);
		public ushort GetDecrypted();
		private ushort InternalDecrypt();
		public static implicit operator ObscuredUShort(ushort value);
		public static implicit operator ushort(ObscuredUShort value);
		public static ObscuredUShort operator ++(ObscuredUShort input);
		public static ObscuredUShort operator --(ObscuredUShort input);
		public override bool Equals(object obj);
		public bool Equals(ObscuredUShort obj);
		public override string ToString();
		public string ToString(string format);
		public override int GetHashCode();
		public string ToString(IFormatProvider provider);
		public string ToString(string format, IFormatProvider provider);
	}
}
