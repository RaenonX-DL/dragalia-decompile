using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	[ExecuteAlways]
	public class CommonTagSearch : MonoBehaviour
	{
		public InputField inputField;

		public GameObject placeholderAttachment;

		public Action<List<int>> onFilterChanged;

		public CommonTagSearchModel model
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private void Start()
		{
		}

		public void SetInput(string toText)
		{
		}

		private void Update()
		{
		}

		public void RaiseOnTextChanged()
		{
		}

		private void OnInputTextChanged(string s)
		{
		}
	}
}
