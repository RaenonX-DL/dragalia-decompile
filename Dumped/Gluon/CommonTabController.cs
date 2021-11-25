using System;
using UnityEngine;

namespace Gluon
{
	public class CommonTabController : MonoBehaviour
	{
		[SerializeField]
		[Header("TabButtons")]
		public CommonTabButtonBase[] tabButtons;

		[SerializeField]
		[Header("OnOffSprites")]
		private Sprite[] onSprites;

		[SerializeField]
		private Sprite[] offSprites;

		[SerializeField]
		[Header("TextColors")]
		private Color onTextColor;

		[SerializeField]
		private Color offTextColor;

		[SerializeField]
		[Header("PageOnOffs")]
		private GameObject[] tabPages;

		private Action<int, bool> onTabSwitched;

		public void Awake()
		{
		}

		public void SetTabSwitchedCallback(Action<int, bool> onTabSwitched)
		{
		}

		public void SwitchToTab(int index, bool callOnTabSwitched = true)
		{
		}

		public void SetTabDisableState(int index, bool toDisable)
		{
		}
	}
}
