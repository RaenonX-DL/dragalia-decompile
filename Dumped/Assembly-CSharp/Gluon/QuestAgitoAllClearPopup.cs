/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FLATOUT.Main;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestAgitoAllClearPopup : PopupBase
	{
		// Fields
		[Header]
		[SerializeField]
		private Transform flashNode;
		[SerializeField]
		private Transform cancelButtonNode;
		[SerializeField]
		private Transform okButtonNode;
		[SerializeField]
		private Canvas okMarkCanvas;
		[SerializeField]
		private Canvas cancelMarkCanvas;
		private const string prefabPath = "Prefabs/OutGame/QuestSelect/Popup/QuestAgitoAllClearPopup";
		private const string flashPath = "Prefabs/OutGame/QuestSelect/Popup/pf_AgitoComplete";
		private const string seName = "SE_OUT_COMMON_0059";
		private Action onGoStory;
		private TouchGuardObject touchGuardObj;
		private FlRoot root;
		private UnityEngine.UI.Text clearText;
		private FlText flClearText;
		private FlObject flOkButton;
		private FlObject flCancelButton;
		private CanvasGroup okButtonCanvasGroup;
		private CanvasGroup cancelButtonCanvasGroup;
	
		// Constructors
		public QuestAgitoAllClearPopup();
	
		// Methods
		public static QuestAgitoAllClearPopup Create(Action onGoStory);
		protected override void Start();
		public void OnCloseButtonPressed();
		public void OnOKButtonPressed();
		private void Update();
		[CompilerGenerated]
		private void _Start_b__18_0();
		[CompilerGenerated]
		private void _OnCloseButtonPressed_b__19_0();
		[CompilerGenerated]
		private void _OnOKButtonPressed_b__20_0();
	}
}
