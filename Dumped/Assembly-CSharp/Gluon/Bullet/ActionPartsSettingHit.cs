/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using Gluon.ActionData;
using Gluon.Event;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Bullet
{
	public class ActionPartsSettingHit : Gluon.ActionParts
	{
		// Fields
		private readonly SettingHitData _partsData;
		private readonly long _partsDataId;
		private Vector3 _position;
		private Quaternion _rotation;
		private Vector3 _offsetPos;
		private Vector3 _offsetRot;
		private ActionPartsBulletHitAttribute hitAttr;
		[CompilerGenerated]
		private string _hitAttrLabel_k__BackingField;
		private int actionProductId;
		private RunActionIntParameter actionProductIdParam;
	
		// Properties
		private string hitAttrLabel { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Constructors
		public ActionPartsSettingHit(Gluon.ActionData.ActionParts resource, long resourceId);
	
		// Methods
		public override void Initialize(CharacterBase chara);
		public override RunActionParameterBase CreateRunActionParameter();
		public override void SetRunActionParameter(RunActionParameterBase param);
		protected override void OnStart();
		protected virtual void Fire();
		private void CalculateTransform(Vector3 pos, Vector3 dir, SettingHitObject.BasePosition basePosition, float collisionParams01, float nearest);
		private Quaternion CalculateFireDirection(SettingHitObject.BasePosition basePosition, CommonObjectStatus target);
		protected string ConvertHitAttributeLabel(InGameDef.CharacterType charaType, string label);
		protected void RegisterHitAttribute(ActionPartsBulletHitAttribute attr, InGameDef.CharacterType charaType, string label);
		private bool IsBuffField(string hitLabel);
	}
}
