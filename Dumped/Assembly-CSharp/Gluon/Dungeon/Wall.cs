/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon
{
	public class Wall : MonoBehaviour
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		public List<GameObject> _targetGenerator;
		[HideInInspector]
		[SerializeField]
		public GameObject _entryPopTrigger;
		protected bool _isOpen;
		protected MeshCollider[] meshColliders;
		private BoxCollider _entryPopTriggerCollider;
		protected EffectObject _goEffect;
		[Lock]
		[SerializeField]
		protected string effectLabelWallClose;
		[SerializeField]
		protected Vector3 effectScaleBase;
		[SerializeField]
		protected Vector3 effectScaleDefault;
		[Lock]
		[SerializeField]
		protected string soundIdWallClose;
		[SerializeField]
		protected GameObject _goModel;
		protected Animator _animator;
	
		// Properties
		public bool isOpen { get; }
	
		// Constructors
		public Wall();
	
		// Methods
		protected virtual void OnDestroy();
		protected virtual void Start();
		private void OnTriggerEnter(Collider col);
		public virtual void Opened(bool sw);
		protected bool CheckOpen();
		public bool CheckGeneratorAlive();
		protected virtual void OnTriggerEvent();
		public bool IsEnemyPopped();
		protected virtual void InitializeDrawModel();
		protected virtual void DestroyDrawModel();
		protected virtual void DrawModelOpen(bool isOpenFlag);
	}
}
