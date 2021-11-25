using System.Collections.Generic;
using UnityEngine;

namespace Gluon.Dungeon.Gimmick
{
	public class DontSlipFieldGroup : MonoBehaviour
	{
		private class VictimInfo
		{
			public CharacterSelector chara;

			public int enterCount;

			public bool dontSlip;
		}

		private List<DontSlipField> fields;

		private Dictionary<int, VictimInfo> victimInfoDic;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private int GetInstanceID(GameObject go)
		{
			return default(int);
		}

		private void SetSlipState(VictimInfo info, bool b)
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		private void OnTriggerExit(Collider other)
		{
		}

		private void OnStayField(DontSlipField field, Collider other)
		{
		}

		private void OnExitField(DontSlipField field, Collider other)
		{
		}
	}
}
