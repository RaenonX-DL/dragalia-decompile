using System;
using UnityEngine;

namespace Gluon.Dungeon.Gimmick
{
	public class DontSlipField : GimmickBase
	{
		public Action<DontSlipField, Collider> onExitAction;

		public Action<DontSlipField, Collider> onStayAction;

		private void OnTriggerExit(Collider other)
		{
		}

		private void OnTriggerStay(Collider other)
		{
		}
	}
}
