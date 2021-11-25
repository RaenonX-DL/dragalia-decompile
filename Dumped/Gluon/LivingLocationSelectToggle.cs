using System;
using UnityEngine;
using UnityEngine.Events;

namespace Gluon
{
	public class LivingLocationSelectToggle : CommonSettingToggleBase
	{
		[Serializable]
		public class EventLocation : UnityEvent<LocalizeUtil.LocationCode>
		{
		}

		[SerializeField]
		public LocalizeUtil.LocationCode location;

		public EventLocation onToggleValueChangedEvent;

		public override void OnToggleValueChanged(bool value)
		{
		}
	}
}
