using System;
using System.Collections.Generic;
using UnityEngine;

namespace FLATOUT.Main
{
	[Serializable]
	public class FlKeyParameter
	{
		public List<Vector2> _keyList;

		[NonSerialized]
		public int _keyCount;

		public List<Vector2> KeyList
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float _GetValue(float original, FlMotion motion, ref int startIndex)
		{
			return default(float);
		}
	}
}
