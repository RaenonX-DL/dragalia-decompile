/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using Gluon.ActionData;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Bullet
{
	public class CondensBulletObject : BulletObjectWithMarker
	{
		// Fields
		private MineData _minedata;
		private MineState _minestate;
		private CollisionHitAttribute _mineHitAttribute;
		private ChargeMarker _mineMarker;
		private float _mineRestTime;
		private string _impactSeName;
	
		// Nested types
		[Serializable]
		public class MineData
		{
			// Fields
			[CompilerGenerated]
			private string _hitAttrLabel_k__BackingField;
			[CompilerGenerated]
			private float _range_k__BackingField;
			[CompilerGenerated]
			private float _ignitionTime_k__BackingField;
			[CompilerGenerated]
			private int _explodeEffTrig_k__BackingField;
			[CompilerGenerated]
			private float _explodingTime_k__BackingField;
			[CompilerGenerated]
			private string _explodeSeName_k__BackingField;
			[CompilerGenerated]
			private ChargeMarker.eColorType _markerColor_k__BackingField;
	
			// Properties
			public string hitAttrLabel { [CompilerGenerated] get; [CompilerGenerated] set; }
			public float range { [CompilerGenerated] get; [CompilerGenerated] set; }
			public float ignitionTime { [CompilerGenerated] get; [CompilerGenerated] set; }
			public int explodeEffTrig { [CompilerGenerated] get; [CompilerGenerated] set; }
			public float explodingTime { [CompilerGenerated] get; [CompilerGenerated] set; }
			public string explodeSeName { [CompilerGenerated] get; [CompilerGenerated] set; }
			public ChargeMarker.eColorType markerColor { [CompilerGenerated] get; [CompilerGenerated] set; }
	
			// Constructors
			public MineData();
		}
	
		private enum MineState
		{
			Init = 0,
			Fuse = 1,
			Explode = 2,
			Exploding = 3
		}
	
		// Constructors
		public CondensBulletObject();
	
		// Methods
		protected override void Clear();
		public void Initialize(CharacterBase owner, CommonObjectStatus target, int traceDelay, string hitAttrLabel, MarkerData markerData, MineData minedata, Vector3 position, string impactSeName);
		protected override bool State_Init();
		protected override bool State_Fire();
		protected override bool State_BulletRun();
		public override void OnCollided(GameObject target, bool isPropagation);
	}
}
