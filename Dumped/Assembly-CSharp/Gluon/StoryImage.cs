/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class StoryImage
	{
		// Fields
		public Vector3 completePosition;
		public Vector3 completeScale;
		public bool completeVisible;
		public Color completeColor;
		public float completeRotate;
		public Image image;
		public CanvasGroup group;
		public Vector2 initPos;
		public List<Tweener> currentTweenList;
	
		// Constructors
		public StoryImage();
	
		// Methods
		public virtual void SetCompleteData();
		public virtual void SetVisible(bool visible);
		public virtual void SetColor(Color color);
		public void SetPosition(Vector3 position);
		public void SetScale(Vector3 scale);
		public void SetRotate(float rotate);
		public void KillTweenList(bool complete = false);
	}
}
