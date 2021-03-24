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
	public class ActionPartsRotateTimeCurve : ActionParts
	{
		// Fields
		private readonly RotateTimeCurveData _partsData;
		protected Quaternion _startRotation;
		private float _elapsed;
	
		// Constructors
		public ActionPartsRotateTimeCurve(ActionParts resource);
	
		// Methods
		protected override void OnStart();
		protected override bool OnUpdate(float delta);
	}
}
