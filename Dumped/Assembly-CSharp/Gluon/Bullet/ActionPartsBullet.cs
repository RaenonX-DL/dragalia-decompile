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

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Bullet
{
	public class ActionPartsBullet : Gluon.ActionParts
	{
		// Fields
		private readonly BulletData _partsData;
		protected bool useInheritedFire;
		protected bool initInheritedHitAttr;
		protected Vector3 _position;
		protected Quaternion _rotation;
		protected Vector3 _offsetPos;
		protected Vector3 _directionEuler;
		protected CommonObjectStatus _target;
		private float _waitCount;
		protected const float TARGET_HEIGHT_MIN = 0.5f;
		[CompilerGenerated]
		private ActionPartsBulletHitAttribute _hitAttr_k__BackingField;
		[CompilerGenerated]
		private ActionPartsBulletHitAttribute _abHitAttr_k__BackingField;
		[CompilerGenerated]
		private ActionPartsBulletHitAttribute[] _addHitAttr_k__BackingField;
		[CompilerGenerated]
		private string _hitAttrLabel_k__BackingField;
		[CompilerGenerated]
		private string _hitAttrLabel2nd_k__BackingField;
		private RandomXorshift _random;
		private RunActionBulletParameter _runActionParam;
		private bool skipMisfire;
		private int _appearChildTaskId;
	
		// Properties
		protected ActionPartsBulletHitAttribute hitAttr { [CompilerGenerated] get; [CompilerGenerated] set; }
		protected ActionPartsBulletHitAttribute abHitAttr { [CompilerGenerated] get; [CompilerGenerated] set; }
		protected ActionPartsBulletHitAttribute[] addHitAttr { [CompilerGenerated] get; [CompilerGenerated] set; }
		protected string hitAttrLabel { [CompilerGenerated] get; [CompilerGenerated] set; }
		protected string hitAttrLabel2nd { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Constructors
		public ActionPartsBullet(Gluon.ActionData.ActionParts resource);
	
		// Methods
		public override void Initialize(CharacterBase chara);
		protected override void OnStart();
		protected override bool OnUpdate(float delta);
		protected virtual void Fire();
		protected void CalculateTransform(BulletDataClone bulletData);
		protected void CalculateTransform(BulletData bulletData);
		protected void CalculateTransform(Vector3 pos, Vector3 dir, BulletData.GenerateStyle generateStyle, string generateNodeName, BulletObject.DirectionType directionType, float nearest, float collisionParams01, float generateNear, int loadPositionId);
		public static Quaternion CalculateFireDirection(BulletObject.DirectionType directionType, Vector3 position, CharacterBase owner, CommonObjectStatus target, float nearest, BulletData.GenerateStyle generateStyle, float generateNear, string targetDistinctionTag = "");
		private bool Misfire();
		protected string ConvertHitAttributeLabel(InGameDef.CharacterType charaType, string label);
		protected void RegisterHitAttribute(ActionPartsBulletHitAttribute attr, InGameDef.CharacterType charaType, string label);
		protected void RegisterHitAttribute(InGameDef.CharacterType charaType, string label);
		public override RunActionParameterBase CreateRunActionParameter();
		public override void SetRunActionParameter(RunActionParameterBase param);
	}
}
