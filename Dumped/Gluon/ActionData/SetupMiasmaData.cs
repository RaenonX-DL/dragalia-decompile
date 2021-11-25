using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class SetupMiasmaData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private int _actionId;

		[SerializeField]
		[HideInInspector]
		private string _effName;

		[SerializeField]
		[HideInInspector]
		private string _beginSe;

		[SerializeField]
		[HideInInspector]
		private string _endSe;

		[SerializeField]
		[HideInInspector]
		private float _addPointSpeed;

		[SerializeField]
		[HideInInspector]
		private float _waitTimeForAuto;

		public int actionId => default(int);

		public string effName => null;

		public string beginSe => null;

		public string endSe => null;

		public float addPointSpeed => default(float);

		public float waitTimeForAuto => default(float);
	}
}
