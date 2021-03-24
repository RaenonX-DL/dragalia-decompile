/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine.Events;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestCellData
	{
		// Fields
		[CompilerGenerated]
		private int _questId_k__BackingField;
		[CompilerGenerated]
		private QuestType _questType_k__BackingField;
		[CompilerGenerated]
		private QuestDataElement _questData_k__BackingField;
		[CompilerGenerated]
		private QuestStoryElement _storyData_k__BackingField;
		[CompilerGenerated]
		private QuestMainGroupElement _mainGroupElement_k__BackingField;
		[CompilerGenerated]
		private QuestEventGroupElement _eventGroupElement_k__BackingField;
		[CompilerGenerated]
		private QuestWallElement _questWallData_k__BackingField;
		private QuestMainMenuElement _mainMenuElement;
		private QuestEventMenuElement _eventMenuElement;
		private QuestSelectScene.Difficulty _difficulty;
		private QuestMainLocationElement _locationElement;
		public string triggerString;
		public bool isOpen;
		public bool isClear;
		public UnityAction<QuestCellData> pressedCallback;
		public UnityAction<QuestCellData> disableToJoinCallback;
		public QuestUtil.QuestState state;
	
		// Properties
		public int questId { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public QuestType questType { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public QuestDataElement questData { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public QuestStoryElement storyData { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public QuestMainGroupElement mainGroupElement { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public QuestEventGroupElement eventGroupElement { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public QuestWallElement questWallData { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public QuestMainMenuElement mainMenuElement { get; set; }
		public QuestEventMenuElement eventMenuElement { get; set; }
		public QuestSelectScene.Difficulty difficulty { get; set; }
		public QuestMainLocationElement locationElement { get; set; }
	
		// Constructors
		public QuestCellData(int questId);
		public QuestCellData(int questId, QuestUtil.QuestState questState);
		public QuestCellData(QuestEventMenuElement eventMenuElement, QuestUtil.QuestState questState);
		public QuestCellData(int locationId, QuestSelectScene.Difficulty questDifficulty);
		public QuestCellData(List<QuestEventMenuElement> eventMenuElementList);
	
		// Methods
		public void Init(int questId, QuestUtil.QuestState questState = QuestUtil.QuestState.None);
		public void InitWall(QuestEventMenuElement eventMenuElement, QuestUtil.QuestState questState = QuestUtil.QuestState.None);
		private void GetQuestState();
	}
}
