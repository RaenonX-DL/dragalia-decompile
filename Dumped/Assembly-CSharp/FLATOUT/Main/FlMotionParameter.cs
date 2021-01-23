/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace FLATOUT.Main
{
	[Serializable]
	public class FlMotionParameter
	{
		// Fields
		public string _id;
		public string _name;
		public FlLabelParameter[] _labelParamList;
		public List<FlObjectParameter> _objectParamList;
		public List<FlPlaneParameter> _planeParamList;
		public List<FlTextParameter> _textParamList;
		private List<FlObjectParameterBase> _objcectParamBaseList;
		private Hashtable _labelIndexTable;
	
		// Properties
		public string ID { get; set; }
		public string Name { get; set; }
		public FlLabelParameter[] LabelParamList { get; set; }
		public List<FlObjectParameter> ObjectParamList { get; set; }
		public List<FlPlaneParameter> PlaneParamList { get; set; }
		public List<FlTextParameter> TextParamList { get; set; }
		public Hashtable LabelIndexTable { get; }
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Comparison<FlObjectParameterBase> __9__32_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int __CreateObjectParamBaseList_b__32_0(FlObjectParameterBase a, FlObjectParameterBase b);
		}
	
		// Constructors
		public FlMotionParameter();
	
		// Methods
		public void _Initialize();
		public virtual void _CreateHierarchy(FlRoot root, GameObject parentObject);
		public void _ApplyData(FlObject parentObject, FlRoot root);
		public void _CreateEditorData(FlObject parentObject, FlRoot root);
		private void _CreateObjectParamBaseList();
		public void _UpdateMotionTime(FlMotion motion);
		private bool _ExecuteAction(FlMotion motion, ref bool existFlag, Action action, bool playOneTime = true);
		private bool _ExecuteFlAction(FlMotion motion, ref bool existFlag, FlAction flAction, bool playOneTime = true);
		public FlLabelParameter _GetLabel(string labelName);
		public FlLabelParameter _GetLabel(float time);
		public int _GetLabelIndex(string labelName);
		public bool _ExistLabel(string labelName);
		public void _SetCurrentLabel(FlMotion motion, string labelName);
		public void _SetCurrentLabel(FlMotion motion, float time);
		private void _SetMotionLabelData(FlMotion motion, FlLabelParameter label, float time);
		public void _SetMotionAction(FlMotion motion, string labelName);
	}
}
