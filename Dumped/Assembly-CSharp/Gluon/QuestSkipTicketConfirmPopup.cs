/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestSkipTicketConfirmPopup : CommonPopup
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Text questItemTitle;
		[SerializeField]
		private UnityEngine.UI.Text questItemBefore;
		[SerializeField]
		private UnityEngine.UI.Text questItemAfter;
		[SerializeField]
		private GameObject questItemRoot;
		[SerializeField]
		private UnityEngine.UI.Text staminaTitle;
		[SerializeField]
		private UnityEngine.UI.Text staminaBefore;
		[SerializeField]
		private UnityEngine.UI.Text staminaAfter;
		[SerializeField]
		private UnityEngine.UI.Text skipTicketRequiredNum;
		[SerializeField]
		private UnityEngine.UI.Text skipTicketIconTitle;
		[SerializeField]
		private UnityEngine.UI.Text skipTicketBefore;
		[SerializeField]
		private UnityEngine.UI.Text skipTicketAfter;
		[SerializeField]
		private CommonSliderSelection ticketCountSlider;
		[SerializeField]
		private int ticketUseMaxNum;
		[SerializeField]
		private UnityEngine.UI.Text staminaShortageText;
		private QuestDataElement questDataElement;
	
		// Constructors
		public QuestSkipTicketConfirmPopup();
	
		// Methods
		public static QuestSkipTicketConfirmPopup Create(QuestDataElement qde, UnityAction onOkCallback, UnityAction onCancelCallback, bool showBlackLayer = true);
		protected override void Start();
		private void ReflectParam(QuestDataElement qde);
		private void SetAfterValue();
		public override void OnCancelButtonPressed();
		public void OnMaxPressed();
		public int GetUseTicketNum();
		private int GetUseTicketMaxNum();
		private void RefreshSliderInfo();
		[CompilerGenerated]
		private void _Start_b__16_0(float value);
	}
}
