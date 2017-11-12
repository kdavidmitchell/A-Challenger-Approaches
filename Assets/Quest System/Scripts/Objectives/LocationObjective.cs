using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QuestSystem
{
    public class LocationObjective : IQuestObjective
    {
        private string title;
        private string description;
        private bool isComplete;
        private bool isBonus;
        private Location targetLocation; //zone, 2D coord, 3D coord

        public string Description
        {
            get
            {
                return description;
            }
        }

        public string Title
        {
            get
            {
                return title;
            }
        }

        public bool IsComplete
        {
            get
            {
                return isComplete;
            }
        }

        public bool IsBonus
        {
            get
            {
                return isBonus;
            }
        }

        public void UpdateProgress()
        {
            throw new NotImplementedException();
        }

        public void CheckProgress()
        {
            if (Player.GetLocation.Compare(targetLocation))
                isComplete = true;
            else
                isComplete = false;
        }
    }
}