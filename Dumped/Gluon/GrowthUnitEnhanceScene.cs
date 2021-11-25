using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Gluon
{
	public class GrowthUnitEnhanceScene : SceneBase
	{
		public static GrowthUnitEnhanceModel.DataType unitDataType;

		public static int targetUnitId;

		public Camera uiCamera;

		public Camera flashCamera;

		public Canvas bgCanvas;

		public Camera frontEffectCamera;

		public Camera backEffectCamera;

		public Transform overlayParent;

		public Camera render3dCamera;

		public GrowthWeaponObjectsSettings objectsSettings;

		public RawImageWithAlphaBlend modelViewImage;

		[HideInInspector]
		public TouchGuardObject uiLoadTouchGuard;

		[HideInInspector]
		public BackButton backButton;

		private GrowthUnitEnhanceMainCanvas unitEnhanceMainCanvas;

		private GrowthUnitEnhanceModel unitModel;

		private float prevSceneListScrollPosY;

		private bool isSetPrevSceneData;

		private static readonly string shaderSettingPath;

		public UnitDetailUnitShaderSettings growthWeaponShaderSetting
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnPrevSceneExitDone()
		{
		}

		private void OnInitReady()
		{
		}

		public override void OnBeforeLeaving()
		{
		}

		private void OnEnterScene()
		{
		}

		public void SetupModelViewImage(bool enableAlphaBlend)
		{
		}

		public static void SetupSceneByUnitId(int unitId)
		{
		}

		public override void OnPresentReceived()
		{
		}

		public void BackButtonPressed()
		{
		}

		public void SendWeaponEnhanceData(GrowthUnitEnhanceSendData[] sendDatas, [Optional] Action completeCallBack)
		{
		}

		public void SendCrestEnhanceData(GrowthUnitEnhanceSendData[] sendDatas, [Optional] Action completeCallBack)
		{
		}

		public void SendCrestPlusParamData(int hpPlus, int atkPlus, [Optional] Action completeCallBack)
		{
		}

		private void SetupFlashCamera()
		{
		}

		private void SetupRenderCamera()
		{
		}

		public void UpdateObjectsParameters()
		{
		}
	}
}
