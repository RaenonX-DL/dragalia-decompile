/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PlayerFootMark : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		private MeshRenderer circleMeshRenderer;
		[SerializeField]
		private MeshRenderer arrowMeshRenderer;
		[SerializeField]
		private Transform circleRootTrs;
		[SerializeField]
		private Transform arrowRootTrs;
		[Header]
		[SerializeField]
		private Texture2D move;
		[SerializeField]
		private Texture2D attack;
		[SerializeField]
		private Texture2D raid;
		[SerializeField]
		private Texture2D arrow;
		[Header]
		[SerializeField]
		private float rotSpeed;
		private Transform circleTrs;
		private Transform arrowTrs;
		private Material circleMaterial;
		private CharacterBase chara;
		private Type currentType;
		private float lastRotY;
		private float scaleArrow;
		private CameraController cameraCtrl;
		private bool isActiveCircle;
		private bool isActiveArrow;
	
		// Nested types
		public enum Type
		{
			None = 0,
			Move = 1,
			Attack = 2,
			Raid = 3
		}
	
		// Constructors
		public PlayerFootMark();
	
		// Methods
		private void VisibleCircle(bool b, bool force = false);
		private void VisibleArrow(bool b, bool force = false);
		public void Initialize();
		private void OnDestroy();
		private void Update();
		private void LateUpdate();
		private void ChangeMark(Type type);
		public void AttachMark(CharacterBase chara, Type type);
		public void DetachMark(CharacterBase chara);
		public void DetachMark();
		private bool IsInputMove(out Vector3 inputDir);
	}
}
