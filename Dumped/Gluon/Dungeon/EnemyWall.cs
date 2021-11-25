using UnityEngine;

namespace Gluon.Dungeon
{
	public class EnemyWall : Wall
	{
		protected enum WallSize
		{
			Small,
			Long
		}

		[SerializeField]
		protected WallSize _wallSize;

		protected override void DrawModelOpen(bool isOpenFlag)
		{
		}

		protected override void OnTriggerEvent()
		{
		}
	}
}
