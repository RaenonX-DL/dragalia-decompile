/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FLATOUT.Main;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestAdvancedDragonAllClearPopup : PopupBase
	{
		// Fields
		[Header]
		[SerializeField]
		public Transform flashNode;
		public Transform cancelButtonNode;
		public Transform okButtonNode;
		[SerializeField]
		private Canvas okMarkCanvas;
		[SerializeField]
		private Canvas cancelMarkCanvas;
		public const string prefabPath = "Prefabs/OutGame/QuestSelect/Popup/QuestAdvancedDragonAllClearPopup";
		public const string flashPath = "Prefabs/OutGame/QuestSelect/Popup/pf_advanced_dragon_complete";
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
		public QuestAdvancedDragonAllClearPopup();
	
		// Methods
		public static QuestAdvancedDragonAllClearPopup Create(Action onGoStory);
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
