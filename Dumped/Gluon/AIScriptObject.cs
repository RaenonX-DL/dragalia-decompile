using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	public class AIScriptObject : ScriptableObject
	{
		[SerializeField]
		private List<AIScriptContainer> _containers;

		public List<AIScriptContainer> containers => null;

		public static AIScriptObject CreateAssetInstance()
		{
			return null;
		}
	}
}
