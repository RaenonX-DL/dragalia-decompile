/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class AbnormalStatusFreeze : AbnormalStatusBase
	{
		// Fields
		private int attackCount;
	
		// Constructors
		public AbnormalStatusFreeze();
	
		// Methods
		public override bool Update();
		public override void Exit();
		public override void PlayEffect(GameObject node = null);
		public override bool ReleaseFreezeOnCollided();
	}
}
