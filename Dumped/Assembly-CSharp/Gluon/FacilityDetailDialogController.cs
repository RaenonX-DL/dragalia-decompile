/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class FacilityDetailDialogController : FacilityDialogControllerBase
	{
		// Fields
		private DialogType dialogType;
		[SerializeField]
		private Button cancelButton;
		[SerializeField]
		private Button okButton;
		[SerializeField]
		private UnityEngine.UI.Text titleText;
		[SerializeField]
		private UnityEngine.UI.Text infoText;
		[SerializeField]
		private GameObject infoOnlyOffset;
		[SerializeField]
		private GameObject buildDurationRoot;
		[SerializeField]
		private UnityEngine.UI.Text buildDurationLabel;
		[SerializeField]
		private GameObject buildDurationOnlyOffset;
		[SerializeField]
		private GameObject maxIncomeTimeRoot;
		[SerializeField]
		private GameObject eventEffectRoot;
		[SerializeField]
		private UnityEngine.UI.Text eventTitleText;
		[SerializeField]
		private UnityEngine.UI.Text eventEffectText;
		[SerializeField]
		private Button gotoFortButton;
		[SerializeField]
		private UnityEngine.UI.Text gotoFortButtonText;
		private FacilityViewController facilityCtrl;
		private const int frameSizeWithEventEffect = 900;
		public Action onDialogClosed;
		private UpdateType curUpdateType;
		private FortBuildGaugeController fortBuildGaugeController;
		private readonly Vector3 leftButtonPos;
		private const float mainFacilityTextSpace = 40f;
	
		// Nested types
		public enum DialogType
		{
			FacilityDetail = 0,
			BuildCancelConfirm = 1,
			LevelUpCancelConfirm = 2,
			ToStoreConfirm = 3
		}
	
		private enum UpdateType
		{
			None = 0,
			BuildDuration = 1,
			PassedIncomeTime = 2
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action __9__29_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _onGotoFortButtonTouched_b__29_0();
		}
	
		// Constructors
		public FacilityDetailDialogController();
	
		// Methods
		protected override void Start();
		private void Update();
		private void CloseDialog();
		public void SetContent(FacilityViewController facilityVC, DialogType type, bool showGotoFortButton = false);
		public void SetContent(Facility facility, DialogType type, bool showGotoFortButton = false);
		public void onGotoFortButtonTouched();
		private void SetCancelButtonPosLeft();
		public void AddOnOkButtonCallback(UnityAction callBack);
		[CompilerGenerated]
		private void _Start_b__24_0();
		[CompilerGenerated]
		private void _Start_b__24_1();
	}
}
