/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[RequireComponent]
	public class TabBase : MonoBehaviour
	{
		// Fields
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
	
		// Properties
		public int activeTabIndex { get; }
	
		// Constructors
		public TabBase();
	
		// Methods
		private void Awake();
		public void SetTabSwitchedCallback(Action<int, bool> onTabSwitched);
		public void SetCallbackAfterInitializedTheme(Action callback);
		private void SwitchActivePage();
		public void SetTabDisableState(int index, bool toDisable, bool allImage = false);
		public virtual void SelectTabByManual(int index, bool callOnTabSwitched = true, bool shouldPlaySE = false);
		public virtual void OnTabSelected(int index, bool callOnTabSwitched = true, bool shouldPlaySE = true);
		public void SetText(string[] nameButtons, string[] nameActives = null);
	}
}
