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
	public class GrowthWeaponSeriesCell : MonoBehaviour
	{
		// Fields
		public Image seriesImage;
		public Badge badgeIcon;
		public Action<int> cellPressCallBack;
		public GameObject blackMaskObject;
		public GameObject lockIconObject;
		private int cellIndex;
		private int seriesLockType;
		private string conditionString;
		private const int originSeriesId = 1;
		private const int kimairaSeriesId = 5;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass12_0
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass12_0();
	
			// Methods
			internal void _OnCellPressed_b__0();
		}
	
		// Constructors
		public GrowthWeaponSeriesCell();
	
		// Methods
		public void InitCell(int index);
		public void UpdateCell();
		public void OnCellPressed();
		public void SetTutorialLock();
		private bool IsClearLockCondition(int lockType);
	}
}
