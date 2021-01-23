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
	public struct ObscuredShort : IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredShort>, IFormattable
	{
		// Fields
		private static short cryptoKey;
		[SerializeField]
		private short currentCryptoKey;
		[SerializeField]
		private short hiddenValue;
		[SerializeField]
		private bool inited;
		[SerializeField]
		private short fakeValue;
		[SerializeField]
		private bool fakeValueActive;
	
		// Constructors
		private ObscuredShort(short value);
		static ObscuredShort();
	
		// Methods
		public static void SetNewCryptoKey(short newKey);
		public static short EncryptDecrypt(short value);
		public static short EncryptDecrypt(short value, short key);
		public void ApplyNewCryptoKey();
		public void RandomizeCryptoKey();
		public short GetEncrypted();
		public void SetEncrypted(short encrypted);
		public short GetDecrypted();
		private short InternalDecrypt();
		public static implicit operator ObscuredShort(short value);
		public static implicit operator short(ObscuredShort value);
		public static ObscuredShort operator ++(ObscuredShort input);
		public static ObscuredShort operator --(ObscuredShort input);
		public override bool Equals(object obj);
		public bool Equals(ObscuredShort obj);
		public override string ToString();
		public string ToString(string format);
		public override int GetHashCode();
		public string ToString(IFormatProvider provider);
		public string ToString(string format, IFormatProvider provider);
	}
}
