/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharacterStateSkillCasting : CharacterStateBase
	{
		// Fields
		[CompilerGenerated]
		private CommonObjectStatus _target_k__BackingField;
		[CompilerGenerated]
		private int _skillId_k__BackingField;
		private bool _prevEnableNavMeshAgent;
	
		// Properties
		public int skillIndex { get; set; }
		public int actionId { get; set; }
		public CommonObjectStatus target { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int skillId { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public CharacterStateSkillCasting();
	
		// Methods
		protected override void OnStateEnter_Internal();
		public override void OnStateUpdate();
		public override void OnStateExit();
	}
}
