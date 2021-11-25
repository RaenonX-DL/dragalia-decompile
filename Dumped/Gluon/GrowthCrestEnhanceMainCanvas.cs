using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cute.Cri;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class GrowthCrestEnhanceMainCanvas : GrowthUnitEnhanceMainCanvas
	{
		public GrowthUnitEnhanceListCell[] listCells;

		public Button growPlusButton;

		public GameObject effectBaseObject;

		private BaseCanvasContents baseCanvasContents;

		private GameObject amuletAnimation;

		private GameObject amuletHeaderAnimation;

		private EffectObject frontEffectObject;

		private EffectObject backEffectObject;

		private EffectObject firstEffectObject;

		private bool isSkipButtonLocked;

		private GrowthLimitBreak.SkipEffectStatus nowEffectStatus;

		private int effectSkipSortOderKey;

		private AudioPlayback amuletSePlayback;

		private Canvas uiCanvas;

		private TouchGuardObject playCloseEffectTouchGuard;

		private FlashTextType playTextType;

		private int beforeLimitBreak;

		private bool isPlayMemorialRiseEffect;

		public static GrowthCrestEnhanceMainCanvas GetUICanvas(Transform parentTransform)
		{
			return null;
		}

		public override void InitCanvas(GrowthUnitEnhanceScene scene, GrowthUnitEnhanceModel model)
		{
		}

		public override void PlayResultEffects(GrowthUnitEnhanceSendData[] sendDatas, [Optional] Action effectEndCallBack)
		{
		}

		protected override GrowthUnitEnhanceListCell GetEnhanceListCell(UnitEnhanceListCellType type)
		{
			return null;
		}

		public override void OnAutoButtonPressed()
		{
		}

		private void OnCellButtonPressed(UnitEnhanceListCellType type)
		{
		}

		protected override void UpdateCell()
		{
		}

		protected override bool IsAllCellComplete()
		{
			return default(bool);
		}

		protected override bool IsUsableAutoButton()
		{
			return default(bool);
		}

		private void SendAutoEnhanceData(GrowthAutoUnitEnhanceConfirmPopup autoUnitEnhanceConfirmPopup, Action resultAction)
		{
		}

		public void OnPlusButtonPressed()
		{
		}

		private void ShowPlusParamConfirmPopup(Dictionary<int, int> materialData)
		{
		}

		private void PlayPlusParamGrowEffect(bool isPlayGrowHPEffect, bool isPlayGrowAtkEffect, Action playEndCallBack)
		{
		}

		private void ShowCrestLimitBreakResultPopup(int beforeLimitBreak, bool isUpdateAbility)
		{
		}

		private void ShowCrestPlusParamResultPopup(GrowthCrestPlusParamResultPopup.BeforeData data)
		{
		}

		private void ShowAutoEnhanceResultPopup(int totalReleaseCount, int beforeBuildup)
		{
		}

		private void StartLimitBreakTutorial()
		{
		}

		private void EndLimitBreakTutorial()
		{
		}

		private void ShowMemorialRiseEffect(Action memorialRiseEffectEndCallBack)
		{
		}

		private void SetupMemorialRiseEffect()
		{
		}

		private void CloseMemorialRiseEffect(Action endCallBack)
		{
		}

		private void PlayMemorialRiseEffect()
		{
		}

		private void OnSkipButtonPressed(bool isBackKey = false)
		{
		}

		private void PlayCloseMemorialRiseEffect()
		{
		}

		private void ShowTutorialPointer()
		{
		}

		private void UpdatePlusButton(bool interactable)
		{
		}
	}
}
