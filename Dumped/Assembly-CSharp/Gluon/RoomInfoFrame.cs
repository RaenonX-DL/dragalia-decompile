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
	public class RoomInfoFrame : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Text questInfoText;
		[SerializeField]
		private GameObject questDifficultyIconRoot;
		[SerializeField]
		private GameObject questElementIconRoot;
		private GameObject questDifficultyIconObj;
		private GameObject questElementIconObj;
	
		// Constructors
		public RoomInfoFrame();
	
		// Methods
		public void Initialize(int questId);
	}
}
