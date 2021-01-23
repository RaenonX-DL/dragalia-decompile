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
	public class ActionPartsBuffFieldAttachment : ActionParts
	{
		// Fields
		private readonly BuffFieldAttachmentData _partsData;
		private ActionPartsBulletHitAttribute hitAttr;
		private string hitAttrLabel;
		private CollisionHitAttribute[] _hitAttributes;
	
		// Constructors
		public ActionPartsBuffFieldAttachment(ActionParts resource);
	
		// Methods
		public override void Initialize(CharacterBase chara);
		protected string GetHitAttributeLabel();
		protected string ConvertHitAttributeLabel(InGameDef.CharacterType charaType, string label);
		protected void RegisterHitAttribute(ActionPartsBulletHitAttribute attr, InGameDef.CharacterType charaType, string label);
		protected override bool OnUpdate(float delta);
		protected override void OnStart();
		protected void CopyHitAttrGeometry(CollisionHitAttribute other, int i);
	}
}
