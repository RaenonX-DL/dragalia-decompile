using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon
{
	public class FortCharaArrangeController : MonoBehaviour
	{
		public enum PlaceType
		{
			Cooking = 0,
			CloseRangeTraining = 1,
			Watching1 = 2,
			Watching2 = 3,
			Watching3 = 4,
			LongRangeTraining = 5,
			Cave = 6,
			Square = 7,
			Walking1 = 8,
			Walking2 = 9,
			Walking3 = 10,
			Walking4 = 11,
			Walking5 = 12,
			Walking6 = 13,
			Walking7 = 14,
			Walking8 = 0xF,
			Walking9 = 0x10,
			Walking10 = 17,
			Walking11 = 18,
			Num = 19,
			WalkingLevelStart = 8,
			WalkingLevelEnd = 18,
			Invalid = -1
		}

		public enum Motion
		{
			None,
			Walk,
			Run,
			Stand,
			StandTalk,
			StandBye,
			Sit,
			SitTalk,
			SitDrink,
			Drink,
			AttackSWD1,
			AttackSWD2,
			AttackKAT1,
			AttackKAT2,
			AttackDAG1,
			AttackDAG2,
			AttackAXE1,
			AttackAXE2,
			AttackLAN1,
			AttackLAN2,
			AttackBOW,
			AttackROD,
			AttackCAN,
			AttackGUN,
			AttackStand,
			AttackStandKAT,
			Num
		}

		public struct CharaPlaceInfo
		{
			public PlaceType place;

			public int pointIndex;
		}

		public struct CharaArrangeInfo
		{
			public int charaId;

			public string charaModelPath;

			public string charaMotionPath;

			public Motion charaMotionId;

			public string attachItemPath;

			public CharaPlaceInfo placeInfo;
		}

		private const Motion ATTACK_START_MOTION = Motion.AttackSWD1;

		private const Motion ATTACK_END_MOTION = Motion.AttackGUN;

		private const int MAIN_FACILITY_MAX_LEVEL = 11;

		private static int[,] kMasterCharaArrangeTable;

		private static string kCupName;

		private static string[] kWeaponNameList;

		private static FortCharacterPlaceSetting charaPlaceSetting;

		[SerializeField]
		private FortCharaArrangePlace[] arrangePlaceList;

		[SerializeField]
		private GameObject closeRangeAttackTarget;

		[SerializeField]
		private GameObject longRangeAttackTarget;

		[SerializeField]
		private Vector3 longRangeAttackEffectOffset;

		[SerializeField]
		private float longRangeAttackNormalizedTime;

		public FortTalkBalloon fortTalkBalloon
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public GameObject GetCloseRangeTarget()
		{
			return null;
		}

		public GameObject GetLongRangeTarget()
		{
			return null;
		}

		public Vector3 GetLongRangeAttackEffectPos()
		{
			return default(Vector3);
		}

		public float GetLongRangeAttackNormalizedTime()
		{
			return default(float);
		}

		public int GetArrangePlaceNum()
		{
			return default(int);
		}

		public FortCharaArrangePlace GetArrangePlace(PlaceType type)
		{
			return null;
		}

		public GameObject GetArrangePoint(PlaceType type, int pointIndex)
		{
			return null;
		}

		public void RemoveArrangedCharaAll()
		{
		}

		public static void LoadSetting()
		{
		}

		public static void GetCharaArrangeInfo(int mainFacilityLevel, List<int> charaIdList, List<CharaArrangeInfo> charaArrangeInfoList)
		{
		}

		private static List<int> CreateExcludeSameCharaList(List<int> charaIdList)
		{
			return null;
		}

		private static bool IsForbiddenAppearCharaId(int charaId, int charaBaseId)
		{
			return default(bool);
		}

		private static void GetCharaArrangeInfoByWeaponRange(bool isCloseRange, CharaPlaceInfo placeInfo, List<int> notArrangedCharaIdList, List<int> tempCharaIdList, List<CharaArrangeInfo> charaArrangeInfoList)
		{
		}

		private static void GetCharaArrangeInfoByCooking(CharaPlaceInfo placeInfo, List<int> notArrangedCharaIdList, List<int> tempCharaIdList, List<CharaArrangeInfo> charaArrangeInfoList)
		{
		}

		private static CharaArrangeInfo CreateCharaArrangeInfo(int charaId, CharaPlaceInfo placeInfo)
		{
			return default(CharaArrangeInfo);
		}

		public static void GetEnableWalkingPlaceTypeList(int mainFacilityLevel, PlaceType curPlaceType, List<PlaceType> placeTypeList)
		{
		}

		public static void SetMotionId(Animator charaAnimator, Motion motionId)
		{
		}

		public static Motion[] GetMotionId(PlaceType placeType, WeaponType weaponType)
		{
			return null;
		}

		public static void GetAttachItemPathAll(List<string> attachItemList)
		{
		}

		public static string GetCupPath()
		{
			return null;
		}

		public static string GetWeaponPath(WeaponType type, int specialWeaponId = 0)
		{
			return null;
		}

		public static string GetWeaponName(WeaponType type, int specialWeaponId = 0)
		{
			return null;
		}

		private static bool IsSitMotion(Motion motionId)
		{
			return default(bool);
		}

		public static bool IsAttackMotion(Motion motionId)
		{
			return default(bool);
		}

		private static void GetArrangePlaceByFortLevel(int mainFacilityLevel, List<CharaPlaceInfo> placeList)
		{
		}

		private static bool IsWatchingPlace(PlaceType placeType)
		{
			return default(bool);
		}

		private static int GetWatchingPointIndex(int mainFacilityLevel)
		{
			return default(int);
		}

		private static bool IsCloseRangeWeaponType(WeaponType type)
		{
			return default(bool);
		}

		private static void GetCharaIdByWeaponRange(bool isCloseRange, List<int> inputCharaIdList, List<int> resultCharaIdList)
		{
		}

		private static void GetCharaIdByCooking(List<int> inputCharaIdList, List<int> resultCharaIdList)
		{
		}

		private static T GetRandomValueFromList<T>(List<T> list)
		{
			return (T)null;
		}

		private static T GetRandomValueFromArray<T>(T[] array)
		{
			return (T)null;
		}
	}
}
