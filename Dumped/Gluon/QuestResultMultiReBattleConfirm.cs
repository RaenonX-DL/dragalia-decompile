using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestResultMultiReBattleConfirm : PopupBase
	{
		[SerializeField]
		private Text rebattleCountDownText;

		public UnityEvent onExit;

		public void SetTimer(int maxTime, DateTime startTime)
		{
		}

		private IEnumerator UpdateReBattle(int reBattleCount, DateTime rebattleStartTime)
		{
			return null;
		}

		public void OnExitPressed()
		{
		}
	}
}
