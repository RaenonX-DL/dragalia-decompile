/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class DungeonObjectContact : ICollideCallback
	{
		// Fields
		private HitException hitException;
		private CollisionHitAttribute hitAttr;
	
		// Constructors
		public DungeonObjectContact();
	
		// Methods
		public void InitializeFromCommonActionHitAttribute(string elementId);
		public void InitializeFromPlayerActionHitAttribute(string elementId);
		private void InitializeException();
		public void Update(CharacterBase owner, Vector3 dir);
		private void CheckHitDungeonObject(CharacterBase owner, Vector3 dir);
		public virtual void OnCollided(GameObject target, bool isPropagation);
		public virtual void OnCollidedEffect(CommonObjectStatus from, CommonObjectStatus to, Vector3 pos, Quaternion rot);
		public virtual void OnNotCollided(CharacterBase chara);
		public virtual bool IsExcept(CharacterBase chara);
	}
}
