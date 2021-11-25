using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class TabBase : MonoBehaviour
	{
		[SerializeField]
		public GameObject[] activatedObjects;

		public UnityAction<int> selectedCallback;

		[SerializeField]
		public bool shouldManageToggleSE;

		public TabButton[] tabButtons;

		private int currentActiveTabIndex;

		private ToggleGroup toggleGroup;

		private readonly string decideSound;

		private Action<int, bool> onTabSwitched;

		public int activeTabIndex => default(int);

		private void Awake()
		{
		}

		public void SetTabSwitchedCallback(Action<int, bool> onTabSwitched)
		{
		}

		public void SetCallbackAfterInitializedTheme(Action callback)
		{
		}

		private void SwitchActivePage()
		{
		}

		public void SetTabDisableState(int index, bool toDisable, bool allImage = false)
		{
		}

		public virtual void SelectTabByManual(int index, bool callOnTabSwitched = true, bool shouldPlaySE = false)
		{
		}

		public virtual void OnTabSelected(int index, bool callOnTabSwitched = true, bool shouldPlaySE = true)
		{
		}

		public void SetText(string[] nameButtons, [Optional] string[] nameActives)
		{
		}
	}
}
