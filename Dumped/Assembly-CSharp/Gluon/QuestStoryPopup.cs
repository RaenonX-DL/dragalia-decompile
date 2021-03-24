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
	public class QuestStoryPopup : CommonPopup
	{
		// Fields
		[SerializeField]
		public UnityEngine.UI.Text uiTitle;
		public UnityEngine.UI.Text uiMainText;
		public UnityEngine.UI.Text downloadText;
		public UnityEngine.UI.Text wifiText;
		public UnityEngine.UI.Text helpText;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass5_0
		{
			// Fields
			public UnityAction<int, QuestGroupType> OnOkCallback;
			public int questID;
			public QuestGroupType groupType;
	
			// Constructors
			public __c__DisplayClass5_0();
	
			// Methods
			internal void _Create_b__0();
		}
	
		// Constructors
		public QuestStoryPopup();
	
		// Methods
		public static QuestStoryPopup Create(int questID, QuestGroupType groupType, UnityAction<int, QuestGroupType> OnOkCallback, UnityAction OnCancelCallback, bool showBlackLayer = true);
		public void ReflectParam(int questID);
		public override void OnCancelButtonPressed();
		public void SetDownloadText(long baseByte);
	}
}
