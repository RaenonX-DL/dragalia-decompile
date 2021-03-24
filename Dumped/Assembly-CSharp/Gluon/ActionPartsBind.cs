/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.ActionData;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ActionPartsBind : ActionParts
	{
		// Fields
		private readonly BindData _partsData;
		private CharacterBase _target;
		private CharacterBase _targetOriginal;
		private Transform _attachNode;
		private Quaternion _preRotation;
		private bool _success;
	
		// Nested types
		public enum BindType
		{
			There = 0,
			Owner = 1,
			OwnerNode = 2,
			ThereGround = 3
		}
	
		// Constructors
		public ActionPartsBind(ActionParts resource);
	
		// Methods
		protected override void OnStart();
		protected override bool OnUpdate(float delta);
		public override void Clear();
		protected override void OnFinish();
		private void Bind(bool on);
		private void SetTargetPosition();
	}
}
