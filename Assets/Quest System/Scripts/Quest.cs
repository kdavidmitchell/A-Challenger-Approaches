using System.Collections.Generic;
namespace QuestSystem
{
    public class Quest
    {
        //Name
        //Description summary
        //Quest hint
        //Quest dialogue
        //SourceID
        //QuestID
        //Chain quest and the next quest is blank
        //ChainQuestID

        //Objectives
        private List<IQuestObjective> objectives;
            //Collection
            //Location
        //Bonus objectives
        //Rewards
        //Events
            //on completion
            //on failed
            //on update

        private bool IsComplete()
        {
            for (int i = 0; i < objectives.Count; i++)
            {
                if (objectives[i].IsComplete == false && objectives[i].IsBonus == false)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

