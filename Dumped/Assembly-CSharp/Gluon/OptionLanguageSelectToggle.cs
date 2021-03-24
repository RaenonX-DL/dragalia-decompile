/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class OptionLanguageSelectToggle : CommonSettingToggleBase
	{
		// Fields
		[SerializeField]
		public Localize.Language language;
		public EventLanguage onToggleValueChangedEvent;
	
		// Nested types
		[Serializable]
		public class EventLanguage : UnityEvent<Localize.Language>
		{
			// Constructors
			public EventLanguage();
		}
	
		// Constructors
		public OptionLanguageSelectToggle();
	
		// Methods
		public override void OnToggleValueChanged(bool value);
	}
}
