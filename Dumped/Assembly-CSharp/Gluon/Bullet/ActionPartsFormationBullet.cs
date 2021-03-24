/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using Gluon.ActionData;
using Gluon.Event;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Bullet
{
	public class ActionPartsFormationBullet : ActionPartsBullet
	{
		// Fields
		private readonly int childNumMax;
		private readonly FormationBulletData _partsData;
		private BulletDataClone[] _bulletData;
		private int actionProductId;
		private RunActionCompositeParameter _compositeParam;
		private RunActionIntParameter _actionProductIdParam;
	
		// Constructors
		public ActionPartsFormationBullet(Gluon.ActionData.ActionParts resource);
	
		// Methods
		public override RunActionParameterBase CreateRunActionParameter();
		public override void SetRunActionParameter(RunActionParameterBase param);
		protected override void OnStart();
		public override void Initialize(CharacterBase chara);
		protected override void Fire();
	}
}
