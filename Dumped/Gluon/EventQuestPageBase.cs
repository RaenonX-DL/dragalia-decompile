using System;
using System.Collections;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class EventQuestPageBase : PageBase
	{
		public readonly Color resetButtonNormalColor;

		public readonly Color resetButtonDisableColor;

		public EventQuestScene eventQuestScene => null;

		public bool isSummonDataReady => default(bool);

		public override void OnPageBecomeActive(object data)
		{
		}

		public virtual void OnPresentReceived()
		{
		}

		public virtual void ResetSummonData()
		{
		}

		public void OnButtonResetTouched([Optional] Action okCallback, [Optional] Action closeCallback)
		{
		}

		private int GetSummonSequence()
		{
			return default(int);
		}

		public void UpdateResetButton(Button resetButton)
		{
		}

		private void ShowResetCompleteDialog(Action callback)
		{
		}

		public void ShowItemDetail(SummonResultItemData itemData, [Optional] Action onLeaving)
		{
		}

		public void SetButtonInteractable(Button button, bool f, Text text)
		{
		}

		public void ShowSelectCountDialog(Action<bool> onOkCallback, [Optional] Action onCloseCallback)
		{
		}

		public void RequestBoxSummonData(Action onComplete)
		{
		}

		public void RequestResetSummon(Action callback)
		{
		}

		protected void UpdateAfterConnection(bool isSummonResult)
		{
		}

		public override void ShowPage(bool toShow)
		{
		}

		public IEnumerator LoadSummonBgScene()
		{
			return null;
		}

		public void UnloadSummonBgScene()
		{
		}

		public static void RequestEventPointRewardData(Action onComplete)
		{
		}

		protected virtual int GetMaxExecCount()
		{
			return default(int);
		}
	}
}
