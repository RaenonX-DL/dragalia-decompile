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
	public class ActionPartsVisible : ActionParts
	{
		// Fields
		private readonly VisibleData _partsData;
	
		// Constructors
		public ActionPartsVisible(ActionParts resource);
	
		// Methods
		protected override void OnStart();
		public override void Clear();
		private void ProcCommand();
		private void ChangeMeshNameToBreakParts(ref string name);
		private void ProcPartsBreakToSub();
	}
}
