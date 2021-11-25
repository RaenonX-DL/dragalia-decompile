using System;
using System.Collections.Generic;
using FLATOUT.Main;
using Gluon.Master;
using UnityEngine;

namespace Gluon
{
	public class SummonStageResultSpecificLoadPool
	{
		public struct DroppingObj
		{
			public EffectObject mainWeapon;

			public EffectObject subWeapon;

			public bool isUpgrading;
		}

		private class AttachObjectInfo
		{
			public AttachObject deco;

			public DragonDecorationElement elem;
		}

		public struct CameraMotionPathSetting
		{
			public string shortRange;

			public string longRange;

			public CameraMotionPathSetting(string shortCamera, string longCamera)
			{
			}
		}

		public enum CameraAnimatorListIndex
		{
			Shot_1_MultiSummon,
			Shot_1_SingleSummon,
			Shot_2_New,
			Shot_2_Moon,
			Shot_2_Amulet,
			Shot_1_SinglesSummon
		}

		public enum DragonCameraDistance
		{
			Short,
			Long
		}

		public enum DragonCameraType
		{
			Floating = 1,
			FourLegged,
			Bipedal,
			HumanoidFloating,
			Floating2,
			FloatingV2,
			FourLeggedV2,
			BipedalV2,
			HumanoidFloatingV2
		}

		public struct SummonModelSetting
		{
			public enum WeaponSwitchHandSetting
			{
				KeepRight,
				SubWeaponLeft,
				SwitchForKatana
			}

			public string modelPath;

			public string subModelPath;

			public float shot1Scale;

			public string charactorMotion;

			public float shot2Scale;

			public float shot3Scale;

			public WeaponSwitchHandSetting switchSetting;

			public float switchTime;

			public SummonModelSetting(string model, string subModel, float s1Scale, string charaMotion, float s2Scale, float s3Scale, WeaponSwitchHandSetting switchSetting, float switchTime)
			{
			}
		}

		private static SummonStageResultSpecificLoadPool instance;

		public GameObject[] unitModelList;

		public GameObject[] weaponModelList;

		public GameObject[] weaponSubModelList;

		public GameObject[] rightArmList;

		public GameObject[] leftArmList;

		public GameObject unitModelAo;

		public GameObject rightArmAo;

		public GameObject jGameRootAo;

		public DroppingObj[] dropObjList;

		public GameObject[] droppingObjParentShot1;

		public GameObject[] droppingObjParentShot2;

		public GameObject cameraParentShot1;

		public GameObject[] cameraParentShot2List;

		public RuntimeAnimatorController[] appealAnimatorControllerList;

		public RuntimeAnimatorController appealAnimatorControllerAo;

		public RuntimeAnimatorController[] resultIdleAnimatorControllerList;

		public FlashPlayer[] shot2FlashPlayerList;

		public FlMotion[] shot2FlashPlayerAoMotion;

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

		public SummonStageShadowReceiver.ShadowSetting shot2AoShadowSettings;

		public GameObject shot2CharaAoMovingParts;

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

		public static SummonStageResultSpecificLoadPool Instance => null;

		public static void DeleteInstance()
		{
		}

		private SummonStageResultSpecificLoadPool()
		{
		}

		static SummonStageResultSpecificLoadPool()
		{
		}

		public void Init()
		{
		}

		public void InitModelSettingList()
		{
		}

		private void InitCameraAnimatorListPath()
		{
		}

		public void InitCameraMotionPathList()
		{
		}

		private void InitDropObjectAnimatorPath()
		{
		}

		private void InitDropObjectStoneAnimatorPath()
		{
		}

		private void InitDropObjectShot2AnimatorPath()
		{
		}

		public string GetfafnirModelPath()
		{
			return null;
		}

		public string GetfafnirAnimatorPath(int index)
		{
			return null;
		}

		public void LoadAllAsync(Action onLoaded)
		{
		}

		public void LoadAllAsyncForBoxSummon(Action onLoaded)
		{
		}

