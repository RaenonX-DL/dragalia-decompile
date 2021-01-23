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
	public class OptionBgmSelectToggle : CommonSettingToggleBase
	{
		// Fields
		public int bgmId;
		public UnityEngine.UI.Text bgmTitle;
		[SerializeField]
		private BgmToggleChangeEvent onToggleValueChangedEvent;
	
		// Nested types
		[Serializable]
		public class BgmToggleChangeEvent : UnityEvent<int>
		{
			// Constructors
			public BgmToggleChangeEvent();
		}
	
		// Constructors
		public OptionBgmSelectToggle();
	
		// Methods
		public override void OnToggleValueChanged(bool value);
	}
}
