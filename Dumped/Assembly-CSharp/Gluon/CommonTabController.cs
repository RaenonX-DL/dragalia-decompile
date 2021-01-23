/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CommonTabController : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		public CommonTabButtonBase[] tabButtons;
		[Header]
		[SerializeField]
		private Sprite[] onSprites;
		[SerializeField]
		private Sprite[] offSprites;
		[Header]
		[SerializeField]
		private Color onTextColor;
		[SerializeField]
		private Color offTextColor;
		[Header]
		[SerializeField]
		private GameObject[] tabPages;
		private Action<int, bool> onTabSwitched;
	
		// Constructors
		public CommonTabController();
	
		// Methods
		public void Awake();
		public void SetTabSwitchedCallback(Action<int, bool> onTabSwitched);
		public void SwitchToTab(int index, bool callOnTabSwitched = true);
		public void SetTabDisableState(int index, bool toDisable);
		[CompilerGenerated]
		private void _Awake_b__7_0(int index, bool calledFromUI);
	}
}
