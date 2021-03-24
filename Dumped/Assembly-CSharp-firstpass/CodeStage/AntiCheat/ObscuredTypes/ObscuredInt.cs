/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredInt : IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredInt>, IFormattable
	{
		// Fields
		private static int cryptoKey;
		[SerializeField]
		private int currentCryptoKey;
		[SerializeField]
		private int hiddenValue;
		[SerializeField]
		private bool inited;
		[SerializeField]
		private int fakeValue;
		[SerializeField]
		private bool fakeValueActive;
	
		// Constructors
		private ObscuredInt(int value);
		static ObscuredInt();
	
		// Methods
		public static void SetNewCryptoKey(int newKey);
		public static int Encrypt(int value);
		public static int Encrypt(int value, int key);
		public static int Decrypt(int value);
		public static int Decrypt(int value, int key);
		public void ApplyNewCryptoKey();
		public void RandomizeCryptoKey();
		public int GetEncrypted();
		public void SetEncrypted(int encrypted);
		public int GetDecrypted();
		private int InternalDecrypt();
		public static implicit operator ObscuredInt(int value);
		public static implicit operator int(ObscuredInt value);
		public static implicit operator ObscuredFloat(ObscuredInt value);
		public static implicit operator ObscuredDouble(ObscuredInt value);
		public static explicit operator ObscuredUInt(ObscuredInt value);
		public static ObscuredInt operator ++(ObscuredInt input);
		public static ObscuredInt operator --(ObscuredInt input);
		public override bool Equals(object obj);
		public bool Equals(ObscuredInt obj);
		public override int GetHashCode();
		public override string ToString();
		public string ToString(string format);
		public string ToString(IFormatProvider provider);
		public string ToString(string format, IFormatProvider provider);
	}
}
