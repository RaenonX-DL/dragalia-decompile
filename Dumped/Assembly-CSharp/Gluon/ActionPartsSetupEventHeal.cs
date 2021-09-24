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
	public class ActionPartsSetupEventHeal : ActionParts
	{
		// Fields
		private readonly SetupEventHealData _partsData;
		private bool _isValid;
	
		// Constructors
		public ActionPartsSetupEventHeal(ActionParts resource);
	
		// Methods
		public override void OnPostCreated(CharacterBase chara);
		protected override void OnStart();
		private void Proc();
		private CollisionHitAttribute CreateHitAttribute();
	}
}
