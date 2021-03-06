﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.ActionData;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ActionPartsOperateShader : ActionParts
	{
		// Fields
		private readonly OperateShaderData _partsData;
	
		// Nested types
		public enum OperateType
		{
			SwitchingMaterial = 0,
			ImageEffectProduction = 1
		}
	
		// Constructors
		public ActionPartsOperateShader(ActionParts resource);
	
		// Methods
		protected override void OnStart();
		public override void Clear();
		private void Proc();
	}
}
