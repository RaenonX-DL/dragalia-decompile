/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using Gluon.ActionData;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Bullet
{
	public class ActionPartsMultiDropBulletRegisteredPos : ActionPartsDropBullet
	{
		// Fields
		private readonly MultiDropBulletRegisteredPosData _partsData;
		private BulletDataClone bulletData;
		private int _generateNum;
		private int _generateCnt;
		private float _delayTime;
		private int _hostileIdx;
		private string _hitAttrLabel;
	
		// Constructors
		public ActionPartsMultiDropBulletRegisteredPos(Gluon.ActionData.ActionParts resource);
	
		// Methods
		public override void Initialize(CharacterBase chara);
		protected override void OnStart();
		protected override bool OnUpdate(float delta);
		protected bool CreateBullet();
	}
}
