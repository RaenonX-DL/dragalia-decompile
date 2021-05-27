/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ConfirmDialogCtrl : FacilityDialogControllerBase, ICustomMessage
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Text titleLabel;
		[SerializeField]
		private UnityEngine.UI.Text confirmLabel;
		[SerializeField]
		private UnityEngine.UI.Text contentLabel;
		[SerializeField]
		private UnityEngine.UI.Text okButtonLabel;
		[SerializeField]
		private UnityEngine.UI.Text cancelButtonLabel;
		[SerializeField]
		private UnityEngine.UI.Text materialRequiredTitle;
		[SerializeField]
		private UnityEngine.UI.Text timeRequiredTitle;
		[SerializeField]
		private UnityEngine.UI.Text buildDurationLabel;
		[SerializeField]
		private GameObject eventEffectRoot;
		[SerializeField]
		private UnityEngine.UI.Text eventTitleText;
		[SerializeField]
		private UnityEngine.UI.Text eventEffectText;
		[SerializeField]
		private FacilityNecessaryMaterialContent necessaryMaterialContent;
		[SerializeField]
		private GameObject necessaryMaterialSpacer;
		[SerializeField]
		private GameObject withoutMaterialSpacer;
		private FortScene fortScene;
		public Action<Facility> okButtonPressed;
		[SerializeField]
		public UnityEvent cancelButtonPressed;
		public ConfirmDialogType type;
		[SerializeField]
		private Button cancelButton;
		private FortModel.BuildFacilityResult buildResult;
		private Button okButton;
		private Facility nextFacility;
		[SerializeField]
		private GameObject beginnerBuildCampaignIcon;
		[SerializeField]
		private Color beginnerBuildCampaignColor;
		private bool isBeginnerBuildTime;
	
		// Nested types
		public enum ConfirmDialogType
		{
			Build = 0,
			LevelUp = 1
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static ExecuteEvents.EventFunction<FortUIEventInterface> __9__36_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _OnMessagReceived_b__36_0(FortUIEventInterface reciever, BaseEventData eventData);
		}
	
		// Constructors
		public ConfirmDialogCtrl();
	
		// Methods
		private void OnEnable();
		private void OnDisable();
		public void OnInit(ConfirmDialogType type, FortModel.BuildFacilityResult buildResult);
		public void OnOKButtonPressed();
		private void OnEndBeginnerBuildTime();
		public void OnCancelButtonPressed();
		public void OnCloseButtonPressed();
		public override bool SetContent(Facility facility, Facility nextLevelFacility = null);
		private void SetEventEffectInfo(Facility facility, Facility nextLevelFacility);
		private void SetContentInfo(Facility facility, bool isLevelUp);
		public void OnMessagReceived(CustomMessageType messageType, object data);
	}
}
