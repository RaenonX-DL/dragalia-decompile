using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FLATOUT.Main
{
	[Serializable]
	public class FlMotionParameter
	{
		public string _id;

		public string _name;

		public FlLabelParameter[] _labelParamList;

		public List<FlObjectParameter> _objectParamList;

		public List<FlPlaneParameter> _planeParamList;

		public List<FlTextParameter> _textParamList;

		private List<FlObjectParameterBase> _objcectParamBaseList;

		private Hashtable _labelIndexTable;

		public string ID
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public FlLabelParameter[] LabelParamList
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<FlObjectParameter> ObjectParamList
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<FlPlaneParameter> PlaneParamList
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<FlTextParameter> TextParamList
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Hashtable LabelIndexTable => null;

		public void _Initialize()
		{
		}

		public virtual void _CreateHierarchy(FlRoot root, GameObject parentObject)
		{
		}

		public void _ApplyData(FlObject parentObject, FlRoot root)
		{
		}

		public void _CreateEditorData(FlObject parentObject, FlRoot root)
		{
		}

		private void _CreateObjectParamBaseList()
		{
		}

		public void _UpdateMotionTime(FlMotion motion)
		{
		}

		private bool _ExecuteAction(FlMotion motion, ref bool existFlag, Action action, bool playOneTime = true)
		{
			return default(bool);
		}

		private bool _ExecuteFlAction(FlMotion motion, ref bool existFlag, FlAction flAction, bool playOneTime = true)
		{
			return default(bool);
		}

		public FlLabelParameter _GetLabel(string labelName)
		{
			return null;
		}

		public FlLabelParameter _GetLabel(float time)
		{
			return null;
		}

		public int _GetLabelIndex(string labelName)
		{
			return default(int);
		}

		public bool _ExistLabel(string labelName)
		{
			return default(bool);
		}

		public void _SetCurrentLabel(FlMotion motion, string labelName)
		{
		}

		public void _SetCurrentLabel(FlMotion motion, float time)
		{
		}

		private void _SetMotionLabelData(FlMotion motion, FlLabelParameter label, float time)
		{
		}

		public void _SetMotionAction(FlMotion motion, string labelName)
		{
		}
	}
}
