using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AnimalTrainer.Model
{
	internal class Fowl
	{
		protected private bool _hasFeathers;
		protected private string _combType;

		public bool HasFeathers
		{
			get { return _hasFeathers; }
			private set { _hasFeathers = value; }
		}
		public string CombType
		{
			get { return _combType; }
			private set { _combType = value; }
		}

		protected internal Fowl()
		{
			_hasFeathers = true;
			_combType = null;
		}

		protected internal Fowl(bool hasFeathers, string combType) : this()
		{
			_hasFeathers = hasFeathers;
			_combType = combType;
		}
	}
}
