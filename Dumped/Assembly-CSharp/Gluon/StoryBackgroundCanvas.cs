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
	public class StoryBackgroundCanvas : MonoBehaviour
	{
		// Fields
		[SerializeField]
		public Canvas uiCanvas;
		public StoryBackgroundBillboard[] backgrounds;
		public GameObject billboardParent;
		[SerializeField]
		public GameObject rootObject;
		[SerializeField]
		public Image backgroundFrameImage;
		[SerializeField]
		public CanvasGroup backgroundFrameGroup;
		[SerializeField]
		public Image chapterIntroFrameImage;
		[SerializeField]
		public CanvasGroup chapterIntroFrameGroup;
		[SerializeField]
		public Image backgroundLayerImage;
		[SerializeField]
		public CanvasGroup backgroundLayerGroup;
		[SerializeField]
		public Image backgroundSubLayerImage;
		[SerializeField]
		public CanvasGroup backgroundSubLayerGroup;
	
		// Constructors
		public StoryBackgroundCanvas();
	
		// Methods
		public void SetIngameCuttSetting();
		private void OnDestroy();
	}
}
