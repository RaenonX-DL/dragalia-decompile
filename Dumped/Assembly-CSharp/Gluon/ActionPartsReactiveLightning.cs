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
	public class ActionPartsReactiveLightning : ActionParts
	{
		// Fields
		private readonly ReactiveLightningData _partsData;
	
		// Constructors
		public ActionPartsReactiveLightning(ActionParts resource);
	
		// Methods
		protected override void OnStart();
		private bool IsInside(EnemyCharacter target);
	}
}
