using System.Runtime.CompilerServices;
using Gluon.Event;

namespace Gluon
{
	public class ActionBlastBase : ActionBase
	{
		private enum State
		{
			None,
			Blast,
			Bound,
			Down,
			Dead,
			Standup
		}

		private State state;

		private ActionMove boundMove;

		private ActionMoveGravity blastMove;

		private DungeonObjectContact dunObjContact;

		private float elapsedTime;

		private float downLoopTime;

		private const float boundMoveLength = 0.5f;

		private const float boundMoveTime = 0.67f;

		private const string animStandupName = "blast_6";

		private CharacterBase attacker;

		private RandomXorshift _random;

		private RunActionRandomParameter _runActionParam;

		protected string animBlastName
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		protected string animBoundName
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		protected string effBoundName
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		protected int reactionMode
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		protected bool disallowRecovery
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isDead
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

		public bool isStandUp => default(bool);

		public bool isDown => default(bool);

		public bool isFalling
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

		public bool enableRecovery
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool enableAvoid
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public override RunActionParameterBase CreateRunActionParameter()
		{
			return null;
		}

		public override void SetRunActionParameter(RunActionParameterBase param)
		{
		}

		public void SetParam(float gravity, float angle, float height, int reactionMode, bool disallowRecovery = false)
		{
		}

		public void SetAttacker(CharacterBase attacker)
		{
		}

		protected virtual void SetCoefficient(out float coef)
		{
		}

		protected override void OnStart()
		{
		}

		protected override bool OnUpdate(float delta)
		{
			return default(bool);
		}

		protected override bool OnFixedUpdate(float delta)
		{
			return default(bool);
		}

		private void StateBlast(float delta)
		{
		}

		private void StateBound(float delta)
		{
		}

		private void StateDown()
		{
		}

		private void StateStandup()
		{
		}

		protected bool IsBlastFinish()
		{
			return default(bool);
		}

		public float GetGravity()
		{
			return default(float);
		}

		public float GetAngle()
		{
			return default(float);
		}

		private bool CheckDead()
		{
			return default(bool);
		}

		public bool IsGetupActionSupported()
		{
			return default(bool);
		}
	}
}
