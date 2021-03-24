/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ItemGetQuestListPopup : CommonPopup
	{
		// Fields
		private const string prefabPath = "Prefabs/OutGame/Item/ItemGetQuestListPopup";
		[SerializeField]
		private QuestDetailList questDetailList;
		[SerializeField]
		private UnityEngine.UI.Text helpText;
		private List<QuestCellData> cellDataList;
		[CompilerGenerated]
		private PopupCanvas _parentPopupCanvas_k__BackingField;
	
		// Properties
		public PopupCanvas parentPopupCanvas { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass10_0
		{
			// Fields
			public QuestCellData data;
			public ItemGetQuestListPopup __4__this;
			public UnityEvent onComplete;
			public Action __9__3;
			public UnityAction __9__2;
	
			// Constructors
			public __c__DisplayClass10_0();
	
			// Methods
			internal void _LoadSceneQuestMenu_b__0();
			internal void _LoadSceneQuestMenu_b__2();
			internal void _LoadSceneQuestMenu_b__3();
			internal void _LoadSceneQuestMenu_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass11_0
		{
			// Fields
			public CommonPopup popup;
			public ItemGetQuestListPopup __4__this;
	
			// Constructors
			public __c__DisplayClass11_0();
	
			// Methods
			internal void _CreateNoOpenPopup_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass12_0
		{
			// Fields
			public CommonPopup popup;
			public ItemGetQuestListPopup __4__this;
	
			// Constructors
			public __c__DisplayClass12_0();
	
			// Methods
			internal void _CreateNoReleasePopup_b__0();
		}
	
		// Constructors
		public ItemGetQuestListPopup();
	
		// Methods
		public static ItemGetQuestListPopup Create();
		public void InitSetting(int[] moveQuests, GiftType giftType, int itemId);
		private void LoadSceneQuestMenu(QuestCellData data);
		private void CreateNoOpenPopup(QuestCellData data);
		private void CreateNoReleasePopup(QuestCellData data);
	}
}
