using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalTrainer.Model
{
	internal class Canine : Animal
	{
		protected private bool _hasFur;
		protected private char _furLength;
		protected private string _tailType;
		protected private string _tailHeight;

		public bool HasFur
		{
			get { return _hasFur; }
			private set { _hasFur = value; }
		}
		public char FurLength
		{
			get { return _furLength; }
			private set { _furLength = value; }
		}
		public string TailType
		{
			get { return _tailType; }
			private set { _tailType = value; }
		}
		public string TailHeight
		{
			get { return _tailHeight; }
			private set { _tailHeight = value; }
		}

		protected internal Canine()
		{
			_hasFur = true;
			_furLength = 'X';
			_tailHeight = null;
			_tailType = null;
		}

		protected internal Canine(string tailHeight, string tailType) : this()
		{
			_tailHeight = tailHeight;
			_tailType = tailType;
		}
		protected internal Canine(string tailHeight, string tailType, bool hasFur, char furLength) : this(tailHeight, tailType)
		{
			_hasFur = hasFur;
			_furLength = furLength;
		}
	}
}
