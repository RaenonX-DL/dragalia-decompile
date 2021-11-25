using System;
using System.Runtime.CompilerServices;
using Gluon.Http;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class GrowthManaCircleModel : MonoBehaviour
	{
		public enum UsedGrowMaterialType
		{
			onlyDefaultMaterial,
			onlyGrowMaterial,
			bothMaterial
		}

		public enum GrowManaPicecPopupTextType
		{
			Default,
			ExAbility,
			LimitBreak
		}

		public enum PlatinumCrystalUsableStatus
		{
			Ready,
			ErrStatusMax,
			ErrGrowMaterial,
			ErrTemporaryCharacter
		}

		public class LimitReleaseMaterialInfo
		{
			public MaterialDataElement[] mat;

			public int[] num;
		}

		public static int tutorialTargetPieceIndex;

		public bool isLoaded;

		public static ulong charaKeyId;

		public static ElementalType elemenalType;

		public CharaDataElement masterCharaData;

		public CharaList charaData;

		public UnitDetailModel.CharaDetailData charaDetailData;

		public Rarity rarity;

		public CharaLimitBreakElement masterCharaLimitBreak;

		public GrowthManaCircleManaCircleData circleData;

		public bool hasCharaStory;

		public UsedGrowMaterialType usedGrowMaterilType;

		public bool isNowGrowRelease;

		public LimitReleaseMaterialInfo[] limitReleaseMaterialInfo;

		public LimitReleaseMaterialInfo[] limitReleaseGrowMaterialInfo;

		private GrowthManaCircleAbilityListInfo abilityListInfo;

		public const int limitReleaseMaterialTypeCount = 7;

		protected int numOfCircles;

		public const int firstManaCircleCompleteSymbolIndex = 5;

		public const int firstManaCircleMaxLimitBreakCount = 4;

		protected int currentMaxCircleIndex;

		public int haveGrowMaterialCount => default(int);

		public bool isTutorialRequired
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int storyIndex
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isLevelMax
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isPlusMax
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public static int GetManaCircleNum(CharaRarityElement rarity)
		{
			return default(int);
		}

		protected virtual void Awake()
		{
		}

		public void AdvanceStoryIndex()
		{
		}

		public void CompleteTutorial()
		{
		}

		public MaterialDataElement GetRequiredLimitReleaseMaterial(int circleIndex, int index)
		{
			return null;
		}

		public MaterialDataElement GetRequiredLimitReleaseGrowMaterial(int circleIndex, int index)
		{
			return null;
		}

		public int GetRequiredLimitReleaseMaterialNum(int circleIndex, int index)
		{
			return default(int);
		}

		public int GetRequiredLimitReleaseGrowMaterialNum(int circleIndex, int index)
		{
			return default(int);
		}

		public int GetHavingLimitReleaseMaterialNum(int circleIndex, int index)
		{
			return default(int);
		}

		public int GetHavingLimitReleaseGrowMaterialNum(int circleIndex, int index)
		{
			return default(int);
		}

		public bool HasRequiredLimitReleaseMaterials(int circleIndex)
		{
			return default(bool);
		}

		public bool HasRequiredLimitReleaseGrowMaterials(int circleIndex)
		{
			return default(bool);
		}

		public virtual void ReleaseManaPiece(int indexInCircle)
		{
		}

		public void ReleaseManaPiece(int circleIndex, int indexInCircle)
		{
		}

		public void UpdateCharaDataManaCircleIdList(int id)
		{
		}

		public void ReloadCharaData()
		{
		}

		public virtual int GetNumOfCircles()
		{
			return default(int);
		}

		public int GetNumOfReleasedPoint(int circleIndex)
		{
			return default(int);
		}

		public int GetCurrentMaxCircleIndex()
		{
			return default(int);
		}

		public bool IsCircleReleased(int index)
		{
			return default(bool);
		}

		public bool IsCurrentTargetCircleMax()
		{
			return default(bool);
		}

		public int GetCurrentManaCircle2DIndex()
		{
			return default(int);
		}

		public virtual bool IsAllPointReleased()
		{
			return default(bool);
		}

		public void AdvanceCurrentMaxCircle()
		{
		}

		public void AdvanceCurrentMaxCircleByLimitBreak(int limitBreak)
		{
		}

		public bool IsPointReleased(int circleIndex, int pointIndex)
		{
			return default(bool);
		}

		public void ReleaseAllForDevelop()
		{
		}

		public GrowthManaCircleAbilityListInfo CalcAbilityListInfo()
		{
			return null;
		}

		public string GetWarningText(GrowManaPicecPopupTextType type = GrowManaPicecPopupTextType.Default)
		{
			return null;
		}

		public bool isPieceGrowRelease(GrowthManaCircleManaPieceData pieceData)
		{
			return default(bool);
		}

		public bool IsUsableGrowMaterial()
		{
			return default(bool);
		}

		public bool IsHaveGrowMaterialMoreThanNessecaryGrowMaterial()
		{
			return default(bool);
		}

		public static AlbumPassiveDataElement GetAlbumPassiveData(AlbumPassiveType type, int albumPassiveValue)
		{
			return null;
		}

		public static string GetManaCircleAlbumBonusText(ElementalType element, AlbumPassiveDataElement albumPassiveData)
		{
			return null;
		}

		public static UsedGrowMaterialType GetUsedGrowMaterialType(CharaDataElement masterCharaData)
		{
			return default(UsedGrowMaterialType);
		}

		public static bool IsUseGrowMaterial(UsedGrowMaterialType usedGrowMaterilType, int haveGrowMaterialCount)
		{
			return default(bool);
		}

		public static int GetPlatinumCrystalNum()
		{
			return default(int);
		}

		public static PlatinumCrystalUsableStatus CanUsePlatinumCrystal(ulong growBaseKeyId, GrowthManaCircleManaCircleData circleData)
		{
			return default(PlatinumCrystalUsableStatus);
		}

		public static void UpdatePlatinumCrystalState(CharaDataElement masterCharaData, int level, GrowthManaCircleManaCircleData circleData, GameObject platinumCrystalRoot, Text platinumCrystalCountText)
		{
		}

		public static void ShowPlatinumCrystalUsePopup(ulong growBaseKeyId, GrowthManaCircleManaCircleData circleData, Action onOK)
		{
		}

		public static void ShowUsePlatinumCrystalConfirmPopup(UnitDetailModel.CharaDetailData charaDetailData, GrowthManaCircleManaCircleData circleData, Action onOK)
		{
		}

		public static void SendUsePlatinumCrystal(int charaId, Action callback)
		{
		}
	}
}
