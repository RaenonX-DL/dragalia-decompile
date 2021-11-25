using System;
using UnityEngine;

namespace FLATOUT.Main
{
	[Serializable]
	public class FlObjectParameter : FlObjectParameterBase
	{
		public string _childMotionID;

		public FlMotion.ResetModeTypes _motionResetModeType;

		public string ChildMotionID
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public FlMotion.ResetModeTypes MotionResetModeType
		{
			get
			{
				return default(FlMotion.ResetModeTypes);
			}
			set
			{
			}
		}

		public override void _CreateEditorData(FlMotion parentMotion)
		{
		}

		public override void _Initialize()
		{
		}

		public override void _CreateHierarchy(FlRoot root, GameObject parentObject)
		{
		}

		public override void _ApplyData(FlMotion parentMotion)
		{
		}
	}
}
