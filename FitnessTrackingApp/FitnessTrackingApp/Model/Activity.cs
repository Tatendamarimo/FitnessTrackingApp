namespace FitnessTrackingApp.Model
{
    public class Activity
    {
        // Properties
        private int userID;

        private string activityType;
        private string metric1;
        private string metric2;
        private string metric3;

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

        public string ActivityType
        {
            get
            {
                return activityType;
            }
            set
            {
                activityType = value;
            }
        }

        public string Metric1
        {
            get
            {
                return metric1;
            }
            set
            {
                metric1 = value;
            }
        }

        public string Metric2
        {
            get
            {
                return metric2;
            }
            set
            {
                metric2 = value;
            }
        }

        public string Metric3
        {
            get
            {
                return metric3;
            }
            set
            {
                metric3 = value;
            }
        }

        // Constructor
        public Activity(int userID, string activityType, string metric1, string metric2, string metric3)
        {
            UserID = userID;
            ActivityType = activityType;
            Metric1 = metric1;
            Metric2 = metric2;
            Metric3 = metric3;
        }

        public Activity()
        { }
    }
}