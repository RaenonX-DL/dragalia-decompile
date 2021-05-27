/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using Gluon.Master;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GrowthManaCircleModel : MonoBehaviour
	{
		// Fields
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
		[CompilerGenerated]
		private bool _isTutorialRequired_k__BackingField;
		[CompilerGenerated]
		private int _storyIndex_k__BackingField;
		[CompilerGenerated]
		private bool _isLevelMax_k__BackingField;
		[CompilerGenerated]
		private bool _isPlusMax_k__BackingField;
		private GrowthManaCircleAbilityListInfo abilityListInfo;
		public const int limitReleaseMaterialTypeCount = 7;
		protected int numOfCircles;
		public const int firstManaCircleCompleteSymbolIndex = 5;
		public const int firstManaCircleMaxLimitBreakCount = 4;
		protected int currentMaxCircleIndex;
	
		// Properties
		public int haveGrowMaterialCount { get; }
		public bool isTutorialRequired { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int storyIndex { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isLevelMax { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isPlusMax { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		public enum UsedGrowMaterialType
		{
			onlyDefaultMaterial = 0,
			onlyGrowMaterial = 1,
			bothMaterial = 2
		}
	
		public enum GrowManaPicecPopupTextType
		{
			Default = 0,
			ExAbility = 1,
			LimitBreak = 2
		}
	
		public class LimitReleaseMaterialInfo
		{
			// Fields
			public MaterialDataElement[] mat;
			public int[] num;
	
			// Constructors
			public LimitReleaseMaterialInfo();
		}
	
		// Constructors
		public GrowthManaCircleModel();
		static GrowthManaCircleModel();
	
		// Methods
		public static int GetManaCircleNum(CharaRarityElement rarity);
		protected virtual void Awake();
		public void AdvanceStoryIndex();
		public void CompleteTutorial();
		public MaterialDataElement GetRequiredLimitReleaseMaterial(int circleIndex, int index);
		public MaterialDataElement GetRequiredLimitReleaseGrowMaterial(int circleIndex, int index);
		public int GetRequiredLimitReleaseMaterialNum(int circleIndex, int index);
		public int GetRequiredLimitReleaseGrowMaterialNum(int circleIndex, int index);
		public int GetHavingLimitReleaseMaterialNum(int circleIndex, int index);
		public int GetHavingLimitReleaseGrowMaterialNum(int circleIndex, int index);
		public bool HasRequiredLimitReleaseMaterials(int circleIndex);
		public bool HasRequiredLimitReleaseGrowMaterials(int circleIndex);
		public virtual void ReleaseManaPiece(int indexInCircle);
		public void ReleaseManaPiece(int circleIndex, int indexInCircle);
		public void UpdateCharaDataManaCircleIdList(int id);
		public void ReloadCharaData();
		public virtual int GetNumOfCircles();
		public int GetNumOfReleasedPoint(int circleIndex);
		public int GetCurrentMaxCircleIndex();
		public bool IsCircleReleased(int index);
		public bool IsCurrentTargetCircleMax();
		public int GetCurrentManaCircle2DIndex();
		public virtual bool IsAllPointReleased();
		public void AdvanceCurrentMaxCircle();
		public void AdvanceCurrentMaxCircleByLimitBreak(int limitBreak);
		public bool IsPointReleased(int circleIndex, int pointIndex);
		public void ReleaseAllForDevelop();
		public GrowthManaCircleAbilityListInfo CalcAbilityListInfo();
		public string GetWarningText(GrowManaPicecPopupTextType type = GrowManaPicecPopupTextType.Default);
		public bool isPieceGrowRelease(GrowthManaCircleManaPieceData pieceData);
		public bool IsUsableGrowMaterial();
		public bool IsHaveGrowMaterialMoreThanNessecaryGrowMaterial();
		public static AlbumPassiveDataElement GetAlbumPassiveData(AlbumPassiveType type, int albumPassiveValue);
		public static string GetManaCircleAlbumBonusText(ElementalType element, AlbumPassiveDataElement albumPassiveData);
	}
}
