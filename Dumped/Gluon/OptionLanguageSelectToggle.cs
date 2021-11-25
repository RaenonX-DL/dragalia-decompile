using System;
using UnityEngine;
using UnityEngine.Events;

namespace Gluon
{
	public class OptionLanguageSelectToggle : CommonSettingToggleBase
	{
		[Serializable]
		public class EventLanguage : UnityEvent<Localize.Language>
		{
		}

		[SerializeField]
		public Localize.Language language;

		public EventLanguage onToggleValueChangedEvent;

		public override void OnToggleValueChanged(bool value)
		{
		}
	}
}
