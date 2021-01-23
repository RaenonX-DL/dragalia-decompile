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
	public class ActionPartsRotate : ActionParts
	{
		// Fields
		private readonly RotateData _partsData;
		protected Quaternion _startEuler;
		protected Quaternion _endEuler;
		private float _stepTime;
	
		// Constructors
		public ActionPartsRotate(ActionParts resource);
	
		// Methods
		protected override void OnStart();
		protected override bool OnUpdate(float delta);
	}
}
