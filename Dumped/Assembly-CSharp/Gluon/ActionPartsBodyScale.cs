/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.ActionData;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ActionPartsBodyScale : ActionParts
	{
		// Fields
		private readonly BodyScaleData _partsData;
		private float _scale;
		private float _elapsed;
	
		// Constructors
		public ActionPartsBodyScale(ActionParts resource);
	
		// Methods
		protected override void OnStart();
		protected override bool OnUpdate(float delta);
	}
}
