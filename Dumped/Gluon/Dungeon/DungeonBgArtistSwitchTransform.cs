using System;
using System.Collections.Generic;
using UnityEngine;

namespace Gluon.Dungeon
{
	public class DungeonBgArtistSwitchTransform : ProductionTimeCallback
	{
		public enum UpdateKind
		{
			None,
			World,
			Local
		}

		[Serializable]
		public class SwitchData
		{
			public int id;

			public UpdateKind posKind;

			public Vector3 setPos;

			public UpdateKind rotKind;

			public Vector3 setRot;
		}

		public static readonly int dataIdReset;

		[SerializeField]
		private int dataIdProductionTime;

		public List<SwitchData> switchDataList;

		private static List<DungeonBgArtistSwitchTransform> scrList;

		protected override void Awake()
		{
		}

		public SwitchData GetOriginalData(bool fullSet)
		{
			return null;
		}

		private void OnDestroy()
		{
		}

		public static void SetSwitchId(int id)
		{
		}

		public void SetData(int id)
		{
		}

		private void SetData(SwitchData tempData)
		{
		}

		public override void OnProductionTime()
		{
		}
	}
}
