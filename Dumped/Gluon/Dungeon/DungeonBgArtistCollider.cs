using UnityEngine;

namespace Gluon.Dungeon
{
	public class DungeonBgArtistCollider : MonoBehaviour
	{
		[SerializeField]
		private bool isHit;

		public bool IsHit()
		{
			return default(bool);
		}

		private void Awake()
		{
		}

		public void OnTriggerEnter(Collider other)
		{
		}
	}
}
