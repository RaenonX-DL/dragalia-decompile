using UnityEngine;
using UnityEngine.AI;

namespace Gluon.Dungeon.Gimmick
{
	public class DoorBase : GimmickBase
	{
		protected Animator anim;

		protected Collider coll;

		protected NavMeshObstacle navObs;

		protected virtual void Start()
		{
		}

		public virtual void Open()
		{
		}

		public virtual void Close()
		{
		}

		protected virtual void PlayMotion(string motionName)
		{
		}

		protected virtual void SetCollider(bool enableFlag)
		{
		}
	}
}
