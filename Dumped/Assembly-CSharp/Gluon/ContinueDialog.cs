/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ContinueDialog : InGameDialogBase
	{
		// Fields
		[Header]
		[SerializeField]
		protected RectTransform frameRt;
		[SerializeField]
		protected RectTransform stoneInfoRt;
		[SerializeField]
		protected RectTransform diaInfoRt;
		[SerializeField]
		protected Image frame;
		[SerializeField]
		protected UnityEngine.UI.Text title;
		[SerializeField]
		protected UnityEngine.UI.Text text;
		[SerializeField]
		protected UnityEngine.UI.Text remainCountText;
		[SerializeField]
		protected GameObject buttonBase;
		[SerializeField]
		protected UnityEngine.UI.Text retireButtonText;
		[SerializeField]
		protected UnityEngine.UI.Text retryButtonText;
		[SerializeField]
		protected UnityEngine.UI.Text stoneNumText;
		[SerializeField]
		protected UnityEngine.UI.Text stoneUseNumText;
		[SerializeField]
		protected UnityEngine.UI.Text diaNumText;
		[SerializeField]
		protected UnityEngine.UI.Text diaUseNumText;
		[SerializeField]
		protected Button retireButton;
		[SerializeField]
		protected Button retryButton;
		[SerializeField]
		protected Button stoneButton;
		[SerializeField]
		protected Button diaButton;
		[SerializeField]
		protected Button cameraButton;
		protected Action<ContinueDialog> retryButtonFunction;
		protected Action<ContinueDialog> retireButtonFunction;
		protected Action<ContinueDialog> continueButtonFunction;
		private RectTransform rootRt;
		private Param param;
		private CommonDialog _commonDialog;
		private CommonDialog.Param _commonDialogParam;
		private RetireConfirmDialog _retireConfirmDialog;
		private RetireConfirmDialog.Param _retireConfirmDialogParam;
		private ContinueCameraDialog _continueCameraDialog;
		private ContinueCameraDialog.Param _continueCameraDialogParam;
		private ContinueConfirmDialog _continueConfirmDialog;
		private ContinueConfirmDialog.Param _continueConfirmDialogParam;
		private static readonly Color defaultTextColor;
		private static readonly Color limitedTextColor;
		private const float brTextPosY = 100f;
	
		// Nested types
		public class Param
		{
			// Fields
			public Action<ContinueDialog> retryButtonFunction;
			public Action<ContinueDialog> retireButtonFunction;
			public Action<ContinueDialog> continueButtonFunction;
	
			// Constructors
			public Param();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action __9__62_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _OnDungeonRetryCallback_b__62_0();
		}
	
		// Constructors
		public ContinueDialog();
		static ContinueDialog();
	
		// Methods
		public static ContinueDialog Create(GameObject parent);
		protected virtual void Initialize();
		private void OnDestroy();
		public void Update();
		public void Open(Param param);
		public void Close();
		public void CloseAll();
		public bool IsCloseAll();
		public void OnRetryButtonPressed();
		public void OnRetireButtonPressed();
		private void ExecRetireButtonPressed();
		public void OnCrystalButtonPressed();
		public void OnDiamondButtonPressed();
		public void OnCameraButtonPressed();
		private void OnRetryButtonPressedFromRetireConfirmDialog(RetireConfirmDialog sender);
		private void OnRetireButtonPressedFromRetireConfirmDialog(RetireConfirmDialog sender);
		private void OnCancelButtonPressedFromRetireConfirmDialog(RetireConfirmDialog sender);
		private void OnRetryButtonPressedFromMultiRetireConfirmDialog(RetireConfirmDialog sender);
		private void OnCancelButtonPressedFromMultiRetireConfirmDialog(RetireConfirmDialog sender);
		private void OnBackButtonPressedFromContinueCameraDialog(ContinueCameraDialog sender);
		private bool IsEnablePress();
		private void SetEnableButtons(bool b);
		private void OpenContinueConfirmDialog(bool isCrystal);
		private void OnCancelButtonPressedFromContinueConfirmDialog(ContinueConfirmDialog sender);
		private void OnConsumeCrystalButtonPressedFromContinueConfirmDialog(ContinueConfirmDialog sender);
		private void OnConsumeDragonDiamondButtonPressedFromContinueConfirmDialog(ContinueConfirmDialog sender);
		private void OnDungeonRetryCallback(DungeonRetryResponse res);
		private void OpenPurchaseDragonDiamondDialog();
		private void OnCancelButtonPressedFromPurchaseDragonDiamondDialog(CommonDialog sender);
		private void OnPurchaseButtonPressedFromPurchaseDragonDiamondDialog(CommonDialog sender);
		private void OnCancelButtonPressedFromPurchaseStonePopup();
		private void OnPurchaseButtonPressedFromPurchaseStonePopup();
		private void OpenContinueLimitInfoDialog();
		private void OnCloseButtonPressedFromContinuelimitInfoDialog(CommonDialog dlg);
		[CompilerGenerated]
		private void _Initialize_b__37_0();
		[CompilerGenerated]
		private void _Open_b__40_0();
		[CompilerGenerated]
		private void _Close_b__41_0();
		[CompilerGenerated]
		private void _OnConsumeCrystalButtonPressedFromContinueConfirmDialog_b__60_0();
		[CompilerGenerated]
		private void _OnConsumeDragonDiamondButtonPressedFromContinueConfirmDialog_b__61_0();
	}
}
