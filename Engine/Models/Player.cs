﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Player : BaseNotificationClass
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
                onPropertyChanged(nameof(Name));
            }
        }
        public string CharacterClass
        {
            get { return _characterClass; }
            set
            {
                _characterClass = value;
                onPropertyChanged(nameof(CharacterClass));
            }
        }
        public int HitPoints
        {
            get { return _hitPoints; }
            set
            {
                _hitPoints = value;
                onPropertyChanged(nameof(HitPoints));
            }
        }
        public int ExperiencePoints
        {
            get { return _experiencePoints; }
            set {
                _experiencePoints = value;
                onPropertyChanged(nameof(ExperiencePoints));
            }
        }

        public int Level
        {
            get { return _level; }
            set
            {
                _level = value;
                onPropertyChanged(nameof(Level));
            }
        }

        public int Gold
        {
            get { return _experiencePoints; }
            set
            {
                _gold = value;
                onPropertyChanged(nameof(Gold));
            }
        }


    }
}
