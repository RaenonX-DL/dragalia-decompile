/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestInstructorBonusDetailPopup : PopupBase
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Text charaNameText;
		[SerializeField]
		private UnityEngine.UI.Text charaText;
		[SerializeField]
		private QuestInstructorBonusDetailTargetRewardTableViewController tableView;
		[SerializeField]
		private ButtonWithSelectedImage howtoButtonWithSelectedImage;
		private const int eventPopId = 21099;
		private const int eventPopCount = 2;
		private static readonly string EventPrologueName;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Comparison<QuestInstructorBonusDetailTargetReward> __9__8_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _SetContent_b__8_0(QuestInstructorBonusDetailTargetReward a, QuestInstructorBonusDetailTargetReward b);
		}
	
		// Constructors
		public QuestInstructorBonusDetailPopup();
		static QuestInstructorBonusDetailPopup();
	
		// Methods
		public static QuestInstructorBonusDetailPopup Create();
		public void SetContent();
		public static bool IsQuestCarryQuestData(int eventId);
		public void OnClickEventInfo();
		[CompilerGenerated]
		private void _OnClickEventInfo_b__10_0();
	}
}
