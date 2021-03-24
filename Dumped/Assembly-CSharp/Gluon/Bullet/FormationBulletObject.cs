/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.ActionData;
using Gluon.Event;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Bullet
{
	public class FormationBulletObject : BulletObject
	{
		// Fields
		private float rotationTime;
		private FormationBulletData.ChildParameter[] childParam;
		private BulletObject[] child;
		private FormationDataCopy copyData;
	
		// Nested types
		private class FormationDataCopy
		{
			// Fields
			public int childNum;
			public Vector3 rotationSpeed;
			public bool noCheckCollision;
			public bool destroyAlone;
			public FormationBulletData.FireTrigger fireTrigger;
			public FormationBulletData.SoundEffect se;
	
			// Constructors
			public FormationDataCopy();
	
			// Methods
			public void Copy(FormationBulletData data);
		}
	
		// Constructors
		public FormationBulletObject();
	
		// Methods
		protected override void OnDisable();
		protected override void ReleaseChild();
		public void GenerateChildBullet(FormationBulletData data, Vector3 parentPos, Quaternion parentRot);
		protected override bool OnUpdate();
		protected override bool UpdateFormation();
		protected override void PostUpdate();
		protected override bool CheckCollision();
		public Vector3 ChasePosition();
		public bool Fire(FormationBulletData.FireTrigger trigger);
		public void Release(bool onlyFormation);
		public void Hide(bool onlyFormation);
		public void Restart(bool onlyFormation);
		private void PlaySE(Vector3 position);
		protected override void StopSE();
		public bool OnReceiveFireBulletEvent(FireSpecialBullet recv);
		private void SendFireBulletEvent();
	}
}
