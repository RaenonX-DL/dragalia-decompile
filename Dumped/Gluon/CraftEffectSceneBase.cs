using System.Collections;
using System.Collections.Generic;
using FLATOUT.Main;
using UnityEngine;
using UnityEngine.Events;

namespace Gluon
{
	public abstract class CraftEffectSceneBase : SceneBase
	{
		public enum LimitBreakMotionLabel
		{
			disable,
			normal,
			max
		}

		public Camera effectUiCamera;

		public Camera effectFlashCamera;

		public Camera frontEffectBaseCamera;

		public Camera backEffectBaseCamera;

		public Camera render3dCamera;

		public Canvas effectBgCanvas;

		protected GrowthWeaponObjectsSettings objectsSettings;

		protected List<CraftStepupConfirmPopupBackupData> craftPopupBackupDataList;

		protected Canvas uiCanvas;

		protected int craftEffectWeaponId;

		protected int[] cfartEffectMaterialIds;

		protected ulong[] cfartEffectMaterialWeaponIds;

		protected bool isTargetLimitBreak;

		protected int craftCount;

		protected UnityAction resultEndCallBack;

		protected CraftEffectMainCanvas effectMainCanvas;

		protected BackButton backButton;

		private GameObject craftAnimation;

		private GameObject craftHeaderAnimation;

		private GameObject weaponModel;

		private BaseCanvasContents baseCanvasContents;

		private EffectObject frontEffectObject;

		private EffectObject backEffectObject;

		private List<FlMotion> outMotionList;

		private int effectSkipSortOderKey;

		private bool isTapAndBackKeyLockFlag;

		private const int columnMax = 2;

		[SerializeField]
		protected RawImageWithAlphaBlend modelViewImage;

		protected UnitDetailUnitShaderSettings growthWeaponShaderSetting;

		public void UpdateObjectsParameters()
		{
		}

		protected void SetupFlashCamera()
		{
		}

		protected void SetUpRenderCamera()
		{
		}

		protected virtual void SetupCraftEffectData()
		{
		}

		protected void ShowCraftEffect(bool isLimitBreak)
		{
		}

		private void CreateWeaponModel()
		{
		}

		public void InitWeaponTransform(WeaponType weaponType)
		{
		}

		private IEnumerator StartAnimationDelay(FlMotion craftAnimeMotion, int matCount, int rarity)
		{
			return null;
		}

		private IEnumerator StartHeaderAnimationDelay()
		{
			return null;
		}

		private void SetupAwakeEffect()
		{
		}

		protected virtual void CloseCraftEffect()
		{
		}

		protected virtual bool PlayNextEffect(bool isBackKey = false)
		{
			return default(bool);
		}

		public static LimitBreakMotionLabel[] GetLimitBreakMotionLabels(int columnNum, int reminder)
		{
			return null;
		}
	}
}
