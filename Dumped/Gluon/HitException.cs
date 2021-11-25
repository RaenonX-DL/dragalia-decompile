using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	public class HitException
	{
		private class HitVictim
		{
			public GameObject victim;

			public float durationSec;
		}

		private List<HitVictim> _hitVictims;

		private List<HitVictim> _removedVictims;

		private bool useErrorElimination;

		public int HitVictimNum => default(int);

		public void SetUseErrorElimination(bool useErrorElimination)
		{
		}

		public void AddHitVictims(GameObject victim, float durationSec)
		{
		}

		public bool IsExcept(GameObject victim)
		{
			return default(bool);
		}

		public void Clear()
		{
		}

		public void Remove(GameObject victim)
		{
		}

		public void Update()
		{
		}

		public void Update(float deltaTime)
		{
		}

		public bool ContainsGameObject(GameObject obj)
		{
			return default(bool);
		}
	}
}
