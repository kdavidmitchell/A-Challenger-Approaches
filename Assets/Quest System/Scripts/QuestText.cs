using System;

namespace QuestSystem
{
    public class QuestInformation : IQuestText
    {

        private string title;
        private string descriptionSummary;
        private string dialogue;
        private string hint;

        public string DescriptionSummary
        {
            get
            {
                return descriptionSummary;
            }
        }

        public string Dialogue
        {
            get
            {
                return dialogue;
            }
        }

        public string Hint
        {
            get
            {
                return hint;
            }
        }

        public string Title
        {
            get
            {
                return title;
            }
        }
    }
}