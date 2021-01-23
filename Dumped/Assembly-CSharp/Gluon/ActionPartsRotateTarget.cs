/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.ActionData;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ActionPartsRotateTarget : ActionParts
	{
		// Fields
		private readonly RotateTargetData _partsData;
		private float _baseRot;
		private float _moveRot;
		private Vector3 targetPos;
		private CharacterBase _targetCharacter;
		private float _elapsedSec;
	
		// Constructors
		public ActionPartsRotateTarget(ActionParts resource);
	
		// Methods
		protected override void OnStart();
		protected override bool OnUpdate(float delta);
	}
}
