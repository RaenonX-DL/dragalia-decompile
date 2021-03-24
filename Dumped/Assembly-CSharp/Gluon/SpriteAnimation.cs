/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[RequireComponent]
	public class SpriteAnimation : MonoBehaviour
	{
		// Fields
		public Image image;
		public Sprite[] clip;
		[Header]
		[SerializeField]
		public float interval;
		private int currentClipIndex;
		private int maxIndex;
		private float currentTime;
	
		// Constructors
		public SpriteAnimation();
	
		// Methods
		private void Awake();
		private void Update();
	}
}
