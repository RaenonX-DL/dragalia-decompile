/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using Gluon.ActionData;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Bullet
{
	public class ActionPartsBulletWithMarker : Gluon.ActionParts
	{
		// Fields
		private readonly BulletWithMarkerData _partsData;
		protected Vector3 _position;
		protected Quaternion _rotation;
		private ActionPartsBulletHitAttribute attr;
	
		// Constructors
		public ActionPartsBulletWithMarker(Gluon.ActionData.ActionParts resource);
	
		// Methods
		protected override void OnStart();
		public override void Initialize(CharacterBase chara);
		protected override bool OnUpdate(float delta);
		private void Setup();
		public static void SetBulletEffect(BulletWithMarkerData data, CharacterBase owner, ref BulletDataClone bulletData);
	}
}
