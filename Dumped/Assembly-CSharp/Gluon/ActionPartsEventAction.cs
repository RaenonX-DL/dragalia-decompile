/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.ActionData;
using Gluon.Event;
using UnityEngine.Events;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ActionPartsEventAction : ActionParts
	{
		// Fields
		private readonly EventActionData _partsData;
		private UnityEvent _resEvent;
		private RunActionIntParameter _runActionParam;
	
		// Constructors
		public ActionPartsEventAction(ActionParts resource);
	
		// Methods
		public override RunActionParameterBase CreateRunActionParameter();
		public override void SetRunActionParameter(RunActionParameterBase param);
		protected override void OnStart();
		protected override void OnFinish();
		public override void Clear();
		private void OnResponceEvent();
	}
}
