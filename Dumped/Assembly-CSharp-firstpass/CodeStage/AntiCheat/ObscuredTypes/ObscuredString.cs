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
	public sealed class ObscuredString
	{
		// Fields
		private static string cryptoKey;
		[SerializeField]
		private string currentCryptoKey;
		[SerializeField]
		private byte[] hiddenValue;
		[SerializeField]
		private bool inited;
		[SerializeField]
		private string fakeValue;
		[SerializeField]
		private bool fakeValueActive;
	
		// Properties
		public int Length { get; }
	
		// Constructors
		private ObscuredString();
		private ObscuredString(string value);
		static ObscuredString();
	
		// Methods
		public static void SetNewCryptoKey(string newKey);
		public static string EncryptDecrypt(string value);
		public static string EncryptDecrypt(string value, string key);
		public void ApplyNewCryptoKey();
		public void RandomizeCryptoKey();
		public string GetEncrypted();
		public void SetEncrypted(string encrypted);
		public string GetDecrypted();
		private static byte[] InternalEncrypt(string value);
		private static byte[] InternalEncrypt(string value, string key);
		private string InternalDecrypt();
		public static implicit operator ObscuredString(string value);
		public static implicit operator string(ObscuredString value);
		public override string ToString();
		public static bool operator ==(ObscuredString a, ObscuredString b);
		public static bool operator !=(ObscuredString a, ObscuredString b);
		public override bool Equals(object obj);
		public bool Equals(ObscuredString value);
		public bool Equals(ObscuredString value, StringComparison comparisonType);
		public override int GetHashCode();
		private static byte[] GetBytes(string str);
		private static string GetString(byte[] bytes);
		private static bool ArraysEquals(byte[] a1, byte[] a2);
	}
}
