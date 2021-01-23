/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cutt
{
	public class CuttTimelineFade
	{
		// Fields
		private CuttTimelineKeyFadeDataList _keys;
		private GameObject _canvas;
		private GameObject fadeObject;
		private Image image;
		private Sprite whiteSprite;
	
		// Constructors
		public CuttTimelineFade();
	
		// Methods
		public void Initialize(CuttTimelineKeyFadeDataList keys, CuttTimelineControl timelineControl, GameObject canvasObject, int siblingIndex = -1);
		public void Release();
		public void AlterUpdate(float currentTime, float targetFps, int currentFrame);
	}
}
