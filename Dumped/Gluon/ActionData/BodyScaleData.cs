using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class BodyScaleData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private AnimationCurve _scaleCurve;

		public AnimationCurve scaleCurve => null;
	}
}
