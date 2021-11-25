using System.Collections;
using Cute.Core;
using UnityEngine;

namespace Gluon.Dungeon
{
	public class ProximityObject : FastUpdateMonoBehaviour
	{
		[SerializeField]
		[Lock]
		private string ActionSE;

		[SerializeField]
		[Lock]
		private string ActionEffect;

		private Animator anim;

		private int idle;

		private int warming;

		private bool hasWarming;

		private float speed;

		private float endTime;

		private void Start()
		{
		}

		public override void FastUpdate()
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		private IEnumerator PlaySEAndEffect(CharacterBase chara)
		{
			return null;
		}
	}
}
