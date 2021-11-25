using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon
{
	public class DragonRelayCtrl : MonoBehaviour
	{
		private List<CharacterSelector> reservedCharas;

		public bool isFollowerActive
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		public IEnumerator NextWave(int waveCnt, int maxWaveIndex)
		{
			return null;
		}

		private float GetCameraFollowRateFunc()
		{
			return default(float);
		}

		private void SetPosAndRot(CharacterSelector charaSelector, Vector3 pos, Quaternion rot)
		{
		}

		private void WarpToSafeArea(CharacterSelector activateSelector)
		{
		}

		public bool IsReservedChara(CharacterSelector selector)
		{
			return default(bool);
		}
	}
}
