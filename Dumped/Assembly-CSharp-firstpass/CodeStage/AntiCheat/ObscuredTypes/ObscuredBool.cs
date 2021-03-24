/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredBool : IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredBool>
	{
		// Fields
		private static byte cryptoKey;
		[SerializeField]
		private byte currentCryptoKey;
		[SerializeField]
		private int hiddenValue;
		[SerializeField]
		private bool inited;
		[SerializeField]
		private bool fakeValue;
		[FormerlySerializedAs]
		[SerializeField]
		private bool fakeValueActive;
	
		// Constructors
		private ObscuredBool(bool value);
		static ObscuredBool();
	
		// Methods
		public static void SetNewCryptoKey(byte newKey);
		public static int Encrypt(bool value);
		public static int Encrypt(bool value, byte key);
		public static bool Decrypt(int value);
		public static bool Decrypt(int value, byte key);
		public void ApplyNewCryptoKey();
		public void RandomizeCryptoKey();
		public int GetEncrypted();
		public void SetEncrypted(int encrypted);
		public bool GetDecrypted();
		private bool InternalDecrypt();
		public static implicit operator ObscuredBool(bool value);
		public static implicit operator bool(ObscuredBool value);
		public override bool Equals(object obj);
		public bool Equals(ObscuredBool obj);
		public override int GetHashCode();
		public override string ToString();
	}
}
