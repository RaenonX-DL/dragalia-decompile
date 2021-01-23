/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MatchingStampPage : MonoBehaviour
	{
		// Fields
		public Image[] buttonImages;
		public GameObject[] buttonGOs;
		private List<int> stampIdList;
		public Action<int> onIconClicked;
	
		// Constructors
		public MatchingStampPage();
	
		// Methods
		public void SetupByIndex(int startIndex, int endIndex, Action<int> onIconClicked);
		public void OnIconClick(int index);
	}
}
