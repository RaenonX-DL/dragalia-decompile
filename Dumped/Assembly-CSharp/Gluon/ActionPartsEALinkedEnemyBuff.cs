/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.ActionData;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ActionPartsEALinkedEnemyBuff : ActionParts
	{
		// Fields
		private readonly EALinkedEnemyBuffData _partsData;
	
		// Constructors
		public ActionPartsEALinkedEnemyBuff(ActionParts resource);
	
		// Methods
		public override void Clear();
		protected override void OnStart();
		private void Proc();
		private void SetupAbiltiy(EnemyAbilityProcLinkedEnemyBuff ability);
	}
}
