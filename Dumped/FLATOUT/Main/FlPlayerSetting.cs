using System;
using System.Collections.Generic;
using UnityEngine;

namespace FLATOUT.Main
{
	[Serializable]
	public class FlPlayerSetting
	{
		[SerializeField]
		private string _keyInputHorizontalName;

		[SerializeField]
		private string _keyInputVerticalName;

		[SerializeField]
		private string _keyInputSubmitName;

		[SerializeField]
		private string _keyInputCancelName;

		private List<string> _runtimeKeyInputHorizontalNameList;

		private List<string> _runtimeKeyInputVerticalNameList;

		private List<string> _runtimeKeyInputSubmitNameList;

		private List<string> _runtimeKeyInputCancelNameList;

		public List<string> RuntimeKeyInputHorizontalNameList => null;

		public List<string> RuntimeKeyInputVerticalNameList => null;

		public List<string> RuntimeKeyInputSubmitNameList => null;

		public List<string> RuntimeKeyInputCancelNameList => null;

		public void _Initialize()
		{
		}

		public void _ResetKeyInput()
		{
		}

		public void _SetKeyInputHorizontalName(string name)
		{
		}

		public void _SetKeyInputVerticalName(string name)
		{
		}

		public void _SetKeyInputSubmitName(string name)
		{
		}

		public void _SetKeyInputCancelName(string name)
		{
		}
	}
}
