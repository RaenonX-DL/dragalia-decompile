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

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestResultRetryConfirmPopup : CommonPopup
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
		private GameObject questStaminaRoot;
		[SerializeField]
		private UnityEngine.UI.Text staminaTitle;
		[SerializeField]
		private UnityEngine.UI.Text staminaBefore;
		[SerializeField]
		private UnityEngine.UI.Text staminaAfter;
	
		// Constructors
		public QuestResultRetryConfirmPopup();
	
		// Methods
		public static QuestResultRetryConfirmPopup Create(QuestDataElement qde, UnityAction onOkCallback, UnityAction onCancelCallback, bool showBlackLayer = true);
		private void ReflectParam(QuestDataElement qde);
		public override void OnCancelButtonPressed();
	}
}
