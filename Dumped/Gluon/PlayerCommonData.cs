using System;
using UnityEngine;

namespace Gluon
{
	[Serializable]
	public class PlayerCommonData
	{
		[SerializeField]
		[Tooltip("ç§»å\u008b\u0095é\u0096\u008bå§\u008bæ\u0099\u0082ã\u0081®æ»\u0091ã\u0082\u008aä¿\u0082æ\u0095°ã\u0081®é\u0081·ç§»")]
		private AnimationCurve _slipMoveCurve;

		[SerializeField]
		[Tooltip("å\u0088\u0087ã\u0082\u008aè¿\u0094ã\u0081\u0097æ\u0099\u0082ã\u0081®æ»\u0091ã\u0082\u008aä¿\u0082æ\u0095°ã\u0081®é\u0081·ç§»")]
		private AnimationCurve _slipTurnCurve;

		[SerializeField]
		[Tooltip("å\u0088\u0087ã\u0082\u008aè¿\u0094ã\u0081\u0097æ\u0099\u0082ã\u0081®æ»\u0091ã\u0082\u008aæ\u0099\u0082é\u0096\u0093")]
		private float _slipTurnTime;

		public AnimationCurve SlipMoveCurve => null;

		public AnimationCurve SlipTurnCurve => null;

		public float SlipTurnTime => default(float);
	}
}
