using System.Collections.Generic;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestBatchRunPopup : PopupBase
	{
		[SerializeField]
		private Transform cellParent;

		[SerializeField]
		private Text emptyQuestText;

		[SerializeField]
		private Button okButton;

		private List<QuestBatchRunSettingCell> cells;

		private UnityEvent okButtonPressedCallback;

		private UnityEvent closePopupCallback;

		private static readonly string cellPrefabPath;

		private static readonly string popupPrefabPath;

		public static QuestBatchRunPopup Create(List<int> targetEventIdList)
		{
			return null;
		}

		private void Initialize(List<int> targetEventIdList)
		{
		}

		public List<int> TakeTargetQuestIdList()
		{
			return null;
		}

		public void AddClosePopupCallback(UnityAction callback)
		{
		}

		public void OnCloseButtonPressed()
		{
		}

		public void AddOkButtonPressedCallback(UnityAction callback)
		{
		}

		public void OnOkButtonPressed()
		{
		}

		private bool CalculateIsRecievedDailyBonus(int eventId)
		{
			return default(bool);
		}

		private List<QuestMultipleSkipElement> CreateSkipableQuestDataList(int eventId)
		{
			return null;
		}

		public void UpdateOkButtonState()
		{
		}
	}
}
