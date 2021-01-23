/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 54: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredVector3
	{
		// Fields
		private static int cryptoKey;
		private static readonly Vector3 zero;
		[SerializeField]
		private int currentCryptoKey;
		[SerializeField]
		private RawEncryptedVector3 hiddenValue;
		[SerializeField]
		private bool inited;
		[SerializeField]
		private Vector3 fakeValue;
		[SerializeField]
		private bool fakeValueActive;
	
		// Properties
		public float x { get; set; }
		public float y { get; set; }
		public float z { get; set; }
		public float this[int index] { get => default; set {} }
	
		// Nested types
		[Serializable]
		public struct RawEncryptedVector3
		{
			// Fields
			public int x;
			public int y;
			public int z;
		}
	
		// Constructors
		private ObscuredVector3(Vector3 value);
		public ObscuredVector3(float x, float y, float z);
		static ObscuredVector3();
	
		// Methods
		public static void SetNewCryptoKey(int newKey);
		public static RawEncryptedVector3 Encrypt(Vector3 value);
		public static RawEncryptedVector3 Encrypt(Vector3 value, int key);
		public static RawEncryptedVector3 Encrypt(float x, float y, float z, int key);
		public static Vector3 Decrypt(RawEncryptedVector3 value);
		public static Vector3 Decrypt(RawEncryptedVector3 value, int key);
		public void ApplyNewCryptoKey();
		public void RandomizeCryptoKey();
		public RawEncryptedVector3 GetEncrypted();
		public void SetEncrypted(RawEncryptedVector3 encrypted);
		public Vector3 GetDecrypted();
		private Vector3 InternalDecrypt();
		private bool CompareVectorsWithTolerance(Vector3 vector1, Vector3 vector2);
		private float InternalDecryptField(int encrypted);
		private int InternalEncryptField(float encrypted);
		public static implicit operator ObscuredVector3(Vector3 value);
		public static implicit operator Vector3(ObscuredVector3 value);
		public static ObscuredVector3 operator +(ObscuredVector3 a, ObscuredVector3 b);
		public static ObscuredVector3 operator +(Vector3 a, ObscuredVector3 b);
		public static ObscuredVector3 operator +(ObscuredVector3 a, Vector3 b);
		public static ObscuredVector3 operator -(ObscuredVector3 a, ObscuredVector3 b);
		public static ObscuredVector3 operator -(Vector3 a, ObscuredVector3 b);
		public static ObscuredVector3 operator -(ObscuredVector3 a, Vector3 b);
		public static ObscuredVector3 operator -(ObscuredVector3 a);
		public static ObscuredVector3 operator *(ObscuredVector3 a, float d);
		public static ObscuredVector3 operator *(float d, ObscuredVector3 a);
		public static ObscuredVector3 operator /(ObscuredVector3 a, float d);
		public static bool operator ==(ObscuredVector3 lhs, ObscuredVector3 rhs);
		public static bool operator ==(Vector3 lhs, ObscuredVector3 rhs);
		public static bool operator ==(ObscuredVector3 lhs, Vector3 rhs);
		public static bool operator !=(ObscuredVector3 lhs, ObscuredVector3 rhs);
		public static bool operator !=(Vector3 lhs, ObscuredVector3 rhs);
		public static bool operator !=(ObscuredVector3 lhs, Vector3 rhs);
		public override bool Equals(object other);
		public override int GetHashCode();
		public override string ToString();
		public string ToString(string format);
	}
}
