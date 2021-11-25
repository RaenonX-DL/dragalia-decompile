using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class ResistClearData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		protected bool _isResistClear;

		public bool isResistClear => default(bool);
	}
}
