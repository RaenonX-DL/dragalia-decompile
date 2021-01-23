/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using Gluon;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Bullet
{
	public abstract class BulletBase : FastUpdateMonoBehaviour, ICollideCallback
	{
		// Fields
		protected string _distinctionTag;
	
		// Properties
		public string distinctionTag { get; set; }
	
		// Constructors
		protected BulletBase();
	
		// Methods
		public abstract void OnCollided(GameObject target, bool isPropagation);
		public abstract void OnCollidedEffect(CommonObjectStatus from, CommonObjectStatus to, Vector3 pos, Quaternion rot);
		public abstract void OnNotCollided(CharacterBase chara);
		public abstract bool IsExcept(CharacterBase chara);
	}
}
