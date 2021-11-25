using System;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class RaidEventDailyMissionPopup : PopupBase
	{
		[SerializeField]
		public CommonIcon icon;

		public RubySupportedText conditionText;

		public RubySupportedText conditionSubText;

		public Toggle doNotDisturbCheck;

		private Action onMissionButtonPressed;

		private Action<bool> onClose;

		public static RaidEventDailyMissionPopup Create(MissionDailyDataElement elem, Action onMissionButtonPressed, Action<bool> onClose)
		{
			return null;
		}

		public void Setup(MissionDailyDataElement elem)
		{
		}

		public void OnCheckMissionButtonPressed()
		{
		}

		public void OnCloseButtonPressed()
		{
		}
	}
}
