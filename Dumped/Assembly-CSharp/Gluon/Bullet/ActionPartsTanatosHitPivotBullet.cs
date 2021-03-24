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
	public class ActionPartsTanatosHitPivotBullet : Gluon.ActionParts
	{
		// Fields
		private readonly TanatosHitPivotBulletData _partsData;
		private string _hitAttrLabel;
		private ActionPartsBulletHitAttribute attr;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass7_0
		{
			// Fields
			public TanatosUniqueCtrl uniqCtrl;
			public int subCount;
	
			// Constructors
			public __c__DisplayClass7_0();
	
			// Methods
			internal void _Setup_b__0(HitException hitExp);
		}
	
		// Constructors
		public ActionPartsTanatosHitPivotBullet(Gluon.ActionData.ActionParts resource);
	
		// Methods
		protected override void OnStart();
		public override void Initialize(CharacterBase chara);
		protected override bool OnUpdate(float delta);
		private void Setup();
	}
}
