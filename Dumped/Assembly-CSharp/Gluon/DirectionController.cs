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
	internal class DirectionController
	{
		// Fields
		private DirectionData[] _dataArray;
		[CompilerGenerated]
		private float _maxPower_k__BackingField;
		[CompilerGenerated]
		private float _attenuationRate_k__BackingField;
		[CompilerGenerated]
		private Vector3 _outDirection_k__BackingField;
		[CompilerGenerated]
		private float _outPower_k__BackingField;
		[CompilerGenerated]
		private Vector4 _startTimeParam_k__BackingField;
	
		// Properties
		public float maxPower { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float attenuationRate { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Vector3 outDirection { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public float outPower { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public Vector4 startTimeParam { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		private struct DirectionData
		{
			// Fields
			public Vector3 direction;
			public float nowPower;
			public float nowPowerRate;
			public bool isStart;
		}
	
		// Constructors
		public DirectionController();
	
		// Methods
		private bool IsEmptyDirection();
		private int GetUseID();
		public static Vector4 GetNowTimeParam();
		public void Init(int count, float maxpower, float attenuationrate);
		public void Update();
		public void SetDirection(Vector3 dirction, float power);
		public void CalcDirection();
	}
}
