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
		private MaterilPropertyRenderer[] _materilPropertyDataArray;
		private float _time;
		private int _frame;
		private TaskLabel _taskLabel;
		private float _frameRate;
	
		// Properties
		public float timeScale { get; set; }
		public MaterilPropertyRenderer[] materilPropertyDataArray { get; }
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
