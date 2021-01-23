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
	public struct ObscuredUInt : IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt>, IFormattable
	{
		// Fields
		private static uint cryptoKey;
		[SerializeField]
		private uint currentCryptoKey;
		[SerializeField]
		private uint hiddenValue;
		[SerializeField]
		private bool inited;
		[SerializeField]
		private uint fakeValue;
		[SerializeField]
		private bool fakeValueActive;
	
		// Constructors
		private ObscuredUInt(uint value);
		static ObscuredUInt();
	
		// Methods
		public static void SetNewCryptoKey(uint newKey);
		public static uint Encrypt(uint value);
		public static uint Decrypt(uint value);
		public static uint Encrypt(uint value, uint key);
		public static uint Decrypt(uint value, uint key);
		public void ApplyNewCryptoKey();
		public void RandomizeCryptoKey();
		public uint GetEncrypted();
		public void SetEncrypted(uint encrypted);
		public uint GetDecrypted();
		private uint InternalDecrypt();
		public static implicit operator ObscuredUInt(uint value);
		public static implicit operator uint(ObscuredUInt value);
		public static explicit operator ObscuredInt(ObscuredUInt value);
		public static ObscuredUInt operator ++(ObscuredUInt input);
		public static ObscuredUInt operator --(ObscuredUInt input);
		public override bool Equals(object obj);
		public bool Equals(ObscuredUInt obj);
		public override string ToString();
		public string ToString(string format);
		public override int GetHashCode();
		public string ToString(IFormatProvider provider);
		public string ToString(string format, IFormatProvider provider);
	}
}
