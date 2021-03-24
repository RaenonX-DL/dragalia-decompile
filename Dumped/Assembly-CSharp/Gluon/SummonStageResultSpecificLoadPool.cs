/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using FLATOUT.Main;
using Gluon.Master;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SummonStageResultSpecificLoadPool
	{
		// Fields
		private static SummonStageResultSpecificLoadPool instance;
		public GameObject[] unitModelList;
		public GameObject[] weaponModelList;
		public GameObject[] weaponSubModelList;
		public GameObject[] rightArmList;
		public GameObject[] leftArmList;
		public DroppingObj[] dropObjList;
		public GameObject[] droppingObjParentShot1;
		public GameObject[] droppingObjParentShot2;
		public GameObject cameraParentShot1;
		public GameObject[] cameraParentShot2List;
		public RuntimeAnimatorController[] appealAnimatorControllerList;
		public RuntimeAnimatorController[] resultIdleAnimatorControllerList;
		public FlashPlayer[] shot2FlashPlayerList;
		public EffectObject[] shot2FlashFlareEffectList;
		public EffectObject[] shot2FlashRarityKiraEffectList;
		public EffectObject[] shot2FlashSSRTextEffectList;
		public EffectObject[] shot2FlashDragonSSRSp1EffectList;
		public EffectObject[] shot2FlashDragonSSRSp2EffectList;
		public EffectObject[] shot2FlashAdventEffectList;
		public List<FlPlane>[] shot2CutinOffsetablePlaneList;
		public string[] shot2TextLayoutMainTxtPath;
		public string[] shot2TextLayoutShadow1Path;
		public string[] shot2TextLayoutShadow2Path;
		public string[] shot2TextLayoutDewPointPath;
		public GameObject fafnirModelA;
		public GameObject fafnirModelB;
		public RuntimeAnimatorController fafnirAnimationControllerA;
		public RuntimeAnimatorController fafnirAnimationControllerB;
		private GameObject textLayoutAsset;
		private GameObject dewTextLayoutAsset;
		private const int fafnirId = 290601;
		private const string characterAppealBasePath = "Character/Appeal/";
		private const string fafnirModelBasePath = "Enemy/model/";
		private const string fafnirAnimatorPathA = "SMN_NPC_0290601_01_01";
		private const string fafnirAnimatorPathB = "SMN_NPC_0290601_01_02";
		private List<string> loadedSoundGroupList;
		private const float iPhoneXFlashCutinBGContentsMoveOffset = 50f;
		private const int dragonEffectKickTrigger = 20;
		private List<AttachObjectInfo> attachedDragonObjectInfoList;
		public const string animatorPath = "Animations/OutGame/Summon/";
		private const string resultIdleDragonAnimatorPath = "Dragon/motion/d";
		private List<SummonResultItemData> resultItems;
		private List<SummonStageUtil.UnitMasterElement> charaDragonMasterElementList;
		private List<SummonStageShadowReceiver.ShadowSetting> shot2ShadowSettings;
		public List<GameObject> shot2CharaMovingParts;
		public List<EffectObject>[] shot2DecoEffects;
		private const int shot2ShadowIndex = 10;
		private List<string> stageUnitSpecialEffectNameList;
		private SummonUnitShaderSettings summonUnitShaderSettings;
		private Camera summonF2UCamera;
		private Dictionary<string, string> flashSELabelTable;
		public List<SummonModelSetting> modelSettingList;
		private List<string> dropObjectAnimatorPath;
		private List<string> dropObjectStoneAnimatorPath;
		private List<string> dropObjectShot2AnimatorPath;
		private List<string> cameraAnimatorListPath;
		public List<CameraMotionPathSetting> cameraMotionPathList;
	
		// Properties
		public static SummonStageResultSpecificLoadPool Instance { get; }
	
		// Nested types
		public struct DroppingObj
		{
			// Fields
			public EffectObject mainWeapon;
			public EffectObject subWeapon;
			public bool isUpgrading;
		}
	
		private class AttachObjectInfo
		{
			// Fields
			public AttachObject deco;
			public DragonDecorationElement elem;
	
			// Constructors
			public AttachObjectInfo();
		}
	
		public struct CameraMotionPathSetting
		{
			// Fields
			public string shortRange;
			public string longRange;
	
			// Constructors
			public CameraMotionPathSetting(string shortCamera, string longCamera);
		}
	
		public enum CameraAnimatorListIndex
		{
			Shot_1_MultiSummon = 0,
			Shot_1_SingleSummon = 1,
			Shot_2_New = 2,
			Shot_2_Moon = 3,
			Shot_2_Amulet = 4,
			Shot_1_SinglesSummon = 5
		}
	
		public enum DragonCameraDistance
		{
			Short = 0,
			Long = 1
		}
	
		public enum DragonCameraType
		{
			Floating = 1,
			FourLegged = 2,
			Bipedal = 3,
			HumanoidFloating = 4
		}
	
		public struct SummonModelSetting
		{
			// Fields
			public string modelPath;
			public string subModelPath;
			public float shot1Scale;
			public string charactorMotion;
			public float shot2Scale;
			public float shot3Scale;
			public WeaponSwitchHandSetting switchSetting;
			public float switchTime;
	
			// Nested types
			public enum WeaponSwitchHandSetting
			{
				KeepRight = 0,
				SubWeaponLeft = 1,
				SwitchForKatana = 2
			}
	
			// Constructors
			public SummonModelSetting(string model, string subModel, float s1Scale, string charaMotion, float s2Scale, float s3Scale, WeaponSwitchHandSetting switchSetting, float switchTime);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass79_0
		{
			// Fields
			public int loadedCount;
			public int toLoadCount;
			public Action onLoaded;
			public SummonStageResultSpecificLoadPool __4__this;
			public Action proceedLoading;
	
			// Constructors
			public __c__DisplayClass79_0();
	
			// Methods
			internal void _LoadAllAsync_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass79_1
		{
			// Fields
			public string path;
			public __c__DisplayClass79_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass79_1();
	
			// Methods
			internal void _LoadAllAsync_b__1(GameObject go, int index);
			internal void _LoadAllAsync_b__2(GameObject go, int index);
			internal void _LoadAllAsync_b__3(RuntimeAnimatorController rc, int index);
			internal void _LoadAllAsync_b__4(RuntimeAnimatorController rc, int index);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass80_0
		{
			// Fields
			public int loadedCount;
			public int toLoadCount;
			public Action onLoaded;
	
			// Constructors
			public __c__DisplayClass80_0();
	
			// Methods
			internal void _LoadAllAsyncForBoxSummon_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass81_0
		{
			// Fields
			public int loadedCount;
			public int toLoadCount;
			public Action onComplete;
	
			// Constructors
			public __c__DisplayClass81_0();
	
			// Methods
			internal void _LoadPickupItemResourcesForBoxSummon_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass82_0
		{
			// Fields
			public int loadedCount;
			public int toLoadCount;
			public Action onLoaded;
	
			// Constructors
			public __c__DisplayClass82_0();
	
			// Methods
			internal void _LoadAllAsyncForAlbumSummon_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass86_0
		{
			// Fields
			public int loadedCount;
			public int toLoadCount;
			public Action onLoaded;
			public Action proceedLoading;
			public Action __9__1;
	
			// Constructors
			public __c__DisplayClass86_0();
	
			// Methods
			internal void _LoadAllStageUnitSpecialEffect_b__0();
			internal void _LoadAllStageUnitSpecialEffect_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass87_0
		{
			// Fields
			public SummonStageResultSpecificLoadPool __4__this;
			public Action onLoaded;
	
			// Constructors
			public __c__DisplayClass87_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass87_1
		{
			// Fields
			public List<int> summonModelIndexForGOList;
			public int asyncLoadedCount;
			public SummonStageUtil util;
			public int modelCount;
			public Action assignDuplicatedModels;
			public __c__DisplayClass87_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass87_1();
	
			// Methods
			internal void _LoadAllCharaDragonModelsAsync_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass87_2
		{
			// Fields
			public StringBuilder path;
			public CharaDataElement masterData;
			public int baseId;
			public int varId;
			public __c__DisplayClass87_1 CS___8__locals2;
	
			// Constructors
			public __c__DisplayClass87_2();
	
			// Methods
			internal void _LoadAllCharaDragonModelsAsync_b__1(GameObject go, int index);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass87_3
		{
			// Fields
			public StringBuilder path;
			public __c__DisplayClass87_1 CS___8__locals3;
	
			// Constructors
			public __c__DisplayClass87_3();
	
			// Methods
			internal void _LoadAllCharaDragonModelsAsync_b__2(GameObject go, int index);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass89_0
		{
			// Fields
			public SummonStageResultSpecificLoadPool __4__this;
			public SummonStageUtil util;
			public Action onLoaded;
	
			// Constructors
			public __c__DisplayClass89_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass89_1
		{
			// Fields
			public StringBuilder path;
			public int baseId;
			public int varId;
			public __c__DisplayClass89_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass89_1();
	
			// Methods
			internal void _LoadSingleCharaDragonModelsAsync_b__0(GameObject go, int index);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass89_2
		{
			// Fields
			public StringBuilder path;
			public __c__DisplayClass89_0 CS___8__locals2;
	
			// Constructors
			public __c__DisplayClass89_2();
	
			// Methods
			internal void _LoadSingleCharaDragonModelsAsync_b__1(GameObject go, int index);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass93_0
		{
			// Fields
			public Action onLoaded;
			public SummonStageResultSpecificLoadPool __4__this;
	
			// Constructors
			public __c__DisplayClass93_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass93_1
		{
			// Fields
			public int loadedCount;
			public int toLoadCount;
			public Action proceedLoading;
			public __c__DisplayClass93_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass93_1();
	
			// Methods
			internal void _LoadAllWeaponModelsAsync_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass93_2
		{
			// Fields
			public string path;
			public __c__DisplayClass93_1 CS___8__locals2;
	
			// Constructors
			public __c__DisplayClass93_2();
	
			// Methods
			internal void _LoadAllWeaponModelsAsync_b__1(GameObject go, int index);
			internal void _LoadAllWeaponModelsAsync_b__2(GameObject go, int index);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass94_0
		{
			// Fields
			public SummonStageResultSpecificLoadPool __4__this;
			public Action onLoaded;
	
			// Constructors
			public __c__DisplayClass94_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass94_1
		{
			// Fields
			public int loadedCount;
			public __c__DisplayClass94_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass94_1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass94_2
		{
			// Fields
			public string path;
			public __c__DisplayClass94_1 CS___8__locals2;
	
			// Constructors
			public __c__DisplayClass94_2();
	
			// Methods
			internal void _LoadAllCameraAnimationParentShot2_b__0(GameObject go, int index);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass95_0
		{
			// Fields
			public SummonStageResultSpecificLoadPool __4__this;
			public Action onLoaded;
	
			// Constructors
			public __c__DisplayClass95_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass95_1
		{
			// Fields
			public string path;
			public __c__DisplayClass95_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass95_1();
	
			// Methods
			internal void _LoadAllCameraAnimationParentShot1_b__0(GameObject go, int index);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass96_0
		{
			// Fields
			public Action onLoaded;
			public SummonStageResultSpecificLoadPool __4__this;
	
			// Constructors
			public __c__DisplayClass96_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass96_1
		{
			// Fields
			public int loadedCount;
			public int toLoadCount;
			public Action proceedLoading;
			public __c__DisplayClass96_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass96_1();
	
			// Methods
			internal void _LoadAllDropItem_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass96_2
		{
			// Fields
			public string animPath;
			public string path;
			public __c__DisplayClass96_1 CS___8__locals2;
	
			// Constructors
			public __c__DisplayClass96_2();
	
			// Methods
			internal void _LoadAllDropItem_b__1(GameObject go, int index);
			internal void _LoadAllDropItem_b__2(GameObject go, int index);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass97_0
		{
			// Fields
			public Action onLoaded;
			public SummonStageResultSpecificLoadPool __4__this;
	
			// Constructors
			public __c__DisplayClass97_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass97_1
		{
			// Fields
			public int loadedCount;
			public int toLoadCount;
			public SummonStageUtil util;
			public Action proceedLoading;
			public __c__DisplayClass97_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass97_1();
	
			// Methods
			internal void _LoadAllAppealMotionController_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass97_2
		{
			// Fields
			public int id;
			public __c__DisplayClass97_1 CS___8__locals2;
	
			// Constructors
			public __c__DisplayClass97_2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass97_3
		{
			// Fields
			public WeaponType wc;
			public string specialPath;
			public __c__DisplayClass97_2 CS___8__locals3;
	
			// Constructors
			public __c__DisplayClass97_3();
	
			// Methods
			internal void _LoadAllAppealMotionController_b__1(RuntimeAnimatorController rac, int index);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass97_4
		{
			// Fields
			public string commonPath;
			public __c__DisplayClass97_3 CS___8__locals4;
	
			// Constructors
			public __c__DisplayClass97_4();
	
			// Methods
			internal void _LoadAllAppealMotionController_b__2(RuntimeAnimatorController commonRac, int commonIndex);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass97_5
		{
			// Fields
			public string path;
			public __c__DisplayClass97_2 CS___8__locals5;
	
			// Constructors
			public __c__DisplayClass97_5();
	
			// Methods
			internal void _LoadAllAppealMotionController_b__3(RuntimeAnimatorController rac, int index);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass98_0
		{
			// Fields
			public Action onLoaded;
			public SummonStageResultSpecificLoadPool __4__this;
	
			// Constructors
			public __c__DisplayClass98_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass98_1
		{
			// Fields
			public int loadedCount;
			public int toLoadCount;
			public Action proceedLoading;
			public SummonStageUtil util;
			public __c__DisplayClass98_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass98_1();
	
			// Methods
			internal void _LoadAllResultMotionController_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass98_2
		{
			// Fields
			public GiftType giftType;
			public __c__DisplayClass98_1 CS___8__locals2;
	
			// Constructors
			public __c__DisplayClass98_2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass98_3
		{
			// Fields
			public string path;
			public Action<RuntimeAnimatorController, int> onAnimatorLoaded;
			public __c__DisplayClass98_2 CS___8__locals3;
	
			// Constructors
			public __c__DisplayClass98_3();
	
			// Methods
			internal void _LoadAllResultMotionController_b__1(RuntimeAnimatorController rac, int index);
			internal void _LoadAllResultMotionController_b__2(RuntimeAnimatorController rac, int index);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass98_4
		{
			// Fields
			public int index;
			public __c__DisplayClass98_3 CS___8__locals4;
	
			// Constructors
			public __c__DisplayClass98_4();
	
			// Methods
			internal void _LoadAllResultMotionController_b__3(RuntimeAnimatorController commonRac, int _);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass100_0
		{
			// Fields
			public SummonStageUtil util;
			public SummonStageResultSpecificLoadPool __4__this;
	
			// Constructors
			public __c__DisplayClass100_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass100_1
		{
			// Fields
			public int i;
			public __c__DisplayClass100_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass100_1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass100_2
		{
			// Fields
			public FlashPlayer shot2FlashPlayer;
			public __c__DisplayClass100_1 CS___8__locals2;
	
			// Constructors
			public __c__DisplayClass100_2();
	
			// Methods
			internal void _LoadAllFlashPlayerAsOption_b__0(int index);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass100_3
		{
			// Fields
			public KeyValuePair<string, string> seLabelSetting;
	
			// Constructors
			public __c__DisplayClass100_3();
	
			// Methods
			internal void _LoadAllFlashPlayerAsOption_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass111_0
		{
			// Fields
			public List<string> pathList;
			public SummonStageResultSpecificLoadPool __4__this;
			public Action onLoaded;
			public bool isResult;
	
			// Constructors
			public __c__DisplayClass111_0();
	
			// Methods
			internal void _TryLoadDragonAnimator_b__0(RuntimeAnimatorController rac, int toIndex);
		}
	
		// Constructors
		private SummonStageResultSpecificLoadPool();
		static SummonStageResultSpecificLoadPool();
	
		// Methods
		public static void DeleteInstance();
		public void Init();
		public void InitModelSettingList();
		private void InitCameraAnimatorListPath();
		public void InitCameraMotionPathList();
		private void InitDropObjectAnimatorPath();
		private void InitDropObjectStoneAnimatorPath();
		private void InitDropObjectShot2AnimatorPath();
		public string GetfafnirModelPath();
		public string GetfafnirAnimatorPath(int index);
		public void LoadAllAsync(Action onLoaded);
		public void LoadAllAsyncForBoxSummon(Action onLoaded);
		public void LoadPickupItemResourcesForBoxSummon(Action onComplete);
		public void LoadAllAsyncForAlbumSummon(Action onLoaded);
		public void SetAlbumSummonSetting(SummonUnitShaderSettings shaderSettings, Camera flashCamera);
		private void LoadTextLayoutParameter();
		private void LoadAllCharacterSE(Action onLoaded);
		private void LoadAllStageUnitSpecialEffect(Action onLoaded);
		private void LoadAllCharaDragonModelsAsync(Action onLoaded);
		public void LoadRichModel(GameObject go, string path);
		public void LoadSingleCharaDragonModelsAsync(int resultItemIndex, Action onLoaded);
		private void AttachDragonDecoration(int decoId, int index);
		public void PlayDecoEffects(int index);
		public void ResetAllDragonDecorationAnimator();
		private void LoadAllWeaponModelsAsync(Action onLoaded);
		private void LoadAllCameraAnimationParentShot2(Action onLoaded);
		private void LoadAllCameraAnimationParentShot1(Action onLoaded);
		public void LoadAllDropItem(Action onLoaded);
		private void LoadAllAppealMotionController(Action onLoaded);
		private void LoadAllResultMotionController(Action onLoaded);
		private string GetCutinFlashPath(int index);
		private void LoadAllFlashPlayerAsOption(Action onLoaded);
		private void SetupLocalizeTextPosition(FlashPlayer flashPlayer, int index, GiftType giftType, int rarity, bool isDew);
		public void ChangeLocalizeTextPosition(int index);
		private void BindSPFXToStaticLocation(EffectObject effect, int positionIndex);
		private void ReparentSPFXToFlashTransform(EffectObject effect, Transform flashTransform);
		private bool GetBaseIdAndVarIdFromAnimFileName(string animFileName, out int baseId, out int varId);
		private string CreateAppealDragonDecoPathByAnimFileName(string animFileName);
		private string CreateAppealDragonPathInternalUse(int baseId, int varId);
		private string CreateAppealDragonDecoPath(string animName);
		private string CreateResultDragonPathByAnimFileName(string animFileName);
		private string CreateResultDragonPathInternalUse(int baseId, int varId);
		private void TryLoadDragonAnimator(List<string> pathList, int index, Action onLoaded, bool isResult);
		private DroppingObj LoadSingleDropItem(int resultIndex);
		public void ProcessBinding();
		public void ProcessBindingForBoxSummon();
		private void BindCutinAdventEffect();
		private void BindWeapon();
		private void BindDropObjShadow();
		public void PlayShot2Shadow(int index);
		public void ReleaseDroppingObjParentShot(int index = -1);
		public void ReleaseUnitDestroy(int index = -1);
		public bool CheckSameUnit(int index);
		public void ReleaseEffectObjectDestory(int index = -1);
		public bool IsExistUnitModelList(int index);
		public void ReleaseFlashPlayerList();
		private void ReleaseLoadedSoundGroup();
		private void OnDeleteInstance();
		public void ApplyLightProbeForUnit(GameObject obj);
		public void ReleaseDropItem(int index = -1);
		[CompilerGenerated]
		private void _LoadTextLayoutParameter_b__84_0(UnityEngine.Object asset);
		[CompilerGenerated]
		private void _LoadTextLayoutParameter_b__84_1(UnityEngine.Object asset);
	}
}
