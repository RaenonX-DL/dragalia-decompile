using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class SalvationBubbleData : ActionParts.PartsData
	{
		public enum BubbleState
		{
			Appear,
			Dilation,
			Revert,
			Deflate,
			NUM
		}

		[SerializeField]
		[HideInInspector]
		private float _safeAreaRadius;

		[SerializeField]
		[HideInInspector]
		private string _effectName;

		[SerializeField]
		[HideInInspector]
		private string _controlKey;

		[SerializeField]
		[HideInInspector]
		private int[] _stateEffTrig;

		[SerializeField]
		[HideInInspector]
		private string[] _stateSeName;

		public float safeAreaRadius => default(float);

		public string effectName => null;

		public string controlKey => null;

		public int[] stateEffTrig => null;

		public string[] stateSeName => null;
	}
}
