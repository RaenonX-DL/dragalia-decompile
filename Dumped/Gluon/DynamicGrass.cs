using UnityEngine;

namespace Gluon
{
	public class DynamicGrass : MonoBehaviour
	{
		public enum WaveMode
		{
			Always,
			Collision
		}

		[SerializeField]
		private WaveMode _waveMode;

		[SerializeField]
		private Transform directionTransform;

		[SerializeField]
		private float _maxCollisionPower;

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

		private Vector3 CalcPropertyWaveDirection(Vector4 direction)
		{
			return default(Vector3);
		}

		private void SetPropertyWaveStartTime()
		{
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void OnTriggerEnter(Collider ollider)
		{
		}
	}
}
