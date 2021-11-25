using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class SwitchElementData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private ElementalType _elementaType;

		[SerializeField]
		[HideInInspector]
		private bool _isSubSame;

		[SerializeField]
		[HideInInspector]
		private bool _guarantee;

		public ElementalType elementaType => default(ElementalType);

		public bool isSubSame => default(bool);

		public bool guarantee => default(bool);
	}
}
