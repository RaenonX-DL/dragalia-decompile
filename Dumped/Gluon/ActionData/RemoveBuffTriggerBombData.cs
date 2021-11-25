using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class RemoveBuffTriggerBombData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private int _targetActionConditionId;

		[SerializeField]
		[HideInInspector]
		private string _hitAttrLabel;

		[SerializeField]
		[HideInInspector]
		private bool _useSameComponent;

		[SerializeField]
		[HideInInspector]
		private string _effectName;

		[SerializeField]
		[HideInInspector]
		private string _seName;

		public int targetActionConditionId => default(int);

		public string hitAttrLabel => null;

		public bool useSameComponent => default(bool);

		public string effectName => null;

		public string seName => null;
	}
}
