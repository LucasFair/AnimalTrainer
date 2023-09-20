using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AnimalTrainer.Model
{
	internal class Animal
	{
		protected private byte _id;
		protected private string _species;
		protected private string _name;
		protected private char _gender;
		protected private string _breedCategory;
		protected private string _pedigree;
		protected private bool _hasSpcCircumstance;
		protected private string _noteCircumstance;
		protected private byte _legNum;
		protected private short _durationPeriod;

		public byte Id
		{
			get { return _id; }
			private set { _id = value; }
		}
		public string Species
		{
			get { return _species; }
			private set { _species = value; }
		}
		public string Name
		{
			get { return _name; }
			private set { _name = value; }
		}
		public char Gender
		{
			get { return _gender; }
			private set { _gender = value; }
		}
		public string BreedCategory
		{
			get { return _breedCategory; }
			private set { _breedCategory = value; }
		}
		public string Pedigree
		{
			get { return _pedigree; }
			private set { _pedigree = value; }
		}
		public bool HasSpcCircumstance
		{
			get { return _hasSpcCircumstance; }
			private set { _hasSpcCircumstance = value; }
		}
		public string NoteCircumstance
		{
			get { return _noteCircumstance; }
			private set { _noteCircumstance = value; }
		}
		public byte LegNum
		{
			get { return _legNum; }
			private set { _legNum = value; }
		}
		public short DurationPeriod
		{
			get { return _durationPeriod; }
			private set { _durationPeriod = value; }
		}

		/*
		protected internal Animal(byte id, string species, string name, char gender, string breedCategory,
			string pedigree, bool hasSpcCircumstance, string noteCircumstance, byte legNum, short durationPeriod)
		*/
		protected internal Animal()
		{
			_id = 0;
			_species = null;
			_name = null;
			_gender = 'X';
			_breedCategory = null;
			_pedigree = null;
			_hasSpcCircumstance = false;
			if (_hasSpcCircumstance == true)
			{
				_noteCircumstance = null;
			}
			_legNum = 0;
			_durationPeriod = 0;
		}
		protected internal Animal(byte id) : this()
		{
			_id = id;
		}
		protected internal Animal(byte id, string species, string name, char gender, string breedCategory, 
			string pedigree) : this(id)
		{
			_species = species;
			_name = name;
			_gender = gender;
			_breedCategory = breedCategory;
			_pedigree = pedigree;
		}
		protected internal Animal(byte id, string species, string name, char gender, string breedCategory, 
			string pedigree, bool hasSpcCircumstance, string noteCircumstance) : this (id, species, name, gender,
				breedCategory, pedigree)
		{
			_hasSpcCircumstance = hasSpcCircumstance;
			if (hasSpcCircumstance == true)
			{
				_noteCircumstance = noteCircumstance;
			}
		}
		protected internal Animal(byte id, string species, string name, char gender, string breedCategory,
			string pedigree, bool hasSpcCircumstance, string noteCircumstance, byte legNum) : this(id, species, name, gender,
				breedCategory, pedigree, hasSpcCircumstance, noteCircumstance)
		{
			_legNum = legNum;
		}
		protected internal Animal(byte id, string species, string name, char gender, string breedCategory,
			string pedigree, bool hasSpcCircumstance, string noteCircumstance, byte legNum, 
			short durationPeriod) : this(id, species, name, gender,
				breedCategory, pedigree, hasSpcCircumstance, noteCircumstance, legNum)
		{
			_durationPeriod = durationPeriod;
		}


	}
}
