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
	public class RoseTokenBulletObject : BulletObject
	{
		// Fields
		private Phase phase;
		private RoseTokenDataCopy copyData;
		private float attackInterval;
	
		// Nested types
		private enum Phase
		{
			Bloom = 0,
			Wither = 1
		}
	
		public class RoseTokenDataCopy
		{
			// Fields
			public float bloomSec;
			public float attackInterval;
			public int witherTrigger;
			public float witherActionRange;
			public int killCount;
			public HitData attackData;
			public HitData healData;
	
			// Constructors
			public RoseTokenDataCopy();
	
			// Methods
			public void Clear();
		}
	
		public class HitData
		{
			// Fields
			public string label;
			public CollisionHitAttribute attr;
			public HitException hitException;
			public Gluon.ActionData.EffectData effData;
			public string seName;
	
			// Constructors
			public HitData();
	
			// Methods
			public void Clear();
		}
	
		// Constructors
		public RoseTokenBulletObject();
	
		// Methods
		public void SetRoseTokenBulletData(RoseTokenData data);
		protected override void Clear();
		protected override bool UpdateMove();
		public void SetCollisionLabel(string lbAttack, string lbHeal);
		public void SetupCollisionHitAttribute(RoseTokenData data);
		private void SetupCollisionHitAttribute(HitData hitData, HitData data);
		private void SetupCollisionParameter(CollisionHitAttribute attr, HitData data);
		private void CheckHitCollision(HitData hitData, CommonObjectStatus fixedTarget);
	}
}
