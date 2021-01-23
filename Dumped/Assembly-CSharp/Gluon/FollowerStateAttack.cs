/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class FollowerStateAttack : IState<Gluon.FollowerController>
	{
		// Fields
		[CompilerGenerated]
		private int _attackNum_k__BackingField;
		private int currentCombo;
	
		// Properties
		public int attackNum { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Constructors
		public FollowerStateAttack();
	
		// Methods
		public override void OnStateEnter();
		public override void OnStateUpdate();
		private bool CheckAttack();
	}
}
