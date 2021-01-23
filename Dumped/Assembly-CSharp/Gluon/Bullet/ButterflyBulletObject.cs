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
	public class ButterflyBulletObject : BulletObject
	{
		// Fields
		public static readonly int generateMax;
		private static readonly int DeleteCountMax;
		private int deleteCounter;
	
		// Constructors
		public ButterflyBulletObject();
		static ButterflyBulletObject();
	
		// Methods
		public override bool Initialize(CharacterBase owner, CommonObjectStatus target, int actionId, int skillId, int productId, Vector3 position, Quaternion rotation);
		protected override bool OnUpdate();
		private bool IsLostTarget();
		public void AddDeleteCounter(int add);
		public void HitEnd();
	}
}
