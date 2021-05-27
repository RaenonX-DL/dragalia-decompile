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
	public class ActionPartsOrderToMinion : ActionParts
	{
		// Fields
		private readonly OrderToMinionData _partsData;
	
		// Constructors
		public ActionPartsOrderToMinion(ActionParts resource);
	
		// Methods
		protected override void OnStart();
		public override void Clear();
		private void ProcCommand();
		private void OrderAction(EnemyCharacter chara);
		private void TargetCorrection(ref CommonObjectStatus target);
	}
}
