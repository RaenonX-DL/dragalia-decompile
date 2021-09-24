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
	public class ActionPartsOperateCutt : ActionParts
	{
		// Fields
		private readonly OperateCuttData _partsData;
		private bool _hasFinishProc;
	
		// Nested types
		public enum OperateType
		{
			AbortCutt = 0,
			PlayCutt = 1
		}
	
		// Constructors
		public ActionPartsOperateCutt(ActionParts resource);
	
		// Methods
		protected override void OnFinish();
		public override void Clear();
		protected override void OnStart();
		protected override bool OnUpdate(float delta);
		private void ProcFinish();
	}
}
