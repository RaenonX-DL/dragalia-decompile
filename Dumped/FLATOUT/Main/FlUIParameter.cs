using System;
using System.Collections;
using System.Collections.Generic;

namespace FLATOUT.Main
{
	[Serializable]
	public class FlUIParameter
	{
		public FlUITypes _uiType;

		public List<string> _parameterKeyList;

		public List<string> _parameterValueList;

		private Hashtable _parameterTable;

		public FlUITypes UIType
		{
			get
			{
				return default(FlUITypes);
			}
			set
			{
			}
		}

		public List<string> ParameterKeyList
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<string> ParameterValueList
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void _CreateData(FlObjectBase objectBase)
		{
		}

		public void _CreateParameterTable()
		{
		}

		public string _GetParameterValue(string key, int type = 0)
		{
			return null;
		}
	}
}
