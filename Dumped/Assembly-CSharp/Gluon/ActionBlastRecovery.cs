/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ActionBlastRecovery : ActionBase
	{
		// Fields
		private State state;
		private ActionMoveGravity blastMove;
		private DungeonObjectContact dunObjContact;
	
		// Nested types
		private enum State
		{
			None = 0,
			Fall = 1,
			Landing = 2
		}
	
		// Constructors
		public ActionBlastRecovery();
	
		// Methods
		public void SetParam(float gravity, float angle, bool isCtrl);
		protected override void OnStart();
		protected override bool OnUpdate(float delta);
	}
}
