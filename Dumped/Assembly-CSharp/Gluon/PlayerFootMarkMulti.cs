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
	public class PlayerFootMarkMulti : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		private MeshRenderer multiMeshRenderer;
		[HideInInspector]
		public CharacterBase chara;
		private GameObject multiGo;
		private bool valid;
		private bool visible;
		private bool isControlledCharacter;
		private bool isPartyMember;
		private PlayerEventReceiver charaEventReceiver;
	
		// Constructors
		public PlayerFootMarkMulti();
	
		// Methods
		public void Initialize();
		private void OnDestroy();
		private void LateUpdate();
		public void AttachMark(CharacterBase chara, bool isPartyMember);
		public bool DetachMark(CharacterBase chara);
		public void DetachMark();
		public void SetPlayerGroupMesh(Mesh mesh);
		public bool Visible(CharacterBase chara, bool b);
		public void Visible(bool b);
		private void Visible();
		private bool CanActivateMarker();
		private void CheckControlledCharacter();
	}
}
