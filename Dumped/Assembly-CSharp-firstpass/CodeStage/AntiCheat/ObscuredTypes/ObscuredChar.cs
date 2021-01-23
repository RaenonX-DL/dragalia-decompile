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
	public struct ObscuredChar : IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredChar>
	{
		// Fields
		private static char cryptoKey;
		private char currentCryptoKey;
		private char hiddenValue;
		private bool inited;
		private char fakeValue;
		private bool fakeValueActive;
	
		// Constructors
		private ObscuredChar(char value);
		static ObscuredChar();
	
		// Methods
		public static void SetNewCryptoKey(char newKey);
		public static char EncryptDecrypt(char value);
		public static char EncryptDecrypt(char value, char key);
		public void ApplyNewCryptoKey();
		public void RandomizeCryptoKey();
		public char GetEncrypted();
		public void SetEncrypted(char encrypted);
		public char GetDecrypted();
		private char InternalDecrypt();
		public static implicit operator ObscuredChar(char value);
		public static implicit operator char(ObscuredChar value);
		public static ObscuredChar operator ++(ObscuredChar input);
		public static ObscuredChar operator --(ObscuredChar input);
		public override bool Equals(object obj);
		public bool Equals(ObscuredChar obj);
		public override string ToString();
		public string ToString(IFormatProvider provider);
		public override int GetHashCode();
	}
}
