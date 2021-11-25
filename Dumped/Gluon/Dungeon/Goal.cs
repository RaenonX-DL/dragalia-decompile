using System.Collections;
using Cute.Core;
using UnityEngine;

namespace Gluon.Dungeon
{
	public class Goal : FastUpdateMonoBehaviour
	{
		[SerializeField]
		private string effectName;

		[SerializeField]
		private int kickTrigger;

		private EffectObject effect;

		private const int EffectDeleteTrigger = 1;

		private IEnumerator Start()
		{
			return null;
		}

		private void OnTriggerEnter(Collider other)
		{
		}
	}
}
