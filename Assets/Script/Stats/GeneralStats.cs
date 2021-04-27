using UnityEditor;
using UnityEngine;

namespace Script.Stats
{
    public class GeneralStats //: GenericMonoBehaviourSingleton<GeneralStats>
    {
        private PlayerStats m_playerStats;
        public PlayerStats PlayerStats => m_playerStats;

        private static GeneralStats m_instance = null;
        public static GeneralStats Instance
        {
            get
            {
                if (m_instance == null)
                {
                    m_instance = new GeneralStats();
                    Instance.CreateInstance();
                }

                return m_instance;
            }
        }

        public void CreateInstance()
        {
            m_playerStats = Resources.Load<PlayerStats>("PlayerData");
        }
    }
}
