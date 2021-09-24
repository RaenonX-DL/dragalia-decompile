/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

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
	
		public enum PlatinumCrystalUsableStatus
		{
			Ready = 0,
			ErrStatusMax = 1,
			ErrGrowMaterial = 2,
			ErrTemporaryCharacter = 3
		}
	
		public class LimitReleaseMaterialInfo
		{
			// Fields
			public MaterialDataElement[] mat;
			public int[] num;
	
			// Constructors
			public LimitReleaseMaterialInfo();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<GrowthManaCircleManaPieceData, bool> __9__80_0;
			public static Func<GrowthManaCircleManaPieceData, bool> __9__80_1;
			public static Func<GrowthManaCircleManaPieceData, bool> __9__81_0;
			public static Func<GrowthManaCircleManaPieceData, bool> __9__81_1;
			public static Func<GrowthManaCircleManaPieceData, bool> __9__83_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _CanUsePlatinumCrystal_b__80_0(GrowthManaCircleManaPieceData p);
			internal bool _CanUsePlatinumCrystal_b__80_1(GrowthManaCircleManaPieceData p);
			internal bool _UpdatePlatinumCrystalState_b__81_0(GrowthManaCircleManaPieceData p);
			internal bool _UpdatePlatinumCrystalState_b__81_1(GrowthManaCircleManaPieceData p);
			internal bool _ShowUsePlatinumCrystalConfirmPopup_b__83_0(GrowthManaCircleManaPieceData p);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass82_0
		{
			// Fields
			public GrowthManaCircleManaCircleData circleData;
			public Action onOK;
			public Action __9__5;
	
			// Constructors
			public __c__DisplayClass82_0();
	
			// Methods
			internal void _ShowPlatinumCrystalUsePopup_b__5();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass82_1
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass82_1();
	
			// Methods
			internal void _ShowPlatinumCrystalUsePopup_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass82_2
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass82_2();
	
			// Methods
			internal void _ShowPlatinumCrystalUsePopup_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass82_3
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass82_3();
	
			// Methods
			internal void _ShowPlatinumCrystalUsePopup_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass82_4
		{
			// Fields
			public UsePlatinumCrystalPopup popup;
			public UnitDetailModel.CharaDetailData charaDetailData;
			public __c__DisplayClass82_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass82_4();
	
			// Methods
			internal void _ShowPlatinumCrystalUsePopup_b__3();
			internal void _ShowPlatinumCrystalUsePopup_b__4();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass83_0
		{
			// Fields
			public Action onOK;
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass83_0();
	
			// Methods
			internal void _ShowUsePlatinumCrystalConfirmPopup_b__1();
			internal void _ShowUsePlatinumCrystalConfirmPopup_b__2();
		}
	
		[CompilerGenerated]
		private struct _SendUsePlatinumCrystal_d__84 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public int charaId;
			public Action callback;
			private TaskAwaiter<CharaBuildupPlatinumResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
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
		public static UsedGrowMaterialType GetUsedGrowMaterialType(CharaDataElement masterCharaData);
		public static bool IsUseGrowMaterial(UsedGrowMaterialType usedGrowMaterilType, int haveGrowMaterialCount);
		public static int GetPlatinumCrystalNum();
		public static PlatinumCrystalUsableStatus CanUsePlatinumCrystal(ulong growBaseKeyId, GrowthManaCircleManaCircleData circleData);
		public static void UpdatePlatinumCrystalState(CharaDataElement masterCharaData, int level, GrowthManaCircleManaCircleData circleData, GameObject platinumCrystalRoot, UnityEngine.UI.Text platinumCrystalCountText);
		public static void ShowPlatinumCrystalUsePopup(ulong growBaseKeyId, GrowthManaCircleManaCircleData circleData, Action onOK);
		public static void ShowUsePlatinumCrystalConfirmPopup(UnitDetailModel.CharaDetailData charaDetailData, GrowthManaCircleManaCircleData circleData, Action onOK);
		public static async void SendUsePlatinumCrystal(int charaId, Action callback);
	}
}
