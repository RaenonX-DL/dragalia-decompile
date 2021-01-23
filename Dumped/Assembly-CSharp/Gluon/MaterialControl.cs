/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using Gluon.GraphicParameter;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MaterialControl : FastUpdateMonoBehaviour
	{
		// Fields
		[SerializeField]
		private float _timeScale;
		private MaterialPropertyRenderer[] _materilPropertyDataArray;
		private float _time;
		private int _frame;
		private TaskLabel _taskLabel;
		private float _frameRate;
	
		// Properties
		public float timeScale { get; set; }
		public MaterialPropertyRenderer[] materilPropertyDataArray { get; }
		public float time { get; }
		public int frame { get; }
	
		// Nested types
		private enum TaskLabel
		{
			Wait = 0,
			Play = 1,
			Stop = 2,
			Pause = 3
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass22_0
		{
			// Fields
			public Renderer[] renderers;
			public int i;
	
			// Constructors
			public __c__DisplayClass22_0();
	
			// Methods
			internal bool _Awake_b__0(MaterialPropertyRenderer.RendererData x);
		}
	
		// Constructors
		public MaterialControl();
	
		// Methods
		public static float GetSecondFromFrame(float frame);
		public static int GetFrameFromSecond(float sec);
		public void Play();
		public void Stop();
		public void Pause();
		public void AddFrame();
		private void Awake();
		public override void FastUpdate();
		private void LateUpdate();
	}
}