		public void LoadPickupItemResourcesForBoxSummon(Action onComplete)
		{
		}

		public void LoadAllAsyncForAlbumSummon(Action onLoaded)
		{
		}

		public void SetAlbumSummonSetting(SummonUnitShaderSettings shaderSettings, Camera flashCamera)
		{
		}

		private void LoadTextLayoutParameter()
		{
		}

		private void LoadAllCharacterSE(Action onLoaded)
		{
		}

		private void LoadAllStageUnitSpecialEffect(Action onLoaded)
		{
		}

		private void LoadAllCharaDragonModelsAsync(Action onLoaded)
		{
		}

		public void LoadRichModel(GameObject go, string path)
		{
		}

		public void LoadSingleCharaDragonModelsAsync(int resultItemIndex, Action onLoaded)
		{
		}

		private void AttachDragonDecoration(int decoId, int index)
		{
		}

		public void PlayDecoEffects(int index)
		{
		}

		public void ResetAllDragonDecorationAnimator()
		{
		}

		private void LoadAllWeaponModelsAsync(Action onLoaded)
		{
		}

		private void LoadAllCameraAnimationParentShot2(Action onLoaded)
		{
		}

		private void LoadAllCameraAnimationParentShot1(Action onLoaded)
		{
		}

		public void LoadAllDropItem(Action onLoaded)
		{
		}

		private void LoadAllAppealMotionController(Action onLoaded)
		{
		}

		private void LoadAllResultMotionController(Action onLoaded)
		{
		}

		private string GetCutinFlashPath(int index)
		{
			return null;
		}

		private void LoadAllFlashPlayerAsOption(Action onLoaded)
		{
		}

		private void SetupLocalizeTextPosition(FlashPlayer flashPlayer, int index, GiftType giftType, int rarity, bool isDew)
		{
		}

		public void ChangeLocalizeTextPosition(int index)
		{
		}

		private void BindSPFXToStaticLocation(EffectObject effect, int positionIndex)
		{
		}

		private void ReparentSPFXToFlashTransform(EffectObject effect, Transform flashTransform)
		{
		}

		private bool GetBaseIdAndVarIdFromAnimFileName(string animFileName, out int baseId, out int varId)
		{
			return default(bool);
		}

		private string CreateAppealDragonDecoPathByAnimFileName(string animFileName)
		{
			return null;
		}

		private string CreateAppealDragonPathInternalUse(int baseId, int varId)
		{
			return null;
		}

		private string CreateAppealDragonDecoPath(string animName)
		{
			return null;
		}

		private string CreateResultDragonPathByAnimFileName(string animFileName)
		{
			return null;
		}

		private string CreateResultDragonPathInternalUse(int baseId, int varId)
		{
			return null;
		}

		private void TryLoadDragonAnimator(List<string> pathList, int index, Action onLoaded, bool isResult)
		{
		}

		private DroppingObj LoadSingleDropItem(int resultIndex)
		{
			return default(DroppingObj);
		}

		public void ProcessBinding()
		{
		}

		public void ProcessBindingForBoxSummon()
		{
		}

		private void BindCutinAdventEffect()
		{
		}

		private void BindWeapon()
		{
		}

		private void BindDropObjShadow()
		{
		}

		public void PlayShot2Shadow(int index)
		{
		}

		public void ReleaseDroppingObjParentShot(int index = -1)
		{
		}

		public void ReleaseUnitDestroy(int index = -1)
		{
		}

		public bool CheckSameUnit(int index)
		{
			return default(bool);
		}

		public void ReleaseEffectObjectDestory(int index = -1)
		{
		}

		public bool IsExistUnitModelList(int index)
		{
			return default(bool);
		}

		public void ReleaseFlashPlayerList()
		{
		}

		private void ReleaseLoadedSoundGroup()
		{
		}

		private void OnDeleteInstance()
		{
		}

		public void ApplyLightProbeForUnit(GameObject obj)
		{
		}

		public void ReleaseDropItem(int index = -1)
		{
		}
	}
}
