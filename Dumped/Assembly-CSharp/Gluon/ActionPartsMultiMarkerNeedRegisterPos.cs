/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.ActionData;
using Gluon.Event;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ActionPartsMultiMarkerNeedRegisterPos : ActionPartsMarker
	{
		// Fields
		private readonly MultiMarkerNeedRegisterPositionData _partsData;
		private RandomXorshift _random;
		private RunActionRandomParameter _runActionParam;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Comparison<CharacterBase> __9__8_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _CreateMarkerMultiControlPlayers_b__8_0(CharacterBase a, CharacterBase b);
		}
	
		// Constructors
		public ActionPartsMultiMarkerNeedRegisterPos(ActionParts resource);
	
		// Methods
		public override RunActionParameterBase CreateRunActionParameter();
		public override void SetRunActionParameter(RunActionParameterBase param);
		protected override void OnStart();
		private void CreateMarkerAreaAnchorRandomOffsetAddAnchorPos(MultiMarkerNeedRegisterPositionData srcData);
		private void CreateMarkerMultiControlPlayers(MultiMarkerNeedRegisterPositionData srcData);
		protected void CreateMarker(MarkerData srcData, Vector3 position);
	}
}
