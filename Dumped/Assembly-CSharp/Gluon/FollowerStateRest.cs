/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class FollowerStateRest : IState<Gluon.FollowerController>
	{
		// Fields
		private float restTime;
		private float contactTime;
		private bool avoidCheck;
		private int hpOnEnter;
	
		// Constructors
		public FollowerStateRest();
	
		// Methods
		public override void OnStateEnter();
		public override void OnStateUpdate();
	}
}
