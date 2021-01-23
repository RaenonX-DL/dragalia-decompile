/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Bullet
{
	public class PivotBulletObject : BulletObjectWithMarker
	{
		// Fields
		private GameObject _anchor;
		private Action<HitException> _hitCallBack;
		[CompilerGenerated]
		private ActionPartsPivotBullet.BaseAxisType _baseAxis_k__BackingField;
		[CompilerGenerated]
		private bool _isUpdateAnchorPos_k__BackingField;
		[CompilerGenerated]
		private float _anchorOffsetY_k__BackingField;
		[CompilerGenerated]
		private CommonObjectStatus _target_k__BackingField;
		[CompilerGenerated]
		private bool _useMarker_k__BackingField;
		[CompilerGenerated]
		private float _winchSpeed_k__BackingField;
		[CompilerGenerated]
		private bool _isFinishHitTrap_k__BackingField;
	
		// Properties
		public ActionPartsPivotBullet.BaseAxisType baseAxis { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isUpdateAnchorPos { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float anchorOffsetY { [CompilerGenerated] get; [CompilerGenerated] set; }
		public CommonObjectStatus target { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool useMarker { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float winchSpeed { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isFinishHitTrap { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Constructors
		public PivotBulletObject();
	
		// Methods
		protected override void Clear();
		public bool Initialize(CharacterBase owner, CommonObjectStatus target_, string hitAttrLabel, Vector3 anchor_position, float pivotRadius, float anchorForward, Transform anchorTransform, Action<HitException> hitCallBack = null);
		protected override bool State_Init();
		protected override bool State_Fire();
		protected override bool State_BulletRun();
		protected override bool State_End();
		private Vector3 UpdateAnchorPosition();
	}
}
