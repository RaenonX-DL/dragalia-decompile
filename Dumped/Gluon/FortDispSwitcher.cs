using System.Collections.Generic;
using Cute.Core;
using UnityEngine;

namespace Gluon
{
	public class FortDispSwitcher : FastUpdateMonoBehaviour
	{
		public enum SwitchTarget
		{
			GameObject,
			Renderer
		}

		public enum SwitchType
		{
			ByDistanceFromCamera
		}

		[SerializeField]
		private SwitchTarget switchTarget;

		[SerializeField]
		private GameObject[] targets;

		[SerializeField]
		private SwitchType switchType;

		[SerializeField]
		private float distanceFromCamera;

		private List<Renderer> rendererList;

		private bool isInit;

		private bool isDisp;

		private Transform cachedCamTrans;

		private float thresholdValueByDistanceFromCamera;

		private void Initialize()
		{
		}

		public override void FastUpdate()
		{
		}
	}
}
