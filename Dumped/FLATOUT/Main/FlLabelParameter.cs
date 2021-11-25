using System;
using System.Collections;
using UnityEngine;

namespace FLATOUT.Main
{
	[Serializable]
	public class FlLabelParameter
	{
		public string _name;

		public Vector2 _timeRange;

		public string _nextLabel;

		[NonSerialized]
		public int _Index;

		[NonSerialized]
		public int _nextIndex;

		public Hashtable _actionStartTable;

		public Hashtable _actionLoopTable;

		public Hashtable _actionEndTable;

		public Hashtable _flActionStartTable;

		public Hashtable _flActionLoopTable;

		public Hashtable _flActionEndTable;

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

		public Vector2 TimeRange
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public string NextLabel
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int Index
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public int NextIndex
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public Hashtable ActionStartTable
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Hashtable ActionLoopTable
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Hashtable ActionEndTable
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Hashtable FlActionStartTable
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Hashtable FlActionLoopTable
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Hashtable FlActionEndTable
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
	}
}
