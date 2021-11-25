using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class MultiEffectData : EffectData
	{
		public enum GenerateStyle
		{
			LineForward,
			LineBack,
			LineLeft,
			LineRight
		}

		[SerializeField]
		[HideInInspector]
		private GenerateStyle _generateStyle;

		[SerializeField]
		[HideInInspector]
		private Vector3 _generateOffset;

		[SerializeField]
		[HideInInspector]
		private int _generateNum;

		[SerializeField]
		[HideInInspector]
		private float _generateDelay;

		[SerializeField]
		[HideInInspector]
		private float _spaceDistance;

		public GenerateStyle generateStyle => default(GenerateStyle);

		public Vector3 generateOffset => default(Vector3);

		public int generateNum => default(int);

		public float generateInterval => default(float);

		public float spaceDistance => default(float);
	}
}
