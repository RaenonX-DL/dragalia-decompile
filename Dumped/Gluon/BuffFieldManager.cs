using System.Collections.Generic;
using Gluon.Bullet;
using UnityEngine;

namespace Gluon
{
	public static class BuffFieldManager
	{
		public struct HistoryData
		{
			public int actionProductId;

			public int conditionId;
		}

		public enum FieldType
		{
			None,
			Buff,
			Debuff,
			Recovery
		}

		public class BuffFieldInfo
		{
			public SettingHitObject settingHitObj;

			public FieldType fieldType;

			public ActionStartParameter actionStartParameter;

			public List<CharacterBase> rawCollidedCharaList;

			public BuffFieldInfo(SettingHitObject settingHitObj, FieldType fieldType, ActionStartParameter actionStartParameter)
			{
			}

			public Vector3 GetCenterPoint()
			{
				return default(Vector3);
			}
		}

		public enum EnterOrExitCondition
		{
			Enter = 1,
			Exit
		}

		public const int buffDebuffFieldMaxCount = 4;

		private const int recoveryFieldMaxCount = 1;

		private static List<BuffFieldInfo> buffFields;

		private static List<HistoryData> deleteHistory;

		public static FieldType GetFieldType(int conditionId)
		{
			return default(FieldType);
		}

		public static FieldType Add(SettingHitObject obj, ActionStartParameter actionStartParameter)
		{
			return default(FieldType);
		}

		public static int GetFieldCount(FieldType fieldType, out SettingHitObject first)
		{
			return default(int);
		}

		public static int FieldMaxCount(FieldType fieldType)
		{
			return default(int);
		}

		private static CharacterBase GetApplyToChara(CharacterBase chara)
		{
			return null;
		}

		public static void Remove(SettingHitObject obj)
		{
		}

		public static void RemoveRawCollidedInfo(SettingHitObject obj, CharacterBase chara)
		{
		}

		public static void RegisterRawCollidedInfo(SettingHitObject obj, List<CharacterBase> charaList)
		{
		}

		public static bool IsCharaOnBuffField(CharacterBase chara, FieldType fieldType)
		{
			return default(bool);
		}

		public static List<BuffFieldInfo> GetBuffFields(FieldType fieldType)
		{
			return null;
		}

		public static List<CharacterBase> GetBuffFieldRawCollidedInfo(SettingHitObject obj)
		{
			return null;
		}

		public static List<HistoryData> GetDeleteHistory()
		{
			return null;
		}

		public static void ClearDeleteHistory()
		{
		}
	}
}
