using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	[SerializeField]
	public class TabViewBase : MonoBehaviour
	{
		[SerializeField]
		private Image[] tabOnImages;

		[SerializeField]
		private Button[] tabOffButtons;

		[SerializeField]
		private Text[] buttonTexts;

		[SerializeField]
		public GameObject[] tabContents;

		private int previousIndex;

		[SerializeField]
		private Color textColorOn;

		[SerializeField]
		private Color textColorOff;

		public Action<int, int> onTabChanged;

		public string tabViewName
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int curIndex
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		protected void OnEnable()
		{
		}

		protected void OnDisable()
		{
		}

		public void SelectTab(int tabIndex)
		{
		}

		public void SetTabName(string tabName)
		{
		}

		public void SetTabButtonEnableColor(int tabIndex, bool enable)
		{
		}

		public void SetTabButtonText(int tabIndex, string text)
		{
		}
	}
}
