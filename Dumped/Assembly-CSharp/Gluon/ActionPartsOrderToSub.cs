﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.ActionData;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ActionPartsOrderToSub : ActionParts
	{
		// Fields
		private readonly OrderToSubData _partsData;
		public List<EnemyCharacter> _subCharaList;
	
		// Constructors
		public ActionPartsOrderToSub(ActionParts resource);
	
		// Methods
		protected override void OnStart();
		public override void Clear();
		private void ProcCommand();
		private void OrderAction(EnemyCharacter chara);
		private void TargetCorrection(ref CommonObjectStatus target);
	}
}
