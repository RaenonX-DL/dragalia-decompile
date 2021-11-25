using Gluon.Master;
using UnityEngine;

namespace Gluon.Dungeon.Gimmick
{
	public class MovePanel : GimmickBase
	{
		public GimmickMovePanelObj type;

		public Vector3 moveVec;

		private GimmickMovePanelObjElement variation;

		protected override void Awake()
		{
		}

		private void OnTriggerStay(Collider other)
		{
		}

		private void OnTriggerExit(Collider other)
		{
		}
	}
}
