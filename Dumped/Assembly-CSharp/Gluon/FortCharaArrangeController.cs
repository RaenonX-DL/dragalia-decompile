/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class FortCharaArrangeController : MonoBehaviour
	{
		// Fields
		private const Motion ATTACK_START_MOTION = Motion.AttackSWD1;
		private const Motion ATTACK_END_MOTION = Motion.AttackGUN;
		private const int MAIN_FACILITY_MAX_LEVEL = 11;
		private static int[,] kMasterCharaArrangeTable;
		private static string kCupName;
		private static string[] kWeaponNameList;
		private const int mumuBaseId = 100010;
		private const int brunhildUnitId1 = 20040101;
		private const int brunhildUnitId2 = 20050102;
		public static Dictionary<int, string> sWeaponNameList;
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
		[CompilerGenerated]
		private FortTalkBalloon _fortTalkBalloon_k__BackingField;
	
		// Properties
		public FortTalkBalloon fortTalkBalloon { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		public enum PlaceType
		{
			Invalid = -1,
			Cooking = 0,
			CloseRangeTraining = 1,
			Watching1 = 2,
			Watching2 = 3,
			Watching3 = 4,
			LongRangeTraining = 5,
			Cave = 6,
			Square = 7,
			Walking1 = 8,
			WalkingLevelStart = 8,
			Walking2 = 9,
			Walking3 = 10,
			Walking4 = 11,
			Walking5 = 12,
			Walking6 = 13,
			Walking7 = 14,
			Walking8 = 15,
			Walking9 = 16,
			Walking10 = 17,
			Walking11 = 18,
			WalkingLevelEnd = 18,
			Num = 19
		}
	
		public enum Motion
		{
			None = 0,
			Walk = 1,
			Run = 2,
			Stand = 3,
			StandTalk = 4,
			StandBye = 5,
			Sit = 6,
			SitTalk = 7,
			SitDrink = 8,
			Drink = 9,
			AttackSWD1 = 10,
			AttackSWD2 = 11,
			AttackKAT1 = 12,
			AttackKAT2 = 13,
			AttackDAG1 = 14,
			AttackDAG2 = 15,
			AttackAXE1 = 16,
			AttackAXE2 = 17,
			AttackLAN1 = 18,
			AttackLAN2 = 19,
			AttackBOW = 20,
			AttackROD = 21,
			AttackCAN = 22,
			AttackGUN = 23,
			AttackStand = 24,
			AttackStandKAT = 25,
			Num = 26
		}
	
		public struct CharaPlaceInfo
		{
			// Fields
			public PlaceType place;
			public int pointIndex;
		}
	
		public struct CharaArrangeInfo
		{
			// Fields
			public int charaId;
			public string charaModelPath;
			public string charaMotionPath;
			public Motion charaMotionId;
			public string attachItemPath;
			public CharaPlaceInfo placeInfo;
		}
	
		// Constructors
		public FortCharaArrangeController();
		static FortCharaArrangeController();
	
		// Methods
		public GameObject GetCloseRangeTarget();
		public GameObject GetLongRangeTarget();
		public Vector3 GetLongRangeAttackEffectPos();
		public float GetLongRangeAttackNormalizedTime();
		public int GetArrangePlaceNum();
		public FortCharaArrangePlace GetArrangePlace(PlaceType type);
		public GameObject GetArrangePoint(PlaceType type, int pointIndex);
		public void RemoveArrangedCharaAll();
		public static void GetCharaArrangeInfo(int mainFacilityLevel, List<int> charaIdList, List<CharaArrangeInfo> charaArrangeInfoList);
		private static List<int> CreateExcludeSameCharaList(List<int> charaIdList);
		private static bool IsForbiddenAppearCharaId(int id);
		private static void GetCharaArrangeInfoByWeaponRange(bool isCloseRange, CharaPlaceInfo placeInfo, List<int> notArrangedCharaIdList, List<int> tempCharaIdList, List<CharaArrangeInfo> charaArrangeInfoList);
		private static void GetCharaArrangeInfoByCooking(CharaPlaceInfo placeInfo, List<int> notArrangedCharaIdList, List<int> tempCharaIdList, List<CharaArrangeInfo> charaArrangeInfoList);
		private static CharaArrangeInfo CreateCharaArrangeInfo(int charaId, CharaPlaceInfo placeInfo);
		public static void GetEnableWalkingPlaceTypeList(int mainFacilityLevel, PlaceType curPlaceType, List<PlaceType> placeTypeList);
		public static void SetMotionId(Animator charaAnimator, Motion motionId);
		public static Motion[] GetMotionId(PlaceType placeType, WeaponType weaponType);
		public static void GetAttachItemPathAll(List<string> attachItemList);
		public static string GetCupPath();
		public static string GetWeaponPath(WeaponType type, int specialWeaponId = 0);
		public static string GetWeaponName(WeaponType type, int specialWeaponId = 0);
		private static bool IsSitMotion(Motion motionId);
		public static bool IsAttackMotion(Motion motionId);
		private static void GetArrangePlaceByFortLevel(int mainFacilityLevel, List<CharaPlaceInfo> placeList);
		private static bool IsWatchingPlace(PlaceType placeType);
		private static int GetWatchingPointIndex(int mainFacilityLevel);
		private static bool IsCloseRangeWeaponType(WeaponType type);
		private static void GetCharaIdByWeaponRange(bool isCloseRange, List<int> inputCharaIdList, List<int> resultCharaIdList);
		private static void GetCharaIdByCooking(List<int> inputCharaIdList, List<int> resultCharaIdList);
		private static T GetRandomValueFromList<T>(List<T> list);
		private static T GetRandomValueFromArray<T>(T[] array);
	}
}
