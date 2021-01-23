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
	public class ActionPartsTanatosHourglassDrop : ActionParts
	{
		// Fields
		private readonly TanatosHourglassDropData _partsData;
		private ActionMove _move;
		private int _movePointIndex;
	
		// Constructors
		public ActionPartsTanatosHourglassDrop(ActionParts resource);
	
		// Methods
		protected override void OnStart();
		protected override bool OnUpdate(float delta);
		protected override bool OnFixedUpdate(float delta);
		public override void Stop();
	}
}
