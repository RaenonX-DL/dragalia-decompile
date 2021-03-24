/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MonsterLibraryListBase : MonoBehaviour
	{
		// Fields
		public UnityAction sortButtonAction;
		public UnityAction<int> IconButtonAction;
		[SerializeField]
		private UnityEngine.UI.Text ListDataText;
	
		// Constructors
		public MonsterLibraryListBase();
	
		// Methods
		public void SetListData(int found, int complete);
		public void SortButtonPressed();
	}
}
