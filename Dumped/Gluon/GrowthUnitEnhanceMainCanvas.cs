using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public abstract class GrowthUnitEnhanceMainCanvas : MonoBehaviour
	{
		public enum FlashTextType
		{
			None,
			LimitBreak,
			LimitOver,
			Complete,
			GrowAtkPlus,
			GrowHPPlus
		}

		public GrowthUnitEnhanceStatusController controller;

		public GameObject[] disableUIObjects;

		public Sprite equipCountIconSprite;

		public Material equipCountIconMaterial;

		public Button autoButton;

		[HideInInspector]
		public GrowthUnitEnhanceScene scene;

		[HideInInspector]
		public GrowthUnitEnhanceModel model;

		public const string prefabPath = "Prefabs/OutGame/Growth/GrowthUnitEnhance/";

		public const string flashPrefabPath = "Prefabs/OutGame/Growth/GrowthUnitEnhance/Flash/";

		protected bool isAutoEnhanceResult;

		protected TouchGuardObject unitResultEffectTouchGuard;

		protected abstract GrowthUnitEnhanceListCell GetEnhanceListCell(UnitEnhanceListCellType type);

		protected abstract void UpdateCell();

		public abstract void OnAutoButtonPressed();

		protected abstract bool IsAllCellComplete();

		protected abstract bool IsUsableAutoButton();

		public static T LoadUICanvas<T>(Transform parentTransform) where T : GrowthUnitEnhanceMainCanvas
		{
			return null;
		}

		public virtual void InitCanvas(GrowthUnitEnhanceScene scene, GrowthUnitEnhanceModel model)
		{
		}

		public virtual void PlayResultEffects(GrowthUnitEnhanceSendData[] sendDatas, [Optional] Action completeCallBack)
		{
		}

		public void UpdateUnitInfo()
		{
		}

		protected void UpdateUIRelatedInMaterial()
		{
		}

		protected void SendBuildupData(int builidup, Action resultAction)
		{
		}

		protected GrowthUnitEnhanceSendData[] CreateSendBuildupData(int builidup)
		{
			return null;
		}

		protected void SendLimitBreakData(int limitBreak, int useItemCount, Action resultAction)
		{
		}

		protected void SendEquipCountData(int count)
		{
		}

		protected void ShowBuildupResultPopup(int beforeBuilup, int beforePower, [Optional] Action closeActionCallBack)
		{
		}

		private void ShowEquipableCountResultPopup(int beforeCount)
		{
		}

		protected void PlayFlashTextEffect(FlashTextType textType, Action playEndCallBack)
		{
		}

		protected static UnitEnhanceListCellType GetEnhanceListCellType(BuildupPieceType pieceType)
		{
			return default(UnitEnhanceListCellType);
		}

		protected Task PlayCellEnhancementEffects(GrowthUnitEnhanceSendData[] sendDatas)
		{
			return null;
		}

		protected TouchGuardObject CreateResultEffectTouchGuard()
		{
			return null;
		}

		protected void RemoveResultEffectTouchGuard()
		{
		}
	}
}
