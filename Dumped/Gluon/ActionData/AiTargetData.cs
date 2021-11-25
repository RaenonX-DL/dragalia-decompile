using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class AiTargetData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private ActionTarget _targetType;

		public ActionTarget targetType => default(ActionTarget);
	}
}
