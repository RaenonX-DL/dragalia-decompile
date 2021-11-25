using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class MultiMarkerNeedRegisterPositionData : MarkerData
	{
		public enum MultiGenerateStyle
		{
			ControlPlayers,
			AreaAnchorRandomOffsetAddAnchorPos
		}

		[SerializeField]
		[HideInInspector]
		private MultiGenerateStyle _multiGenerateStyle;

		[SerializeField]
		[HideInInspector]
		private float _generateRangeMin;

		[SerializeField]
		[HideInInspector]
		private float _generateRangeMax;

		[SerializeField]
		[HideInInspector]
		private bool _isGenerateRangeRandom;

		[SerializeField]
		[HideInInspector]
		private int _generateNum;

		[SerializeField]
		[HideInInspector]
		private Vector3 _generateOffsetPos;

		public MultiGenerateStyle multiGenerateStyle => default(MultiGenerateStyle);

		public float generateRangeMin => default(float);

		public float generateRangeMax => default(float);

		public bool isGenerateRangeRandom => default(bool);

		public int generateNum => default(int);

		public Vector3 generateOffsetPos => default(Vector3);
	}
}
