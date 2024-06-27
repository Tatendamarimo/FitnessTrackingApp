namespace FitnessTrackingApp.Model
{
    public class Goal
    {
        // Properties
        private int goalID;

        private int userID;
        private string goalType;
        private int targetValue;
        private int caloriesToBurn;

        public int GoalID
        {
            get
            {
                return goalID;
            }
            set
            {
                goalID = value;
            }
        }

        public int UserID
        {
            get
            {
                return userID;
            }
            set
            {
                userID = value;
            }
        }

        public string GoalType
        {
            get
            {
                return goalType;
            }
            set
            {
                goalType = value;
            }
        }

        public int TargetValue
        {
            get
            {
                return targetValue;
            }
            set
            {
                targetValue = value;
            }
        }

        public int CaloriesToBurn
        {
            get
            {
                return caloriesToBurn;
            }
            set
            {
                caloriesToBurn = value;
            }
        }

        // Constructor
        public Goal(int userID, string goalType, int targetValue, int caloriesToBurn)
        {
            UserID = userID;
            GoalType = goalType;
            TargetValue = targetValue;
            CaloriesToBurn = caloriesToBurn;
        }

        public Goal()
        { }
    }
}