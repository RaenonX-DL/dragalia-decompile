/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using Gluon.ActionData;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Bullet
{
	public class ActionPartsFireStockBullet : ActionPartsBullet
	{
		// Fields
		private const int defaultBulletDataMax = 10;
		private readonly FireStockBulletData _partsData;
		private BulletDataClone[] _bulletData;
		private List<Vector3> bulletPositions;
	
		// Constructors
		public ActionPartsFireStockBullet(Gluon.ActionData.ActionParts resource);
	
		// Methods
		protected override void OnStart();
		public override void Initialize(CharacterBase chara);
		protected override void Fire();
		protected override void OnFinish();
		private void SetupBulletData(int index);
		private void CalculateTransform(int index);
		private Vector3 StockBulletOriginalPosition(int index);
	}
}
