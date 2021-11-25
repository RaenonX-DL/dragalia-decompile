using UnityEngine;

namespace Gluon
{
	public class PlayerFootMarkMulti : MonoBehaviour
	{
		[SerializeField]
		[Header("component")]
		private MeshRenderer multiMeshRenderer;

		[HideInInspector]
		public CharacterBase chara;

		private GameObject multiGo;

		private bool valid;

		private bool visible;

		private bool isControlledCharacter;

		private bool isPartyMember;

		private PlayerEventReceiver charaEventReceiver;

		public void Initialize()
		{
		}

		private void OnDestroy()
		{
		}

		private void LateUpdate()
		{
		}

		public void AttachMark(CharacterBase chara, bool isPartyMember)
		{
		}

		public bool DetachMark(CharacterBase chara)
		{
			return default(bool);
		}

		public void DetachMark()
		{
		}

		public void SetPlayerGroupMesh(Mesh mesh)
		{
		}

		public bool Visible(CharacterBase chara, bool b)
		{
			return default(bool);
		}

		public void Visible(bool b)
		{
		}

		private void Visible()
		{
		}

		private bool CanActivateMarker()
		{
			return default(bool);
		}

		private void CheckControlledCharacter()
		{
		}
	}
}
