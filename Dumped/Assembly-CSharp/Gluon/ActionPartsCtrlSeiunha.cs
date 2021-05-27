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
	public class ActionPartsCtrlSeiunha : ActionParts
	{
		// Fields
		private readonly CtrlSeiunhaData _partsData;
	
		// Nested types
		public enum Order
		{
			Fire = 0,
			BringBack = 1
		}
	
		// Constructors
		public ActionPartsCtrlSeiunha(ActionParts resource);
	
		// Methods
		public override void OnPostCreated(CharacterBase chara);
		protected override void OnStart();
		public override void Clear();
		private void Proc();
		private void Fire();
		private void BringBack();
	}
}
