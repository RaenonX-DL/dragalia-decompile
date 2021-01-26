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
	public class ActionPartsSetupAlloutAssault : ActionParts
	{
		// Fields
		private readonly SetupAlloutAssaultData _partsData;
		private AlloutAssaultUniqueCtrl _ctrl;
	
		// Constructors
		public ActionPartsSetupAlloutAssault(ActionParts resource);
	
		// Methods
		public override void OnPostCreated(CharacterBase chara);
		protected override void OnStart();
		private CollisionHitAttribute CreateHitAttribute();
	}
}
