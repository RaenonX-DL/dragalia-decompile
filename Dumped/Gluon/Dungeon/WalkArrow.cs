using System.Collections;
using Cute.Core;
using UnityEngine;

namespace Gluon.Dungeon
{
	public class WalkArrow : FastUpdateMonoBehaviour
	{
		public NextArrow targetNextAllow;

		private Vector3 defaultScale;

		private bool hit;

		private const string effectName = "EFF_DUN_ETC_001_001";

		private void Awake()
		{
		}

		private IEnumerator Start()
		{
			return null;
		}

		private void OnTriggerStay(Collider other)
		{
		}

		private IEnumerator Walk(PlayerCtrl player)
		{
			return null;
		}
	}
}
