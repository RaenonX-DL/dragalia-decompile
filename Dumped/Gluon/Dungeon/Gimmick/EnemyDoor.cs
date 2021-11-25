using System.Collections;
using UnityEngine;

namespace Gluon.Dungeon.Gimmick
{
	public class EnemyDoor : SwitchDoor
	{
		[SerializeField]
		private Wall targetWall;

		[SerializeField]
		private string effectLabel;

		private static readonly int effectTriggerIdle;

		private static readonly int effectTriggerOpen;

		[SerializeField]
		private Transform effectAttachNode;

		private EffectObject effectObj;

		protected override void Start()
		{
		}

		protected IEnumerator CoExecDoor()
		{
			return null;
		}
	}
}
