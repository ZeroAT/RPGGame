﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Player : INotifyPropertyChanged
    {
        private string _name;
        private string _characterClass;
        private int _hitPoints;
        private int _experiencePoints;
        private int _level;
        private int _gold;



        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                onPropertyChanged("Name");
            }
        }
        public string CharacterClass
        {
            get { return _characterClass; }
            set
            {
                _characterClass = value;
                onPropertyChanged("characterClass");
            }
        }
        public int HitPoints
        {
            get { return _hitPoints; }
            set
            {
                _hitPoints = value;
                onPropertyChanged("HitPoints");
            }
        }
        public int ExperiencePoints
        {
            get { return _experiencePoints; }
            set {
                _experiencePoints = value;
                onPropertyChanged("ExperiencePoints");
            }
        }

        public int Level
        {
            get { return _level; }
            set
            {
                _level = value;
                onPropertyChanged("Level");
            }
        }

        public int Gold
        {
            get { return _experiencePoints; }
            set
            {
                _gold = value;
                onPropertyChanged("Gold");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void onPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
