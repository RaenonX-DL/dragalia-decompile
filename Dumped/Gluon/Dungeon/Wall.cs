using System.Collections.Generic;
using UnityEngine;

namespace Gluon.Dungeon
{
	public class Wall : MonoBehaviour
	{
		[SerializeField]
		[HideInInspector]
		public List<GameObject> _targetGenerator;

		[SerializeField]
		[HideInInspector]
		public GameObject _entryPopTrigger;

		protected bool _isOpen;

		protected MeshCollider[] meshColliders;

		private BoxCollider _entryPopTriggerCollider;

		protected EffectObject _goEffect;

		[SerializeField]
		[Lock]
		protected string effectLabelWallClose;

		[SerializeField]
		protected Vector3 effectScaleBase;

		[SerializeField]
		protected Vector3 effectScaleDefault;

		[SerializeField]
		[Lock]
		protected string soundIdWallClose;

		[SerializeField]
		protected GameObject _goModel;

		protected Animator _animator;

		public bool isOpen => default(bool);

		protected virtual void OnDestroy()
		{
		}

		protected virtual void Start()
		{
		}

		private void OnTriggerEnter(Collider col)
		{
		}

		public virtual void Opened(bool sw)
		{
		}

		protected bool CheckOpen()
		{
			return default(bool);
		}

		public bool CheckGeneratorAlive()
		{
			return default(bool);
		}

		protected virtual void OnTriggerEvent()
		{
		}

		public bool IsEnemyPopped()
		{
			return default(bool);
		}

		protected virtual void InitializeDrawModel()
		{
		}

		protected virtual void DestroyDrawModel()
		{
		}

		protected virtual void DrawModelOpen(bool isOpenFlag)
		{
		}
	}
}
