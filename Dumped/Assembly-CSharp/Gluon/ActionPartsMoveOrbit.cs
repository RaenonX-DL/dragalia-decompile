/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.ActionData;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ActionPartsMoveOrbit : ActionParts
	{
		// Fields
		private readonly MoveOrbitData _partsData;
		private ActionMoveOrbit _move;
	
		// Constructors
		public ActionPartsMoveOrbit(ActionParts resource);
	
		// Methods
		public override void Clear();
		protected override void OnFinish();
		public override void Stop();
		protected override void OnStart();
		protected override bool OnUpdate(float delta);
	}
}
