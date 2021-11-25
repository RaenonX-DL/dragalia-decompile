using System.Collections;
using System.Collections.Generic;
using FLATOUT.Main;
using Gluon.Http;
using UnityEngine;

namespace Gluon
{
	public class CraftGradeupScene : SceneBase
	{
		public static int gradeupTargetId;

		public bool isChildData;

		public CraftGradeupCanvas mainCanvas;

		public Camera uiCamera;

		public Camera flashCamera;

		public Canvas bgCanvas;

		public Camera frontEffectCamera;

		public Camera backEffectCamera;

		[SerializeField]
		private Transform overlayParent;

		private BaseCanvasContents baseCanvasContents;

		private BackButton backButton;

		private GameObject craftAnimation;

		private GameObject craftHeaderAnimation;

		private EffectObject frontEffectObject;

		private EffectObject backEffectObject;

		private GameObject weaponModel;

		private bool isTapAndBackKeyLockFlag;

		private List<FlMotion> outMotionList;

		private int effectSkipSortOderKey;

		private bool isGoToPowerup;

		private Canvas uiCanvas;

		public const string basePrefabPath = "Prefabs/OutGame/Growth/";

		private UnitDetailUnitShaderSettings growthWeaponShaderSetting;

		private static readonly string shaderSettingPath;

		private void Awake()
		{
		}

		private IEnumerator Start()
		{
			return null;
		}

		private void OnPrevSceneExitDone()
		{
		}

		private void OnInitReady()
		{
		}

		private IEnumerator LoadMaterialData()
		{
			return null;
		}

		private void OnEnterScene()
		{
		}

		private void OnDestroy()
		{
		}

		public override void OnPresentReceived()
		{
		}

		public void BackButtonPressed()
		{
		}

		private void OnCraftButtonPressed()
		{
		}

		private GrowMaterialList[] GetMaterialListData()
		{
			return null;
		}

		private AtgenWeaponSetList[] GetMaterialWeaponSendData()
		{
			return null;
		}

		private void ShowCraftEffect()
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

		private void CloseCraftEffect()
		{
		}

		private void PlayNextEffect(bool isBackKey = false)
		{
		}
	}
}
