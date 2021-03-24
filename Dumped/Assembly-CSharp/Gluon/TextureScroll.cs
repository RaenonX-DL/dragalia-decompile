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
	public class TextureScroll : MaterialControlComponent
	{
		// Fields
		[SerializeField]
		private TextureScrollData[] _textureScrollData;
		[SerializeField]
		[Tooltip]
		private bool enableStopProduction;
	
		// Properties
		public TextureScrollData[] textureScrollData { get; }
	
		// Constructors
		public TextureScroll();
	
		// Methods
		protected override void Awake();
		protected void Reset();
		private void Update();
		public void Play();
		public void Stop();
	}
}
