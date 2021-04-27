/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using Gluon.ActionData;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Bullet
{
	public class ActionPartsRoseToken : ActionPartsBullet
	{
		// Fields
		private readonly RoseTokenData _partsData;
	
		// Constructors
		public ActionPartsRoseToken(Gluon.ActionData.ActionParts resource);
	
		// Methods
		protected override void OnStart();
		public override void Initialize(CharacterBase chara);
		protected override void Fire();
	}
}
