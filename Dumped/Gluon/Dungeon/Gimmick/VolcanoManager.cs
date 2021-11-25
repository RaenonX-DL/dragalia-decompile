using System.Collections;
using UnityEngine;

namespace Gluon.Dungeon.Gimmick
{
	public class VolcanoManager : MonoBehaviour
	{
		public static VolcanoManager instance;

		private int eruptionStep;

		[SerializeField]
		private float[] eruptionIntervalSecArray;

		[SerializeField]
		private string effectLabelEruption;

		[SerializeField]
		private int effectTriggerIdEruption;

		private EffectObject effectObj;

		public string effectLabelBurnBush;

		public int effectTriggerBurnBush;

		public string effectLabelBreakHouse;

		public int effectTriggerBreakHouse;

		public static readonly int effectPoolCountBurn;

		[SerializeField]
		private string soundLabelEruption;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private IEnumerator CoEruption()
		{
			return null;
		}
	}
}
