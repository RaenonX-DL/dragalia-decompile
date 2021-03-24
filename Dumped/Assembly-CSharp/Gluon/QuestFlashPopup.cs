/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FLATOUT.Main;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestFlashPopup : CommonPopup
	{
		// Fields
		public static readonly string questFlashPopupPath;
		private FlRoot flashRoot;
		private FlText flText;
		private FlPlane flPlane;
		private Image elementImage;
		private UnityEngine.UI.Text nameText;
		private FlText flDetailText;
		private UnityEngine.UI.Text detailText;
		private const string seGroupName = "OUT_COMMON";
		private const string seName = "SE_OUT_COMMON_0058";
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass11_0
		{
			// Fields
			public string flashPath;
			public QuestFlashPopup __4__this;
			public UnityAction<FlRoot> action;
	
			// Constructors
			public __c__DisplayClass11_0();
	
			// Methods
			internal void _SetContent_b__0(UnityEngine.Object obj);
		}
	
		// Constructors
		public QuestFlashPopup();
		static QuestFlashPopup();
	
		// Methods
		public static QuestFlashPopup Create(string flashPath, UnityAction<FlRoot> action = null);
		public void SetContent(string flashPath, UnityAction<FlRoot> action = null);
		public static QuestFlashPopup CreateQuestWallComplete(string flashPath, ElementalType elementType, string name, string detail);
		public void SetContent(string flashPath, ElementalType elementType, string name, string detail);
		private void Update();
		public void OnInAnimation();
		public void OnOutAnimation();
		public void OnClose();
	}
}
