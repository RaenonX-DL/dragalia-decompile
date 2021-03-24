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
	public class ActionPartsSwitchElement : ActionParts
	{
		// Fields
		private readonly SwitchElementData _partsData;
		private bool _isDone;
	
		// Constructors
		public ActionPartsSwitchElement(ActionParts resource);
	
		// Methods
		public override void Initialize(CharacterBase chara);
		public override void Clear();
		protected override void OnStart();
		private void Procedure();
	}
}
