/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class LivingLocationSelectToggle : CommonSettingToggleBase
	{
		// Fields
		[SerializeField]
		public LocalizeUtil.LocationCode location;
		public EventLocation onToggleValueChangedEvent;
	
		// Nested types
		[Serializable]
		public class EventLocation : UnityEvent<LocalizeUtil.LocationCode>
		{
			// Constructors
			public EventLocation();
		}
	
		// Constructors
		public LivingLocationSelectToggle();
	
		// Methods
		public override void OnToggleValueChanged(bool value);
	}
}
