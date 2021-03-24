/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace FLATOUT.Main
{
	[Serializable]
	public class FlObjectParameter : FlObjectParameterBase
	{
		// Fields
		public string _childMotionID;
		public FlMotion.ResetModeTypes _motionResetModeType;
	
		// Properties
		public string ChildMotionID { get; set; }
		public FlMotion.ResetModeTypes MotionResetModeType { get; set; }
	
		// Constructors
		public FlObjectParameter();
	
		// Methods
		public override void _CreateEditorData(FlMotion parentMotion);
		public override void _Initialize();
		public override void _CreateHierarchy(FlRoot root, GameObject parentObject);
		public override void _ApplyData(FlMotion parentMotion);
	}
}
