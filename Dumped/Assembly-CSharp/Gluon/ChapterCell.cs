/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ChapterCell : MonoBehaviour
	{
		// Fields
		public UnityEngine.UI.Text cellTitle;
		public int cellTag;
		[SerializeField]
		public StoryButtonEvent buttonPressed;
	
		// Constructors
		public ChapterCell();
	
		// Methods
		public void OnButtonPressed();
	}
}
