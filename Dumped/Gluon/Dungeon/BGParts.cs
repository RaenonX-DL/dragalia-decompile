using System;
using UnityEngine;

namespace Gluon.Dungeon
{
	public class BGParts : MonoBehaviour
	{
		[Flags]
		public enum BGPartsFlags
		{

		}

		[SerializeField]
		[EnumFlags]
		private BGPartsFlags partsFlags;

		public BGPartsFlags PartsFlags => default(BGPartsFlags);

		public void OrPartsFlag(BGPartsFlags f)
		{
		}

		public void ResetPartsFlag(BGPartsFlags f)
		{
		}

		public void ClearPartsFlag()
		{
		}

		public bool IsPartsFlags(BGPartsFlags f)
		{
			return default(bool);
		}
	}
}
