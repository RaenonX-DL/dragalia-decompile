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
	public class ActionPartsMarker : ActionParts
	{
		// Fields
		private readonly MarkerData _partsData;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0
		{
			// Fields
			public MarkerData markerData;
			public ActionPartsMarker __4__this;
	
			// Constructors
			public __c__DisplayClass3_0();
	
			// Methods
			internal void _CreateMarker_b__0(int chargeLv);
		}
	
		// Constructors
		public ActionPartsMarker(ActionParts resource);
	
		// Methods
		protected override void OnStart();
		protected void CreateMarker(MarkerData markerData, CommonObjectStatus target = null, int actionId = -1, CommonObjectStatus targetObject = null);
		private ChargeMarker CreateMarkerToTarget(CommonObjectStatus target, MarkerData markerData);
	}
}
