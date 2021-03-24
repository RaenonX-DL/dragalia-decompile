/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Bullet;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public static class BuffFieldManager
	{
		// Fields
		public const int buffDebuffFieldMaxCount = 4;
		private const int recoveryFieldMaxCount = 1;
		private static List<BuffFieldInfo> buffFields;
		private static List<HistoryData> deleteHistory;
	
		// Nested types
		public struct HistoryData
		{
			// Fields
			public int actionProductId;
			public int conditionId;
		}
	
		public enum FieldType
		{
			None = 0,
			Buff = 1,
			Debuff = 2,
			Recovery = 3
		}
	
		public class BuffFieldInfo
		{
			// Fields
			public SettingHitObject settingHitObj;
			public FieldType fieldType;
			public List<CharacterBase> rawCollidedCharaList;
	
			// Constructors
			public BuffFieldInfo(SettingHitObject settingHitObj, FieldType fieldType);
	
			// Methods
			public Vector3 GetCenterPoint();
		}
	
		public enum EnterOrExitCondition
		{
			Enter = 1,
			Exit = 2
		}
	
		// Constructors
		static BuffFieldManager();
	
		// Methods
		public static FieldType GetFieldType(int conditionId);
		public static FieldType Add(SettingHitObject obj);
		public static int GetFieldCount(FieldType fieldType, out SettingHitObject first);
		public static int FieldMaxCount(FieldType fieldType);
		private static CharacterBase GetApplyToChara(CharacterBase chara);
		public static void Remove(SettingHitObject obj);
		public static void RemoveRawCollidedInfo(SettingHitObject obj, CharacterBase chara);
		public static void RegisterRawCollidedInfo(SettingHitObject obj, List<CharacterBase> charaList);
		public static bool IsCharaOnBuffField(CharacterBase chara, FieldType fieldType);
		public static List<BuffFieldInfo> GetBuffFields(FieldType fieldType);
		public static List<CharacterBase> GetBuffFieldRawCollidedInfo(SettingHitObject obj);
		public static List<HistoryData> GetDeleteHistory();
		public static void ClearDeleteHistory();
	}
}
