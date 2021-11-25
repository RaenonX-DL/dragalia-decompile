using System.Collections.Generic;
using Gluon.Event;
using UnityEngine;

namespace Gluon
{
	public class BRAiChecker
	{
		private class AiCheckData
		{
			public int prevHp;

			public Vector3 lastPosition;

			public float lastMoveTime;
		}

		private Dictionary<CharacterId, AiCheckData> aiCheckDataMap;

		private const float aiCheckIntervalTimer = 15f;

		private float aiCheckTimer;

		public void UpdateAiCheck(BRCtrl brCtrl)
		{
		}
	}
}
