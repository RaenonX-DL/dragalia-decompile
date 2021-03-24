/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredVector2
	{
		// Fields
		private static int cryptoKey;
		private static readonly Vector2 zero;
		[SerializeField]
		private int currentCryptoKey;
		[SerializeField]
		private RawEncryptedVector2 hiddenValue;
		[SerializeField]
		private bool inited;
		[SerializeField]
		private Vector2 fakeValue;
		[SerializeField]
		private bool fakeValueActive;
	
		// Properties
		public float x { get; set; }
		public float y { get; set; }
		public float this[int index] { get => default; set {} }
	
		// Nested types
		[Serializable]
		public struct RawEncryptedVector2
		{
			// Fields
			public int x;
			public int y;
		}
	
		// Constructors
		private ObscuredVector2(Vector2 value);
		public ObscuredVector2(float x, float y);
		static ObscuredVector2();
	
		// Methods
		public static void SetNewCryptoKey(int newKey);
		public static RawEncryptedVector2 Encrypt(Vector2 value);
		public static RawEncryptedVector2 Encrypt(Vector2 value, int key);
		public static RawEncryptedVector2 Encrypt(float x, float y, int key);
		public static Vector2 Decrypt(RawEncryptedVector2 value);
		public static Vector2 Decrypt(RawEncryptedVector2 value, int key);
		public void ApplyNewCryptoKey();
		public void RandomizeCryptoKey();
		public RawEncryptedVector2 GetEncrypted();
		public void SetEncrypted(RawEncryptedVector2 encrypted);
		public Vector2 GetDecrypted();
		private Vector2 InternalDecrypt();
		private bool CompareVectorsWithTolerance(Vector2 vector1, Vector2 vector2);
		private float InternalDecryptField(int encrypted);
		private int InternalEncryptField(float encrypted);
		public static implicit operator ObscuredVector2(Vector2 value);
		public static implicit operator Vector2(ObscuredVector2 value);
		public static implicit operator Vector3(ObscuredVector2 value);
		public override int GetHashCode();
		public override string ToString();
		public string ToString(string format);
	}
}
