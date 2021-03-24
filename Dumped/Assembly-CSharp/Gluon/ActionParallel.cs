/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ActionParallel : ActionBase
	{
		// Fields
		protected List<ActionBase> _actions;
	
		// Constructors
		public ActionParallel(params ActionBase[] actions);
	
		// Methods
		public override void Initialize(CharacterBase chara);
		protected override bool OnUpdate(float delta);
		public override void RemoveSelf();
	}
}
