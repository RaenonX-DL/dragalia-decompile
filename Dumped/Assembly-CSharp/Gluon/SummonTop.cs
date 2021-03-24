/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SummonTop : MonoBehaviour
	{
		// Fields
		public GameObject summonUIContentNode;
		public RectTransform backGround;
		[HideInInspector]
		public SummonScene scene;
		[HideInInspector]
		public SummonTopItemView itemView;
	
		// Constructors
		public SummonTop();
	
		// Methods
		public void LoadMainUI();
		public void RefreshPrice();
		public void DisableButtonsForTutorial(bool enableMultiButton);
		public void OnBeforeSceneLeaving();
		public void FadeOut();
	}
}
