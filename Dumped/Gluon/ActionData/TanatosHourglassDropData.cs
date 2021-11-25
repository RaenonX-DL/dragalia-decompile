using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class TanatosHourglassDropData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private int _positionNum;

		[SerializeField]
		[HideInInspector]
		private Vector3[] _positions;

		public int positionNum => default(int);

		public Vector3[] positions => null;
	}
}
