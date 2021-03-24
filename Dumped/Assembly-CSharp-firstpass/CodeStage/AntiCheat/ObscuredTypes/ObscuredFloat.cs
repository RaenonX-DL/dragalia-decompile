/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.Common;
using UnityEngine;
using UnityEngine.Serialization;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredFloat : IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat>, IFormattable
	{
		// Fields
		private static int cryptoKey;
		[SerializeField]
		private int currentCryptoKey;
		[SerializeField]
		private ACTkByte4 hiddenValue;
		[FormerlySerializedAs]
		[SerializeField]
		private byte[] hiddenValueOld;
		[SerializeField]
		private bool inited;
		[SerializeField]
		private float fakeValue;
		[SerializeField]
		private bool fakeValueActive;
	
		// Nested types
		private struct FloatIntBytesUnion
		{
			// Fields
			public float f;
			public int i;
			public ACTkByte4 b4;
		}
	
		// Constructors
		private ObscuredFloat(float value);
		static ObscuredFloat();
	
		// Methods
		public static void SetNewCryptoKey(int newKey);
		public static int Encrypt(float value);
		public static int Encrypt(float value, int key);
		private static ACTkByte4 InternalEncrypt(float value);
		private static ACTkByte4 InternalEncrypt(float value, int key);
		public static float Decrypt(int value);
		public static float Decrypt(int value, int key);
		public void ApplyNewCryptoKey();
		public void RandomizeCryptoKey();
		public int GetEncrypted();
		public void SetEncrypted(int encrypted);
		public float GetDecrypted();
		private float InternalDecrypt();
		public static implicit operator ObscuredFloat(float value);
		public static implicit operator float(ObscuredFloat value);
		public static ObscuredFloat operator ++(ObscuredFloat input);
		public static ObscuredFloat operator --(ObscuredFloat input);
		public override bool Equals(object obj);
		public bool Equals(ObscuredFloat obj);
		public override int GetHashCode();
		public override string ToString();
		public string ToString(string format);
		public string ToString(IFormatProvider provider);
		public string ToString(string format, IFormatProvider provider);
	}
}
