/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using Gluon.ActionData;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Bullet
{
	public class ActionPartsPivotBullet : Gluon.ActionParts
	{
		// Fields
		private readonly PivotBulletData _partsData;
		private string _hitAttrLabel;
		private ActionPartsBulletHitAttribute attr;
	
		// Nested types
		public enum BaseAxisType
		{
			World = 0,
			AreaAnchor = 1,
			Owner = 2,
			OwnerGround = 3,
			Target = 4,
			TargetGround = 5,
			MultiP1 = 6,
			MultiP2 = 7,
			MultiP3 = 8,
			MultiP4 = 9
		}
	
		// Constructors
		public ActionPartsPivotBullet(Gluon.ActionData.ActionParts resource);
	
		// Methods
		protected override void OnStart();
		public override void Initialize(CharacterBase chara);
		protected override bool OnUpdate(float delta);
		private void Setup();
		protected string ConvertHitAttributeLabel(InGameDef.CharacterType charaType, string label);
		private Vector3 CalcAnchorPosition(BaseAxisType type, CommonObjectStatus target, out Transform anchor_transform);
		private bool GetTargetCharacter(BaseAxisType type, out CommonObjectStatus target);
	}
}
