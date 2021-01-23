/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class DropItemBright : FastUpdateMonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		private Image baseImage;
		[SerializeField]
		private Image brightImage0;
		[SerializeField]
		private Image brightImage1;
		private Tweener baseTweener;
		private Tweener brightTweener;
	
		// Constructors
		public DropItemBright();
	
		// Methods
		public static DropItemBright Create(GameObject parent, GameObject prefab);
		private void Initialize();
		public void Play();
		public bool IsPlaying();
		public void Stop();
		public void SetAlpha(float alpha);
		[CompilerGenerated]
		private void _Initialize_b__6_0(float x);
		[CompilerGenerated]
		private void _Initialize_b__6_1(float x);
	}
}
