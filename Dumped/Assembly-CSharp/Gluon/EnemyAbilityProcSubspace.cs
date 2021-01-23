/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EnemyAbilityProcSubspace : EnemyAbilityProcBase
	{
		// Fields
		private SubspaceState _state;
		private CharacterBase _target;
		private const float RETURN_TIME = 3f;
		private float _timer;
		private List<CharacterBase> _targets;
		[CompilerGenerated]
		private bool _IsFinishedWarpOnMulti_k__BackingField;
	
		// Properties
		private bool IsFinishedWarpOnMulti { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		private enum SubspaceState
		{
			Deactive = 0,
			Open = 1,
			Active = 2,
			TargetDead = 3,
			TargetLeave = 4,
			Close = 5
		}
	
		// Constructors
		public EnemyAbilityProcSubspace(EnemyAbility enemyability_, EnemyAbilityElement data_, EnemyCharacter owner_);
	
		// Methods
		public override void Play();
		public override void Stop();
		public override void OnUpdate();
		private void ProcDeactive();
		private void ProcOpen();
		private void ProcTargetDead();
		private void ProcTargetLeave();
		private void ProcClose();
		private CharacterBase GetTargetSolo();
		private CharacterBase GetTargetMulti();
		private void ReleaseSpRegenerationBuff(CharacterBase target);
		private void ReleasePhaseShiftInSubspace();
		public override void OnChangeRoomGroup(CharacterBase target);
		public override void OnDisconnectUser(int disconnectActorId);
	}
}
