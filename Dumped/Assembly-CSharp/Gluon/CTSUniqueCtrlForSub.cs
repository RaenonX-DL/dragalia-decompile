/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CTSUniqueCtrlForSub : EnemyUniqueCtrl
	{
		// Fields
		public CTSUniqueCtrl.ShapeType _shapeType;
		private bool _reservedExplosion;
		private bool _isCancelDragon;
		private CollisionHitAttribute _hitAttribute;
		private string _effName;
		private int _effTrig;
		private string _seName;
		private const string CHARAEFF_CONTROL_KEY = "cts_sub";
		private const int CHARAEFF_DEAD_TRIGGER = 1;
		private bool _isExploded;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _CoExplosion_d__18 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public CTSUniqueCtrlForSub __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CoExplosion_d__18(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public CTSUniqueCtrlForSub();
	
		// Methods
		public override void Initialize();
		public void Setup(CTSUniqueCtrl.ShapeType shape, string hitAttrLabel, float radius, bool isCancelDragon);
		public void SetupEffect(string effName, int trigger, string seName);
		private void Update();
		public bool OnFatal(bool isQuestSkill, CharacterBase attacker);
		public void OnDeadEnemy(EnemyCharacter deadEnemy);
		public void SetIncorrect();
		public void OnReceiveAnswer(bool correctAnswer);
		[IteratorStateMachine]
		public IEnumerator CoExplosion();
	}
}
