using System.Collections;
using UnityEngine;

namespace Gluon
{
	public class GrowthWeaponScene : CraftEffectSceneBase
	{
		public enum WeaponSceneState
		{
			None,
			SeriesList,
			WeaponList
		}

		public static WeaponSceneState weaponSceneState;

		public static int weaponSeriesIndex;

		public static int weaponTypeIndex;

		public Transform overlayParent;

		[HideInInspector]
		public bool isTutorialRequired;

		private TouchGuardObject uiLoadTouchGuard;

		private GrowthWeaponMainCanvas growthWeaponMainCanvas;

		private GrowthWeaponSeriesListCanvas growthWeaponSeriesListCanvas;

		private AnimationUICanvas currentAnimationUICanvas;

		private int goEnhanceWeaponId;

		public const string prefabPath = "Prefabs/OutGame/Growth/GrowthWeapon/";

		private static readonly string shaderSettingPath;

		private void Awake()
		{
		}

		private IEnumerator Start()
		{
			return null;
		}

		private void OnDestroy()
		{
		}

		private void OnPrevSceneExitDone()
		{
		}

		private void OnInitReady()
		{
		}

		private void OnEnterScene()
		{
		}

		public override void OnPresentReceived()
		{
		}

		public void SetupModelViewImage(bool enableAlphaBlend)
		{
		}

		public static void SetupSceneByWeaponBodyId(int weaponId)
		{
		}

		public void SetBackButton(Canvas uiCanvas)
		{
		}

		public void CreateUILoadTouchGuard()
		{
		}

		public void RemoveUILoadTouchGuard()
		{
		}

		public void ChangeSceneState(WeaponSceneState nextState)
		{
		}

		public void GoWeaponEnhanceScene(int weaponId)
		{
		}

		public void GoFortScene()
		{
		}

		public void SendCraftData(int weaponId)
		{
		}

		private void OnBackButtonPressed()
		{
		}

		private void LoadUICanvas()
		{
		}

		private void SetupCraftEffectData(int weaponId)
		{
		}

		private void AfterResultAction()
		{
		}

		protected override void CloseCraftEffect()
		{
		}

		protected override bool PlayNextEffect(bool isBackKey = false)
		{
			return default(bool);
		}
	}
}
