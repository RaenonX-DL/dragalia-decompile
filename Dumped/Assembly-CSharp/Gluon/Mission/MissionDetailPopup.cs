/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using Gluon.Mission.ListView;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Mission
{
	public class MissionDetailPopup : CommonPopup
	{
		// Fields
		[Header]
		[SerializeField]
		public MissionWidgetDetail detail;
		public Action onPopupClosed;
		private TabCategory category;
		private MissionTableViewData data;
		public MissionSelectPopupBase selectPopup;
		public Action onChallengeButtonCallBack;
	
		// Constructors
		public MissionDetailPopup();
	
		// Methods
		public static new MissionDetailPopup Create(Size size = Size.S, BottomButtons bottomButtons = BottomButtons.CancelOk, bool showBlackLayer = true, bool showStartAnimation = true, bool isErrorPopupCanvas = false);
		public void Initialize(MissionTableViewData data, TabCategory category, int index);
		private void SetDuplicatedText(GiftType entityType, int entityId, int entityQuantity, Localize.TextId textId);
		public void InitializeSpan(MissionTableViewData data);
		public void InitializeDetailReward(MissionTableViewData data);
		public override void OnCloseButtonPressed();
		public override void OnCancelButtonPressed();
		public override void OnOkButtonPressed();
		private void CreateConfirmPopup();
		[CompilerGenerated]
		private void _CreateConfirmPopup_b__14_0();
	}
}
