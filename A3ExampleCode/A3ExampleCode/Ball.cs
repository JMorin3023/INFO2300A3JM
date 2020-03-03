using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3ExampleCode
{
    class Ball
    {
        private string ballName;

        public string BallName
        {
            get { return ballName; }
            set { ballName = value; }
        }

        private int ballHealth;

        public int BallHealth
        {
            get { return ballHealth; }
            set { ballHealth = value; }
        }

        private string ballAttackOneName;
        private int ballAttackOneDamage;

        public string BallAttackOneName
        {
            get { return ballAttackOneName; }
            set { ballAttackOneName = value; }
        }
        public int BallAttackOneDamage
        {
            get { return ballAttackOneDamage; }
            set { ballAttackOneDamage = value; }
        }

        private string ballAttackTwoName;
        private int ballAttackTwoDamage;

        public string BallAttackTwoName
        {
            get { return ballAttackTwoName; }
            set { ballAttackTwoName = value; }
        }
        public int BallAttackTwoDamage
        {
            get { return ballAttackTwoDamage; }
            set { ballAttackTwoDamage = value; }
        }

        private string ballAttackThreeName;
        private int ballAttackThreeDamage;

        public string BallAttackThreeName
        {
            get { return ballAttackThreeName; }
            set { ballAttackThreeName = value; }
        }
        public int BallAttackThreeDamage
        {
            get { return ballAttackThreeDamage; }
            set { ballAttackThreeDamage = value; }
        }

        public string takeDamage(int amountDamage)
        {
            BallHealth -= amountDamage;

            if (BallHealth < 0)
            {
                return ballName + " has " + BallHealth + " Health left";
            }
            else
            {
                return ballName + " is dead";
            }
        }

        public int getAttackParameters(string attackName)
        {
            if (attackName == ballAttackOneName)
            {
                return BallAttackOneDamage;
            }
            if (attackName == ballAttackTwoName)
            {
                return BallAttackTwoDamage;
            }
            if (attackName == ballAttackThreeName)
            {
                return BallAttackThreeDamage;
            }
            else
            {
                return 0;
            }
        }
    }
}
