using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Gluon
{
	public class GrowthManaCircle2DScene : SceneBase
	{
		public Camera uiCamera;

		public Camera flashCamera;

		public GrowthManaCircleModel manaCircleModel;

		public Canvas bgCanvas;

		public GameObject releaseEffectBase;

		public GrowthManaCircleSoundController soundController;

		[HideInInspector]
		public GrowthManaCircle2DUICanvas mainCanvas;

		[HideInInspector]
		public string voiceGroupName;

		private GrowthManaCircleStatusCanvas statusCanvas;

		private BackButton backButton;

		private BaseCanvasContents baseCanvasContents;

		private TouchGuardObject releasePieceEffectTouchGuard;

		public int targetCharaId
		{
			[CompilerGenerated]
			get
			{
				return default(int);
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

		private void OnEnterScene()
		{
		}

		public override void OnPresentReceived()
		{
		}

		private void OnDestroy()
		{
		}

		public void BackButtonPressed()
		{
		}

		public void OnGrowthButtonPressed()
		{
		}

		public void OnAwakeningButtonPressed()
		{
		}

		public void SendReleasePieceData(int[] pieceIds, bool isGrowRelease, [Optional] Action callback)
		{
		}

		public void SendLimitBreakData([Optional] Action callback)
		{
		}

		public void SendReleasePieceAndLimitBreakData(AutoReleasableAllCirclePointData autoReleasableData, bool isGrowRelease, [Optional] Action<AutoReleasableAllCirclePointData> callback)
		{
		}

		public void ReloadSceneUI()
		{
		}

		public void SetupReleasePieceEffect()
		{
		}

		public void CloseReleasePieceEffect()
		{
		}

		public void StartTutorial()
		{
		}

		public void ShowTutorialFinishWindow()
		{
		}
	}
}
