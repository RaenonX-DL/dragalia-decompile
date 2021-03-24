/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredSByte : IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredSByte>, IFormattable
	{
		// Fields
		private static sbyte cryptoKey;
		private sbyte currentCryptoKey;
		private sbyte hiddenValue;
		private bool inited;
		private sbyte fakeValue;
		private bool fakeValueActive;
	
		// Constructors
		private ObscuredSByte(sbyte value);
		static ObscuredSByte();
	
		// Methods
		public static void SetNewCryptoKey(sbyte newKey);
		public static sbyte EncryptDecrypt(sbyte value);
		public static sbyte EncryptDecrypt(sbyte value, sbyte key);
		public void ApplyNewCryptoKey();
		public void RandomizeCryptoKey();
		public sbyte GetEncrypted();
		public void SetEncrypted(sbyte encrypted);
		public sbyte GetDecrypted();
		private sbyte InternalDecrypt();
		public static implicit operator ObscuredSByte(sbyte value);
		public static implicit operator sbyte(ObscuredSByte value);
		public static ObscuredSByte operator ++(ObscuredSByte input);
		public static ObscuredSByte operator --(ObscuredSByte input);
		public override bool Equals(object obj);
		public bool Equals(ObscuredSByte obj);
		public override string ToString();
		public string ToString(string format);
		public override int GetHashCode();
		public string ToString(IFormatProvider provider);
		public string ToString(string format, IFormatProvider provider);
	}
}
