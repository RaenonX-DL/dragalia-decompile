using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestBatchRunSettingCell : MonoBehaviour
	{
		private class QuestBatchRunCellState
		{
			public bool isTarget;

			public int targetQuestId;
		}

		[SerializeField]
		[Header("MainTitle")]
		private Image mainTitleBanner;

		[SerializeField]
		private Toggle isTargetToggle;

		[SerializeField]
		private CheckBoxAnimation isTargetToggleAnimationComponent;

		[SerializeField]
		[Header("QuestDifficulty")]
		private TabBase questDifficultyTabBase;

		[SerializeField]
		private List<Text> questDifficultyTabTextList;

		[SerializeField]
		[Header("QuestElemental")]
		private GameObject questElementalPanel;

		[SerializeField]
		private List<Toggle> questElementalToggleList;

		[SerializeField]
		[Header("Campaign")]
		private CampaignButtons campaignButton;

		private QuestBatchRunCellState cellState;

		private int questEventId;

		private Dictionary<ElementalType, List<QuestMultipleSkipElement>> skipableQuestDataTable;

		private static readonly string questBatchRunSettingKeyPrefix;

		private ElementalType selectedElementalType;

		private Action onIsTargetChangedCallback;

		public bool IsTargetQuest()
		{
			return default(bool);
		}

		private bool ExistEachElementalQuest(int eventId)
		{
			return default(bool);
		}

		private void Initialize()
		{
		}

		private void UpdateUIByIsTargetToggle(bool isOn)
		{
		}

		private void EnableDifficultyTabButtons(bool isEnabled)
		{
		}

		private void UpdateDifficultyButtons()
		{
		}

		private void UpdateCellStateData()
		{
		}

		private void SetCampaignData([In] ref List<QuestMultipleSkipElement> skipableQuestDataList)
		{
		}

		public void OnIsTargetCheckBoxPressed(Toggle isTargetCheckBox)
		{
		}

		public void OnElementalTogglePressed(int elementalToggleIndex)
		{
		}

		public void AddIsTargetChangedCallback(Action callback)
		{
		}

		public void SetContents(int targetEventId, [In] ref List<QuestMultipleSkipElement> skipableQuestDataList)
		{
		}

		public void SaveSettingData()
		{
		}

		public int TakeQuestId()
		{
			return default(int);
		}
	}
}
