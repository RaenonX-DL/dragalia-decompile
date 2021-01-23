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
	public class ActionMoveGravity : ActionBase
	{
		// Fields
		[CompilerGenerated]
		private float _gravity_k__BackingField;
		[CompilerGenerated]
		private float _radian_k__BackingField;
		private Vector3 startPos;
		private Vector3 positPrevPos;
		private Vector3 dir;
		private float speed;
		private float coef;
		private float elapsedTime;
		private const float checkInterval = 0.2f;
		private float checkTimer;
		private Vector3 safePosition;
		private ActionMoveExecution moveExec;
	
		// Properties
		public float gravity { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public float radian { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public ActionMoveGravity();
	
		// Methods
		public void Setup(float gravity, float angle, float height, float coef, bool isCtrl = false);
		public void SetDirection(Vector3 dir);
		public bool UpdatePosition(float delta, out Vector3 targetPos, bool updateOnlyY = false);
		private Vector3 CalcPosition(float time);
		private bool CheckGround(Vector3 pos);
	}
}
