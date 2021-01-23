/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Event;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ActionBlastBase : ActionBase
	{
		// Fields
		private State state;
		private ActionMove boundMove;
		private ActionMoveGravity blastMove;
		private DungeonObjectContact dunObjContact;
		private float elapsedTime;
		private float downLoopTime;
		private const float boundMoveLength = 0.5f;
		private const float boundMoveTime = 0.67f;
		private const string animStandupName = "blast_6";
		[CompilerGenerated]
		private string _animBlastName_k__BackingField;
		[CompilerGenerated]
		private string _animBoundName_k__BackingField;
		[CompilerGenerated]
		private string _effBoundName_k__BackingField;
		[CompilerGenerated]
		private int _reactionMode_k__BackingField;
		[CompilerGenerated]
		private bool _isDead_k__BackingField;
		[CompilerGenerated]
		private bool _isFalling_k__BackingField;
		[CompilerGenerated]
		private bool _enableRecovery_k__BackingField;
		[CompilerGenerated]
		private bool _enableAvoid_k__BackingField;
		private CharacterBase attacker;
		private RandomXorshift _random;
		private RunActionRandomParameter _runActionParam;
	
		// Properties
		protected string animBlastName { [CompilerGenerated] get; [CompilerGenerated] set; }
		protected string animBoundName { [CompilerGenerated] get; [CompilerGenerated] set; }
		protected string effBoundName { [CompilerGenerated] get; [CompilerGenerated] set; }
		protected int reactionMode { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool isDead { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool isStandUp { get; }
		public bool isDown { get; }
		public bool isFalling { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool enableRecovery { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool enableAvoid { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		private enum State
		{
			None = 0,
			Blast = 1,
			Bound = 2,
			Down = 3,
			Dead = 4,
			Standup = 5
		}
	
		// Constructors
		public ActionBlastBase();
	
		// Methods
		public override RunActionParameterBase CreateRunActionParameter();
		public override void SetRunActionParameter(RunActionParameterBase param);
		public void SetParam(float gravity, float angle, float height, int reactionMode);
		public void SetAttacker(CharacterBase attacker);
		protected virtual void SetCoefficient(out float coef);
		protected override void OnStart();
		protected override bool OnUpdate(float delta);
		protected override bool OnFixedUpdate(float delta);
		private void StateBlast(float delta);
		private void StateBound(float delta);
		private void StateDown();
		private void StateStandup();
		protected bool IsBlastFinish();
		public float GetGravity();
		public float GetAngle();
		private bool CheckDead();
		public bool IsGetupActionSupported();
	}
}
