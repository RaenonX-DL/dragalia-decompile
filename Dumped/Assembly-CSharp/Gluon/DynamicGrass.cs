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
	public class DynamicGrass : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private WaveMode _waveMode;
		[SerializeField]
		private Transform directionTransform;
		[SerializeField]
		private float _maxCollisionPower;
		[Range]
		[SerializeField]
		private float _attenuationCollisionPowerRate;
		[SerializeField]
		private int collisionDataCount;
		private int _WaveDirectionID;
		private int _WaveStartTimeID;
		private int _WavePowerID;
		private Transform _transform;
		private Renderer _renderer;
		private MaterialPropertyBlock _materialPropertyBlock;
		private DirectionController directionController;
	
		// Nested types
		public enum WaveMode
		{
			Always = 0,
			Collision = 1
		}
	
		// Constructors
		public DynamicGrass();
	
		// Methods
		private Vector3 CalcPropertyWaveDirection(Vector4 direction);
		private void SetPropertyWaveStartTime();
		private void Awake();
		private void Start();
		private void Update();
		private void OnTriggerEnter(Collider ollider);
	}
}
