using System;
using System.Collections;
using System.Collections.Generic;

namespace FLATOUT.Main
{
	[Serializable]
	public class FlMotionParameterGroup
	{
		public List<FlMotionParameter> _motionParameterList;

		private Hashtable _motionParameterTable;

		public List<FlMotionParameter> MotionParameterList
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Hashtable MotionParameterTable
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void _Initialize()
		{
		}

		public FlMotionParameter _GetMotionParameter(string id)
		{
			return null;
		}
	}
}
