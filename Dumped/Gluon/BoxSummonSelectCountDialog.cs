using System;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class BoxSummonSelectCountDialog : PopupBase
	{
		[SerializeField]
		private Text summonButtonText;

		[SerializeField]
		private Text haveCountText;

		[SerializeField]
		private Text remainCountText;

		[SerializeField]
		private Text needCountText;

		[SerializeField]
		private Toggle skipToggle;

		[SerializeField]
		private Toggle tillResetItemToggle;

		[SerializeField]
		private Text tillResetItemText;

		[SerializeField]
		private CommonSliderSelection slider;

		[SerializeField]
		private Button okButton;

		[SerializeField]
		private Button maxButton;

		[SerializeField]
		private GameObject tillResetItemObj;

		public Action<int, bool, bool> OnSummonButtonTouched;

		private int numberOfTimes;

		private int eventPoint;

		private int sequence;

		private const string prefsKeySkipBoxSummonDemo = "PlayerPrefs_SkipBoxSummonDemo";

		private const string prefsKeyTillResetItem = "PlayerPrefs_TillResetItem";

		private int costPerOnce;

		private readonly int MIN_NUMBER_OF_TIMES;

		private int maxNumber;

		private bool skipDemo
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		private bool isTillResetItem
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public static int GetCanPlayCount(int maxExecCount)
		{
			return default(int);
		}

		public void SetupContents(int eventPoint, int maxExecCount, int sequence)
		{
		}

		protected override void Start()
		{
		}

		private void UpdateContents()
		{
		}

		private bool HasResetItem()
		{
			return default(bool);
		}

		private void SetupCostCount()
		{
		}

		public void SetupSummonButton()
		{
		}

		private void SetupSkipCheckBox()
		{
		}

		private void SetNumberOfTimes(int n)
		{
		}

		public void OnSlideValueChanged(float value)
		{
		}

		public void OnMaxButton()
		{
		}

		private void MaximizeNumberOfTimes()
		{
		}

		public void OnSkipButtonToggled(bool value)
		{
		}

		public void OnTillResetItemButtonToggled(bool value)
		{
		}

		public void OnCancelButton()
		{
		}

		public void OnSummonButton()
		{
		}
	}
}
