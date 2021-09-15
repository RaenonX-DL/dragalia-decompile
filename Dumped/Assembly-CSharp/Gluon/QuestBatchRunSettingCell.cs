/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestBatchRunSettingCell : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		private Image mainTitleBanner;
		[SerializeField]
		private Toggle isTargetToggle;
		[SerializeField]
		private CheckBoxAnimation isTargetToggleAnimationComponent;
		[Header]
		[SerializeField]
		private TabBase questDifficultyTabBase;
		[SerializeField]
		private List<UnityEngine.UI.Text> questDifficultyTabTextList;
		[Header]
		[SerializeField]
		private GameObject questElementalPanel;
		[SerializeField]
		private List<Toggle> questElementalToggleList;
		[Header]
		[SerializeField]
		private CampaignButtons campaignButton;
		private QuestBatchRunCellState cellState;
		private int questEventId;
		private Dictionary<ElementalType, List<QuestMultipleSkipElement>> skipableQuestDataTable;
		private static readonly string questBatchRunSettingKeyPrefix;
		private ElementalType selectedElementalType;
		private Action onIsTargetChangedCallback;
	
		// Nested types
		private class QuestBatchRunCellState
		{
			// Fields
			public bool isTarget;
			public int targetQuestId;
	
			// Constructors
			public QuestBatchRunCellState();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass25_0
		{
			// Fields
			public Action callback;
	
			// Constructors
			public __c__DisplayClass25_0();
	
			// Methods
			internal void _AddIsTargetChangedCallback_b__0();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<QuestMultipleSkipElement, int> __9__26_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _SetContents_b__26_1(QuestMultipleSkipElement value);
		}
	
		// Constructors
		public QuestBatchRunSettingCell();
		static QuestBatchRunSettingCell();
	
		// Methods
		public bool IsTargetQuest();
		private bool ExistEachElementalQuest(int eventId);
		private void Initialize();
		private void UpdateUIByIsTargetToggle(bool isOn);
		private void EnableDifficultyTabButtons(bool isEnabled);
		private void UpdateDifficultyButtons();
		private void UpdateCellStateData();
		private void SetCampaignData([IsReadOnly] in List<QuestMultipleSkipElement> skipableQuestDataList);
		public void OnIsTargetCheckBoxPressed(Toggle isTargetCheckBox);
		public void OnElementalTogglePressed(int elementalToggleIndex);
		public void AddIsTargetChangedCallback(Action callback);
		public void SetContents(int targetEventId, [IsReadOnly] in List<QuestMultipleSkipElement> skipableQuestDataList);
		public void SaveSettingData();
		public int TakeQuestId();
		[CompilerGenerated]
		private bool _Initialize_b__17_0(QuestMultipleSkipElement data);
		[CompilerGenerated]
		private void _Initialize_b__17_1();
		[CompilerGenerated]
		private void _SetContents_b__26_0(Material mat);
	}
}
