/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GrowthManaCircleKnightsStoryPopup : CommonPopup
	{
		// Fields
		public Image icon;
		public UnityEngine.UI.Text characterName;
		public UnityEngine.UI.Text storyName;
		public GameObject alertText;
		public Action popAnimationEndedCallBack;
	
		// Constructors
		public GrowthManaCircleKnightsStoryPopup();
	
		// Methods
		public static GrowthManaCircleKnightsStoryPopup Create();
		public void SetParameters(GrowthManaCircleModel model, UnitStoryElement element);
		public override void StartShowAnimation(UnityEvent onCompleted = null);
		[CompilerGenerated]
		private void _StartShowAnimation_b__7_0();
	}
}
