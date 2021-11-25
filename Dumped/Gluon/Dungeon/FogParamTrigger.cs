using System;
using System.Collections;
using UnityEngine;

namespace Gluon.Dungeon
{
	public class FogParamTrigger : CommonObjectStatus
	{
		[Serializable]
		public class FogData
		{
			public float waitSec;

			public Color fogColor;

			public float startValue;

			public float endValue;
		}

		private BoxCollider hitCollider;

		private PlayerCtrl prevPlayerCtrl;

		protected static Coroutine progressCoroutine;

		protected static MonoBehaviour lastCoroutineStarter;

		[SerializeField]
		private FogData fogDataIn;

		protected override void Awake()
		{
		}

		public override void FastUpdate()
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		protected virtual void StartFadeIn()
		{
		}

		private IEnumerator ChangeFogParam(FogData fogDataNext)
		{
			return null;
		}
	}
}
