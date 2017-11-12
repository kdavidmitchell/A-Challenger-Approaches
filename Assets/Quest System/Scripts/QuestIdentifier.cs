using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace QuestSystem
{
    public class QuestIdentifier : IQuestIdentifier
    {
        private int questID;
        private int chainQuestID;
        private int sourceID;

        public int ChainQuestID
        {
            get
            {
                return chainQuestID;
            }
        }

        public int QuestID
        {
            get
            {
                return questID;
            }
        }

        public int SourceID
        {
            get
            {
                return sourceID;
            }
        }
    }
}
