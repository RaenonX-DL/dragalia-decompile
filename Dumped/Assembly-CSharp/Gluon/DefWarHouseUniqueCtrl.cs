/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Dungeon;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class DefWarHouseUniqueCtrl : EnemyUniqueCtrl
	{
		// Fields
		private State _state;
		private GameMasterUniqueCtrl _gm;
		private FieldTalkTriggerAccessPoint _accessPoint;
		[CompilerGenerated]
		private int _idx_k__BackingField;
		private EnemyCharacter _bandit;
		private const int RAIDED_UIID = 7;
		private string resident_label;
		[CompilerGenerated]
		private EnemyCharacter _resident_k__BackingField;
		private const float RESIDENT_WAIT = 1f;
		[CompilerGenerated]
		private bool _hasShowRaided_k__BackingField;
	
		// Properties
		public int idx { [CompilerGenerated] get; [CompilerGenerated] set; }
		public EnemyCharacter resident { [CompilerGenerated] get; [CompilerGenerated] set; }
		private bool hasShowRaided { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		private enum State
		{
			Ready = 0,
			Wait = 1,
			Raided = 2,
			Save = 3,
			Destroy = 4,
			End = 5
		}
	
		[CompilerGenerated]
		private sealed class _CoUpdateSave_d__25 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public DefWarHouseUniqueCtrl __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CoUpdateSave_d__25(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public DefWarHouseUniqueCtrl();
	
		// Methods
		public override void Initialize();
		private void Update();
		private void UpdateReady();
		private void UpdateWait();
		private void UpdateRaided();
		[IteratorStateMachine]
		public IEnumerator CoUpdateSave();
		private void UpdateDestroy();
		private void SetBandit();
	}
}
