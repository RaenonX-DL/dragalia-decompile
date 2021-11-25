using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon
{
	public class StoneSatelliteUniqueCtrl : EnemyUniqueCtrl
	{
		public enum PositionStyle
		{
			none,
			stick,
			parade,
			target,
			moveStick
		}

		private float STICK_SPACE;

		private Vector3 _basePosition;

		private Vector3[] _linePositions;

		private Vector2[] _baseSpeed;

		private PositionStyle _posStyle;

		private List<ActionMove> _actMoves;

		public List<EnemyCharacter> childCharacter
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public float childRadius
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isMoveing
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public override void FastUpdate()
		{
		}

		private void FixedUpdate()
		{
		}

		public override void Initialize()
		{
		}

		public void SetPositionStyle(PositionStyle style, float tempoScale = 1f)
		{
		}

		public void TargetMove(CharacterBase chara, Vector3 target, float duration)
		{
		}

		public void SetStickMove(float duration)
		{
		}

		private void UpdateMove()
		{
		}

		private void FixedUpdateMove()
		{
		}

		private Vector3 CalcChildPosition(int no)
		{
			return default(Vector3);
		}

		public void ProductionOption(int childActionId, float tempoScale = 1f)
		{
		}

		public void ChildInvincible(bool set)
		{
		}

		public void ChildFullHP()
		{
		}
	}
}
