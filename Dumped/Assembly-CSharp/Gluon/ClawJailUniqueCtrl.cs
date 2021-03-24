/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ClawJailUniqueCtrl : EnemyUniqueCtrl
	{
		// Fields
		private float _catchRange;
		private string _destructMotion;
		private _State _state;
		private MultiPlayWaitingList _waitingList;
	
		// Nested types
		public class MultiPlayWaitingList
		{
			// Fields
			private List<int> _actorIds;
	
			// Constructors
			public MultiPlayWaitingList();
	
			// Methods
			public void StartWaitForAllOthers();
			public void Update();
			public void RemoveActor(int actorId);
			public bool IsWaitingForActor(int actorId);
			public bool IsWaitingForAny();
		}
	
		private enum _State
		{
			None = 0,
			WaitForBindResult = 1,
			CatchChara = 2,
			Destruct = 3,
			CheckFinishDestruct = 4
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass12_0
		{
			// Fields
			public CharacterBase target;
	
			// Constructors
			public __c__DisplayClass12_0();
	
			// Methods
			internal bool __ApplyBind_b__0(CharacterBase chr);
		}
	
		// Constructors
		public ClawJailUniqueCtrl();
	
		// Methods
		public void StartTask(int actionId, short actionPartsIndex);
		public bool IsTaskCompleted();
		public override void FastUpdate();
		public void OnDead();
		private void _UpdateTask();
		private CharacterBase[] _CollectBindTargets();
		private void _ApplyBind(CharacterBase[] targets);
		private bool _CheckDestroy();
		private void _Destoy();
		private void _SendBindResultEvent(CharacterBase[] targets, int actionId, short actionPartsIndex);
		private void _UpdateRecvBindResult();
	}
}
