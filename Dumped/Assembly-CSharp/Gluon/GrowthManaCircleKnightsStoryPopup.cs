/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GrowthManaCircleKnightsStoryPopup : CommonPopup
	{
		// Fields
		public Image icon;
		public UnityEngine.UI.Text characterName;
		public UnityEngine.UI.Text storyName;
		public GameObject alertText;
	
		// Constructors
		public GrowthManaCircleKnightsStoryPopup();
	
		// Methods
		public static GrowthManaCircleKnightsStoryPopup Create();
		public void SetParameters(GrowthManaCircleModel model, UnitStoryElement element);
	}
}
