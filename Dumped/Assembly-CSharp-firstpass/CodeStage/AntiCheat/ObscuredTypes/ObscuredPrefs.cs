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
	public static class ObscuredPrefs
	{
		// Fields
		private const byte VERSION = 2;
		private const string RAW_NOT_FOUND = "{not_found}";
		private const string DATA_SEPARATOR = "|";
		private static bool foreignSavesReported;
		private static string cryptoKey;
		private static string deviceId;
		private static uint deviceIdHash;
		public static Action onAlterationDetected;
		public static bool preservePlayerPrefs;
		public static Action onPossibleForeignSavesDetected;
		public static DeviceLockLevel lockToDevice;
		public static bool readForeignSaves;
		public static bool emergencyMode;
		private const char DEPRECATED_RAW_SEPARATOR = ':';
		private static string deprecatedDeviceId;
	
		// Properties
		public static string CryptoKey { get; set; }
		public static string DeviceId { get; set; }
		[Obsolete]
		internal static string DeviceID { get; set; }
		private static uint DeviceIdHash { get; }
		private static string DeprecatedDeviceId { get; }
	
		// Nested types
		internal enum DataType : byte
		{
			Unknown = 0,
			Int = 5,
			UInt = 10,
			String = 15,
			Float = 20,
			Double = 25,
			Decimal = 27,
			Long = 30,
			ULong = 32,
			Bool = 35,
			ByteArray = 40,
			Vector2 = 45,
			Vector3 = 50,
			Quaternion = 55,
			Color = 60,
			Rect = 65
		}
	
		public enum DeviceLockLevel : byte
		{
			None = 0,
			Soft = 1,
			Strict = 2
		}
	
		// Constructors
		static ObscuredPrefs();
	
		// Methods
		public static void ForceLockToDeviceInit();
		[Obsolete]
		internal static void SetNewCryptoKey(string newKey);
		public static void SetInt(string key, int value);
		public static int GetInt(string key);
		public static int GetInt(string key, int defaultValue);
		internal static string EncryptIntValue(string key, int value);
		internal static int DecryptIntValue(string key, string encryptedInput, int defaultValue);
		public static void SetUInt(string key, uint value);
		public static uint GetUInt(string key);
		public static uint GetUInt(string key, uint defaultValue);
		private static string EncryptUIntValue(string key, uint value);
		private static uint DecryptUIntValue(string key, string encryptedInput, uint defaultValue);
		public static void SetString(string key, string value);
		public static string GetString(string key);
		public static string GetString(string key, string defaultValue);
		internal static string EncryptStringValue(string key, string value);
		internal static string DecryptStringValue(string key, string encryptedInput, string defaultValue);
		public static void SetFloat(string key, float value);
		public static float GetFloat(string key);
		public static float GetFloat(string key, float defaultValue);
		internal static string EncryptFloatValue(string key, float value);
		internal static float DecryptFloatValue(string key, string encryptedInput, float defaultValue);
		public static void SetDouble(string key, double value);
		public static double GetDouble(string key);
		public static double GetDouble(string key, double defaultValue);
		private static string EncryptDoubleValue(string key, double value);
		private static double DecryptDoubleValue(string key, string encryptedInput, double defaultValue);
		public static void SetDecimal(string key, decimal value);
		public static decimal GetDecimal(string key);
		public static decimal GetDecimal(string key, decimal defaultValue);
		private static string EncryptDecimalValue(string key, decimal value);
		private static decimal DecryptDecimalValue(string key, string encryptedInput, decimal defaultValue);
		public static void SetLong(string key, long value);
		public static long GetLong(string key);
		public static long GetLong(string key, long defaultValue);
		private static string EncryptLongValue(string key, long value);
		private static long DecryptLongValue(string key, string encryptedInput, long defaultValue);
		public static void SetULong(string key, ulong value);
		public static ulong GetULong(string key);
		public static ulong GetULong(string key, ulong defaultValue);
		private static string EncryptULongValue(string key, ulong value);
		private static ulong DecryptULongValue(string key, string encryptedInput, ulong defaultValue);
		public static void SetBool(string key, bool value);
		public static bool GetBool(string key);
		public static bool GetBool(string key, bool defaultValue);
		private static string EncryptBoolValue(string key, bool value);
		private static bool DecryptBoolValue(string key, string encryptedInput, bool defaultValue);
		public static void SetByteArray(string key, byte[] value);
		public static byte[] GetByteArray(string key);
		public static byte[] GetByteArray(string key, byte defaultValue, int defaultLength);
		private static string EncryptByteArrayValue(string key, byte[] value);
		private static byte[] DecryptByteArrayValue(string key, string encryptedInput, byte defaultValue, int defaultLength);
		private static byte[] ConstructByteArray(byte value, int length);
		public static void SetVector2(string key, Vector2 value);
		public static Vector2 GetVector2(string key);
		public static Vector2 GetVector2(string key, Vector2 defaultValue);
		private static string EncryptVector2Value(string key, Vector2 value);
		private static Vector2 DecryptVector2Value(string key, string encryptedInput, Vector2 defaultValue);
		public static void SetVector3(string key, Vector3 value);
		public static Vector3 GetVector3(string key);
		public static Vector3 GetVector3(string key, Vector3 defaultValue);
		private static string EncryptVector3Value(string key, Vector3 value);
		private static Vector3 DecryptVector3Value(string key, string encryptedInput, Vector3 defaultValue);
		public static void SetQuaternion(string key, Quaternion value);
		public static Quaternion GetQuaternion(string key);
		public static Quaternion GetQuaternion(string key, Quaternion defaultValue);
		private static string EncryptQuaternionValue(string key, Quaternion value);
		private static Quaternion DecryptQuaternionValue(string key, string encryptedInput, Quaternion defaultValue);
		public static void SetColor(string key, Color32 value);
		public static Color32 GetColor(string key);
		public static Color32 GetColor(string key, Color32 defaultValue);
		private static string EncryptColorValue(string key, uint value);
		public static void SetRect(string key, Rect value);
		public static Rect GetRect(string key);
		public static Rect GetRect(string key, Rect defaultValue);
		private static string EncryptRectValue(string key, Rect value);
		private static Rect DecryptRectValue(string key, string encryptedInput, Rect defaultValue);
		public static void SetRawValue(string key, string encryptedValue);
		public static string GetRawValue(string key);
		internal static DataType GetRawValueType(string value);
		internal static string EncryptKey(string key);
		public static bool HasKey(string key);
		public static void DeleteKey(string key);
		public static void DeleteAll();
		public static void Save();
		private static string GetEncryptedPrefsString(string key, string encryptedKey);
		private static string EncryptData(string key, byte[] cleanBytes, DataType type);
		internal static byte[] DecryptData(string key, string encryptedInput);
		private static uint CalculateChecksum(string input);
		private static void SavesTampered();
		private static void PossibleForeignSavesDetected();
		private static string GetDeviceId();
		private static byte[] EncryptDecryptBytes(byte[] bytes, int dataLength, string key);
		private static string DeprecatedDecryptValue(string value);
		private static string DeprecatedCalculateChecksum(string input);
	}
}
