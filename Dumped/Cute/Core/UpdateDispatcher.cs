using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cute.Core
{
	public class UpdateDispatcher : MonoBehaviour
	{
		private const int startListCount = 16;

		private static UpdateDispatcher instance;

		private IUpdatable[] list;

		private int tail;

		private static bool isQuit;

		private Dictionary<IUpdatable, int> indexList;

		private bool dirty;

		private static UpdateDispatcher Instance => null;

		private void Update()
		{
		}

		private void OnApplicationQuit()
		{
		}

		public static void AddItem(IUpdatable item)
		{
		}

		private void AddItemInternal(IUpdatable item)
		{
		}

		public static void RemoveItem(IUpdatable item)
		{
		}

		private void RemoveItemInternal(IUpdatable item)
		{
		}

		public new static Coroutine StartCoroutine(IEnumerator coroutine)
		{
			return null;
		}

		public new static void StopCoroutine(Coroutine coroutine)
		{
		}
	}
}
