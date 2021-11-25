using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gluon.Dungeon
{
	public class BossDropItemBox : DropItemBox
	{
		private enum EffectType
		{
			Normal,
			Rare,
			Gorgeous
		}

		private List<DropItemUI.Parameter> paramList;

		public int popPriority;

		private EffectType effectType;

		private BossDropItemBoxCtrl ctrl;

		private bool isStartOpenTimer;

		private float openTimer;

		protected override void Start()
		{
		}

		public override void FastUpdate()
		{
		}

		public void SetDropItem(DropItemUI.Parameter param)
		{
		}

		public void SetDisplay(Vector3 position, float rotY)
		{
		}

		protected void OnOpenBossItemBox()
		{
		}

		protected override IEnumerator DropItem(GameObject target)
		{
			return null;
		}
	}
}
