/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PlayerStateSkill : PlayerStateBase
	{
		// Fields
		[CompilerGenerated]
		private int _skillIndex_k__BackingField;
		private int additionalInputCount;
	
		// Properties
		public int skillIndex { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Constructors
		public PlayerStateSkill();
	
		// Methods
		public override void OnStateEnter();
		public override void OnStateUpdate();
		public override void OnStateExit();
		private bool CheckSkillMove();
		private bool CheckAdditionalInput();
		protected override bool IsOperateState();
	}
}
