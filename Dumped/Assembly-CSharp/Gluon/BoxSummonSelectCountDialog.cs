/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class BoxSummonSelectCountDialog : PopupBase
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Text summonButtonText;
		[SerializeField]
		private UnityEngine.UI.Text haveCountText;
		[SerializeField]
		private UnityEngine.UI.Text remainCountText;
		[SerializeField]
		private UnityEngine.UI.Text needCountText;
		[SerializeField]
		private Toggle skipToggle;
		[SerializeField]
		private Toggle tillResetItemToggle;
		[SerializeField]
		private UnityEngine.UI.Text tillResetItemText;
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
	
		// Properties
		private bool skipDemo { get; set; }
		private bool isTillResetItem { get; set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass27_0
		{
			// Fields
			public int eventId;
	
			// Constructors
			public __c__DisplayClass27_0();
	
			// Methods
			internal bool _SetupContents_b__0(BoxSummonDataElement item);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<BoxSummonDataElement, bool> __9__29_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _UpdateContents_b__29_0(BoxSummonDataElement item);
		}
	
		// Constructors
		public BoxSummonSelectCountDialog();
	
		// Methods
		public static int GetCanPlayCount(int maxExecCount);
		public void SetupContents(int eventPoint, int maxExecCount, int sequence);
		protected override void Start();
		private void UpdateContents();
		private bool HasResetItem();
		private void SetupCostCount();
		public void SetupSummonButton();
		private void SetupSkipCheckBox();
		private void SetNumberOfTimes(int n);
		public void OnSlideValueChanged(float value);
		public void OnMaxButton();
		private void MaximizeNumberOfTimes();
		public void OnSkipButtonToggled(bool value);
		public void OnTillResetItemButtonToggled(bool value);
		public void OnCancelButton();
		public void OnSummonButton();
	}
}
