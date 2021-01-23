/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[SerializeField]
	public class TabViewBase : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private Image[] tabOnImages;
		[SerializeField]
		private Button[] tabOffButtons;
		[SerializeField]
		private UnityEngine.UI.Text[] buttonTexts;
		[SerializeField]
		public GameObject[] tabContents;
		[CompilerGenerated]
		private string _tabViewName_k__BackingField;
		[CompilerGenerated]
		private int _curIndex_k__BackingField;
		private int previousIndex;
		[SerializeField]
		private Color textColorOn;
		[SerializeField]
		private Color textColorOff;
		public Action<int, int> onTabChanged;
	
		// Properties
		public string tabViewName { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int curIndex { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Constructors
		public TabViewBase();
	
		// Methods
		protected void OnEnable();
		protected void OnDisable();
		public void SelectTab(int tabIndex);
		public void SetTabName(string tabName);
		public void SetTabButtonEnableColor(int tabIndex, bool enable);
		public void SetTabButtonText(int tabIndex, string text);
	}
}
