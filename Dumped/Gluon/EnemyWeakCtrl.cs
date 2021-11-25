using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;

namespace Gluon
{
	public class EnemyWeakCtrl : FastUpdateMonoBehaviour
	{
		protected EnemyCharacter _character;

		private int _hp;

		private int _deadCount;

		public const int CHANGE_HP_MAX = 4;

		private int[] _changeHps;

		private Vector3 _offsetPos;

		public float priorityTargetRange
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

		public int whenDeadCenterCharacterActionId
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public static void Initialize(GameObject go, float pTargetRange, int[] cHps)
		{
		}

		protected virtual void Initialize(float pTargetRange, int[] cHps)
		{
		}

		public bool isCenterCharacterExist()
		{
			return default(bool);
		}

		public int GetNextReviveHp()
		{
			return default(int);
		}

		public virtual void Revive(int hp, int wdCenterCharacterActId)
		{
		}

		public virtual void Leave()
		{
		}

		public virtual void DeadPlayCenterCharacterAction()
		{
		}

		public void LateUpdate()
		{
		}

		private void SendWeakPointDead()
		{
		}
	}
}
