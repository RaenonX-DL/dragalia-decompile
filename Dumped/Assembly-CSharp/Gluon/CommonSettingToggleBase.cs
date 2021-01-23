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
	public class CommonSettingToggleBase : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		public Toggle toggle;
		public Action<bool, bool> onToggleValueChanged;
		public Toggle.ToggleEvent onToggleClicked;
		protected bool isSettingBySystem;
		protected ToggleSound toggleSound;
	
		// Constructors
		public CommonSettingToggleBase();
	
		// Methods
		private void Awake();
		public void SetToggleState(bool value);
		public virtual void OnToggleValueChanged(bool value);
		public static int GetActiveToggle(CommonSettingToggleBase[] toggles);
	}
}
