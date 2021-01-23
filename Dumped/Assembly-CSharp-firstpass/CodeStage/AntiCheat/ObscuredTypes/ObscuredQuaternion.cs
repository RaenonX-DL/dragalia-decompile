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
	public struct ObscuredQuaternion
	{
		// Fields
		private static int cryptoKey;
		private static readonly Quaternion identity;
		[SerializeField]
		private int currentCryptoKey;
		[SerializeField]
		private RawEncryptedQuaternion hiddenValue;
		[SerializeField]
		private bool inited;
		[SerializeField]
		private Quaternion fakeValue;
		[SerializeField]
		private bool fakeValueActive;
	
		// Nested types
		[Serializable]
		public struct RawEncryptedQuaternion
		{
			// Fields
			public int x;
			public int y;
			public int z;
			public int w;
		}
	
		// Constructors
		private ObscuredQuaternion(Quaternion value);
		public ObscuredQuaternion(float x, float y, float z, float w);
		static ObscuredQuaternion();
	
		// Methods
		public static void SetNewCryptoKey(int newKey);
		public static RawEncryptedQuaternion Encrypt(Quaternion value);
		public static RawEncryptedQuaternion Encrypt(Quaternion value, int key);
		public static RawEncryptedQuaternion Encrypt(float x, float y, float z, float w, int key);
		public static Quaternion Decrypt(RawEncryptedQuaternion value);
		public static Quaternion Decrypt(RawEncryptedQuaternion value, int key);
		public void ApplyNewCryptoKey();
		public void RandomizeCryptoKey();
		public RawEncryptedQuaternion GetEncrypted();
		public void SetEncrypted(RawEncryptedQuaternion encrypted);
		public Quaternion GetDecrypted();
		private Quaternion InternalDecrypt();
		private bool CompareQuaternionsWithTolerance(Quaternion q1, Quaternion q2);
		public static implicit operator ObscuredQuaternion(Quaternion value);
		public static implicit operator Quaternion(ObscuredQuaternion value);
		public override int GetHashCode();
		public override string ToString();
		public string ToString(string format);
	}
}
