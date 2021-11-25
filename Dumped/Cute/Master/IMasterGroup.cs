using System.Collections.Generic;
using SerializableCollections;
using UnityEngine;

namespace Cute.Master
{
	public abstract class IMasterGroup<T, U, E> : IMasterGroupBase where T : IMasterGroupElement, new()where U : IMasterGroupBase, new()where E : SerializableDictionary<int, T>, new()
	{
		private static U instance;

		[SerializeField]
		private E dict;

		public static U Instance
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public T Get(int id)
		{
			return (T)null;
		}

		public List<int> GetIdList()
		{
			return null;
		}

		public List<T> GetAllInstances()
		{
			return null;
		}

		protected virtual void OnEnable()
		{
		}

		public static void Clear()
		{
		}
	}
}
