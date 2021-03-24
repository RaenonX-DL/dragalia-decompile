/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[ExecuteAlways]
	public class CommonTagSearch : MonoBehaviour
	{
		// Fields
		public InputField inputField;
		public GameObject placeholderAttachment;
		public Action<List<int>> onFilterChanged;
		[CompilerGenerated]
		private CommonTagSearchModel _model_k__BackingField;
	
		// Properties
		public CommonTagSearchModel model { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Constructors
		public CommonTagSearch();
	
		// Methods
		private void Start();
		public void SetInput(string toText);
		private void Update();
		public void RaiseOnTextChanged();
		private void OnInputTextChanged(string s);
		[CompilerGenerated]
		private void _Start_b__7_0(string s);
	}
}
