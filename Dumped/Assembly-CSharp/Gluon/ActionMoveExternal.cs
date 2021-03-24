/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ActionMoveExternal : ActionBase
	{
		// Fields
		private Vector3 velocity;
		private float duration;
		private float stepTime;
		private bool isExternalMoveAffected;
	
		// Properties
		public bool IsExternalMoveAffected { get; }
	
		// Constructors
		public ActionMoveExternal();
	
		// Methods
		public void SetParam(Vector3 startPos, Vector3 endPos, float duration);
		public override bool Update(float delta);
		protected override void OnFinish();
		protected override bool OnUpdate(float delta);
	}
}
