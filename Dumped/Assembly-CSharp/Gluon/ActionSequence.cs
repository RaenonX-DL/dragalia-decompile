/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ActionSequence : ActionBase
	{
		// Fields
		protected List<ActionBase> _actions;
		private int _index;
	
		// Constructors
		public ActionSequence(params ActionBase[] actions);
	
		// Methods
		public override void Initialize(CharacterBase chara);
		protected override bool OnUpdate(float delta);
		public override void RemoveSelf();
	}
}
