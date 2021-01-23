/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon.Gimmick
{
	public class DoorBase : GimmickBase
	{
		// Fields
		protected Animator anim;
		protected Collider coll;
		protected NavMeshObstacle navObs;
	
		// Constructors
		public DoorBase();
	
		// Methods
		protected virtual void Start();
		public virtual void Open();
		public virtual void Close();
		protected virtual void PlayMotion(string motionName);
		protected virtual void SetCollider(bool enableFlag);
	}
}
