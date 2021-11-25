using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon
{
	public class ActionMoveGravity : ActionBase
	{
		private Vector3 startPos;

		private Vector3 positPrevPos;

		private Vector3 dir;

		private float speed;

		private float coef;

		private float elapsedTime;

		private const float checkInterval = 0.2f;

		private float checkTimer;

		private Vector3 safePosition;

		private ActionMoveExecution moveExec;

		public float gravity
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public float radian
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public void Setup(float gravity, float angle, float height, float coef, bool isCtrl = false)
		{
		}

		public void SetDirection(Vector3 dir)
		{
		}

		public bool UpdatePosition(float delta, out Vector3 targetPos, bool updateOnlyY = false)
		{
			return default(bool);
		}

		private Vector3 CalcPosition(float time)
		{
			return default(Vector3);
		}

		private bool CheckGround(Vector3 pos)
		{
			return default(bool);
		}
	}
}
