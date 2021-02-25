/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using Gluon.ActionData;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Bullet
{
	public class ActionPartsAutomaticFire : ActionPartsBullet
	{
		// Fields
		private readonly AutomaticFireData _partsData;
		private BulletDataClone bulletData;
		[CompilerGenerated]
		private CharacterBase _target_k__BackingField;
		[CompilerGenerated]
		private CharacterBase _preTarget_k__BackingField;
		private List<CharacterBase> _candidatesList;
		private float _elapsed;
		private float _timer;
		private int _count;
		private int _generateCnt;
		private string _hitAttrLabel;
		private RandomXorshift _random;
		private const int INTERVAL_NUM_FOR_SPECIAL01 = 5;
	
		// Properties
		private CharacterBase target { [CompilerGenerated] get; [CompilerGenerated] set; }
		private CharacterBase preTarget { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		public enum TargetPattern
		{
			ActionTarget = 0,
			MainPlayer = 1,
			NearPlayer = 2,
			Special_01 = 3
		}
	
		// Constructors
		public ActionPartsAutomaticFire(Gluon.ActionData.ActionParts resource);
	
		// Methods
		public override void Initialize(CharacterBase chara);
		private void ResetParameter();
		protected override void OnStart();
		protected override bool OnUpdate(float delta);
		private void CreateBullet();
		private void SelectTarget();
		private bool CanFire();
		private float GetInterval();
	}
}
