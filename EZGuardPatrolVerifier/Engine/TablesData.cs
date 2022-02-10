using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZGuardPatrolVerifier.Engine
{
    public class TablesData
    {
        private static SortedDictionary<String, bool> m_PatrolPoints = new SortedDictionary<String, bool>();

        public TablesData()
        {
            m_PatrolPoints = new SortedDictionary<String, bool>();
        }

        public static SortedDictionary<String, bool> GetRothPoints(ePatrolHour patrolHour)
        {
            if (patrolHour == ePatrolHour.Full)
            {
                m_PatrolPoints.Add("13SE open space", false);
                m_PatrolPoints.Add("13W Micro-Kitchen", false);
                m_PatrolPoints.Add("-5 Storage", false);
                m_PatrolPoints.Add("21W Oil room", false);
                m_PatrolPoints.Add("22E IT storage", false);
                m_PatrolPoints.Add("23E Kosher Kitchen", false);
                m_PatrolPoints.Add("23W Main Kitchen", false);
            }

            //13
            m_PatrolPoints.Add("13W IDF/MDF", false);
            m_PatrolPoints.Add("13 Events room", false);
            m_PatrolPoints.Add("13E AV rooms", false);
            m_PatrolPoints.Add("13E Badges Box", false);
            m_PatrolPoints.Add("13E Micro-Kitchen", false);

            //21
            m_PatrolPoints.Add("21 Elevators lobby", false);
            m_PatrolPoints.Add("21SE open space", false);
            m_PatrolPoints.Add("21 FCS room", false);
            m_PatrolPoints.Add("21W Bar", false);

            //22
            m_PatrolPoints.Add("22SE open space", false);
            m_PatrolPoints.Add("22E Printer", false);
            m_PatrolPoints.Add("22 Dispatch room", false);
            m_PatrolPoints.Add("22W micro-kitchen", false);
            m_PatrolPoints.Add("22 Elevators Toilets", false);
            m_PatrolPoints.Add("22W IDF/MDF", false);

            //23
            m_PatrolPoints.Add("23 Culinary room", false);
            m_PatrolPoints.Add("23W Ice cream", false);
            m_PatrolPoints.Add("23SE open space", false);
            m_PatrolPoints.Add("23E Micro-kitchen", false);
            m_PatrolPoints.Add("23E Printer", false);

            //24
            m_PatrolPoints.Add("24E Printer", false);
            m_PatrolPoints.Add("24SE open space", false);
            m_PatrolPoints.Add("24E Micro-Kitchen", false);
            m_PatrolPoints.Add("24 Cleaners room", false);
            m_PatrolPoints.Add("24W IDF/MDF", false);
            m_PatrolPoints.Add("24 Elevators lobby", false);

            //26
            m_PatrolPoints.Add("26N Terrace", false);
            m_PatrolPoints.Add("26S Terrace", false);
            m_PatrolPoints.Add("26 Storage room", false);

            //27
            m_PatrolPoints.Add("27W Emergency Door", false);
            m_PatrolPoints.Add("27W IDF/MDF", false);
            m_PatrolPoints.Add("27 LIVE ROOM", false);

            return m_PatrolPoints;
        }

        public static SortedDictionary<String, bool> GetSarPoints(ePatrolHour patrolHour)
        {
            if (patrolHour == ePatrolHour.Full)
            {
                m_PatrolPoints.Add("Toilet + storage (lobby)", false);
                m_PatrolPoints.Add("Elevator intercom (-1)", false);
                m_PatrolPoints.Add("Alon Tower corner (33)", false);
                m_PatrolPoints.Add("Hagag Tower corner (33)", false);
                m_PatrolPoints.Add("Azrieli Tower corner (33)", false);
                m_PatrolPoints.Add("Hagag tower corner (34)", false);
                m_PatrolPoints.Add("Alon Tower corner (34)", false);
                m_PatrolPoints.Add("Azrieli Tower corner (34)", false);
                m_PatrolPoints.Add("Hagag Tower corner (35)", false);
                m_PatrolPoints.Add("Alon Tower corner (35)", false);
                m_PatrolPoints.Add("Azrieli Tower corner (35)", false);
                m_PatrolPoints.Add("IT storage (36)", false);
                m_PatrolPoints.Add("Azrieli Tower corner (36)", false);
                m_PatrolPoints.Add("Alon tower corner (36)", false);
                m_PatrolPoints.Add("(Azrieli' corner (37", false);
                m_PatrolPoints.Add("Alon Tower corner (37)", false);
                m_PatrolPoints.Add("Hagag Tower corner (37)", false);
                m_PatrolPoints.Add("water boiler closet (37)", false);
            }

            //0G
            m_PatrolPoints.Add("bicycle storage (-2)", false);
            m_PatrolPoints.Add("bicycle storage (-4)", false);

            //33
            m_PatrolPoints.Add("Fire Door 33", false);
            m_PatrolPoints.Add("service elevator (33)", false);
            m_PatrolPoints.Add("south storage (33)", false);
            m_PatrolPoints.Add("electrical room (33)", false);
            m_PatrolPoints.Add("Printer (33)", false);
            m_PatrolPoints.Add("Nano Kitchen(33)", false);
            m_PatrolPoints.Add("IDF (33)", false);
            m_PatrolPoints.Add("North storage (33)", false);
            m_PatrolPoints.Add("Micro+Internal Elevator(33)", false);

            //34
            m_PatrolPoints.Add("Fire Door 34", false);
            m_PatrolPoints.Add("service elevator (34)", false);
            m_PatrolPoints.Add("electrical room (34)", false);
            m_PatrolPoints.Add("First Aid room+south storage (34)", false);
            m_PatrolPoints.Add("printer (34)", false);
            m_PatrolPoints.Add("Showers (34)", false);
            m_PatrolPoints.Add("Nano Kitchen (34)", false);
            m_PatrolPoints.Add("IDF (34)", false);
            m_PatrolPoints.Add("north storage (34)", false);
            m_PatrolPoints.Add("Micro kitchen + Internal elevator 34", false);
            m_PatrolPoints.Add("Defibrillator (34)", false);

            //35
            m_PatrolPoints.Add("Fire Door 35", false);
            m_PatrolPoints.Add("service elevator (35)", false);
            m_PatrolPoints.Add("electrical room - IT storage (35)", false);
            m_PatrolPoints.Add("Bar (35)", false);
            m_PatrolPoints.Add("south storage (35)", false);
            m_PatrolPoints.Add("printer (35)", false);
            m_PatrolPoints.Add("Showers (35)", false);
            m_PatrolPoints.Add("Nano Kitchen (35)", false);
            m_PatrolPoints.Add("IDF (35)", false);
            m_PatrolPoints.Add("north storage (35)", false);
            m_PatrolPoints.Add("Micro+Internal elevator(35)", false);

            //36
            m_PatrolPoints.Add("south storage (36)", false);
            m_PatrolPoints.Add("Fire Door 36", false);
            m_PatrolPoints.Add("Service Elevator(36)", false);
            m_PatrolPoints.Add("Elecrical room 36 (Event rack room)", false);
            m_PatrolPoints.Add("IT logistic room (36)", false);
            m_PatrolPoints.Add("Micro kitchen 36", false);
            m_PatrolPoints.Add("IDF 36", false);
            m_PatrolPoints.Add("Nano kitchen 36 (open space)", false);
            m_PatrolPoints.Add("printer (36)", false);
            m_PatrolPoints.Add("Event space (36)", false);

            //37
            m_PatrolPoints.Add("Non kosher storage (37)", false);
            m_PatrolPoints.Add("machinery room (37)", false);
            m_PatrolPoints.Add("kosher storage (37)", false);
            m_PatrolPoints.Add("service elevator (37)", false);
            m_PatrolPoints.Add("electrical room (37)", false);
            m_PatrolPoints.Add("Elevator Lobby 37", false);

            

            return m_PatrolPoints;
        }

        public static SortedDictionary<String, bool> GetJOHPoints(ePatrolHour patrolHour)
        {
            if (patrolHour == ePatrolHour.Full)
            {
                m_PatrolPoints.Add("1st Disabled", false);//
                m_PatrolPoints.Add("1st Ladies", false);//
                m_PatrolPoints.Add("1st Mens", false);//
                m_PatrolPoints.Add("1st Emer Door", false);//
                m_PatrolPoints.Add("1st Printer", false);//
                m_PatrolPoints.Add("1st IT", false);//
                m_PatrolPoints.Add("1st MR", false);//
                m_PatrolPoints.Add("1st Nano", false);//
                m_PatrolPoints.Add("2nd Disabled", false);//
                m_PatrolPoints.Add("2nd Ladies", false);//
                m_PatrolPoints.Add("2nd Mens", false);//
                m_PatrolPoints.Add("Micro", false);//
            }

            m_PatrolPoints.Add("Recep FP", false);//
            m_PatrolPoints.Add("Recep AED", false);//
            m_PatrolPoints.Add("Ex Emerg 1", false);//
            m_PatrolPoints.Add("Ex Emerg 2", false);//
            m_PatrolPoints.Add("Basement Exit", false);//
            m_PatrolPoints.Add("Base H2O Tanks", false);//
            m_PatrolPoints.Add("1st DB", false);//
            m_PatrolPoints.Add("1st Phase 2 Store", false);//
            m_PatrolPoints.Add("1st Phase 2 Emer", false);//
            m_PatrolPoints.Add("2nd DB", false);//
            m_PatrolPoints.Add("2nd Games", false);//
            m_PatrolPoints.Add("2nd Facil", false);//
            m_PatrolPoints.Add("2nd Emer", false);//
            m_PatrolPoints.Add("IDF", false);//
            m_PatrolPoints.Add("Training", false);//
            m_PatrolPoints.Add("Culinary", false);//
            m_PatrolPoints.Add("Instagram", false);//
            m_PatrolPoints.Add("BBQ", false);//
            m_PatrolPoints.Add("Terrace Emer", false);
            m_PatrolPoints.Add("Roof IDF Aircons", false);//
            m_PatrolPoints.Add("Roof Culi Aircon", false);//

            return m_PatrolPoints;
        }

        public static SortedDictionary<String, bool> GetNoviPoints(ePatrolHour patrolHour)
        {
            if (patrolHour == ePatrolHour.Full)
            {
                m_PatrolPoints.Add("Alon Tower 31", false);
                m_PatrolPoints.Add("Hagag Tower 31", false);
                m_PatrolPoints.Add("Azrieli corner 31", false);
                m_PatrolPoints.Add("Hagag Tower corner 32", false);
                m_PatrolPoints.Add("Azrieli Corner 32", false);
                m_PatrolPoints.Add("Alon Tower corner 32", false);
            }

            //31
            m_PatrolPoints.Add("31 Printer", false);
            m_PatrolPoints.Add("North storage 31", false);
            m_PatrolPoints.Add("Service Elevator 31", false);
            m_PatrolPoints.Add("Electrical Room  31", false);
            m_PatrolPoints.Add("Fire Door 31", false);
            m_PatrolPoints.Add("South storage 31", false);
            m_PatrolPoints.Add("Nano Kitchen 31", false);
            m_PatrolPoints.Add("IDF-31", false);
            m_PatrolPoints.Add("Micro 31", false);

            //32
            m_PatrolPoints.Add("Printer 32", false);
            m_PatrolPoints.Add("North storage 32", false);
            m_PatrolPoints.Add("Service Elevator 32", false);
            m_PatrolPoints.Add("Fire Door 32", false);
            m_PatrolPoints.Add("Electrical Room 32", false);
            m_PatrolPoints.Add("South storage 32", false);
            m_PatrolPoints.Add("Showers 32", false);
            m_PatrolPoints.Add("Nano Kitchen 32", false);
            m_PatrolPoints.Add("Defibrillator 32", false);
            m_PatrolPoints.Add("IDFs 32", false);
            m_PatrolPoints.Add("Micro Kitchen  32", false);

            return m_PatrolPoints;
        }

        public static SortedDictionary<String, bool> Get46To50Points(ePatrolHour patrolHour)
        {
            if (patrolHour == ePatrolHour.Full)
            {
                m_PatrolPoints.Add("Hagag Tower corner 46", false);
                m_PatrolPoints.Add("Alon Tower corner 46", false);
                m_PatrolPoints.Add("Azrieli Corner 46", false);
                m_PatrolPoints.Add("Reality Lab 46", false);  //Maybe changed
                m_PatrolPoints.Add("Hagag Tower corner (47)", false);
                m_PatrolPoints.Add("(Azrieli' corner (47", false);
                m_PatrolPoints.Add("Alon Tower corner (47)", false);
                m_PatrolPoints.Add("Alon Tower corner (48)", false);
                m_PatrolPoints.Add("Hagag Tower corner (48)", false);
                m_PatrolPoints.Add("(Azrieli' corner (48)", false);
                m_PatrolPoints.Add("Hagag Tower corner (49)", false);
                m_PatrolPoints.Add("(Azrieli' corner (49", false);
                m_PatrolPoints.Add("Alon Tower corner (49)", false);
                m_PatrolPoints.Add("(Azrieli' corner (50", false);
                m_PatrolPoints.Add("Hagag Tower corner (50)", false);
                m_PatrolPoints.Add("Alon Tower corner (50)", false);
            }

            //46
            m_PatrolPoints.Add("North storage 46", false);
            m_PatrolPoints.Add("Service Elevator 46", false);
            m_PatrolPoints.Add("Lockers Room 46", false);
            m_PatrolPoints.Add("Fire Door  46", false);
            m_PatrolPoints.Add("South storage 46", false);
            m_PatrolPoints.Add("Defibrillator 46", false);
            m_PatrolPoints.Add("Printer 46", false);
            m_PatrolPoints.Add("Nano Kitchen 46", false);
            m_PatrolPoints.Add("IDFs 46", false);
            m_PatrolPoints.Add("Mikro Kitchen 46", false);

            //47
            m_PatrolPoints.Add("North storage (47)", false);
            m_PatrolPoints.Add("service elevator (47)", false);
            m_PatrolPoints.Add("Electrical Room (47)", false);
            m_PatrolPoints.Add("fire door (47)", false);
            m_PatrolPoints.Add("south storage (47)", false);
            m_PatrolPoints.Add("Printer (47)", false);
            m_PatrolPoints.Add("Showers (47)", false);
            m_PatrolPoints.Add("Micro Kitchen (47)", false);

            //48
            m_PatrolPoints.Add("North storage (48)", false);
            m_PatrolPoints.Add("service elevator (48)", false);
            m_PatrolPoints.Add("Electrical Room (48)", false);
            m_PatrolPoints.Add("fire door (48)", false);
            m_PatrolPoints.Add("IT south storage (48)", false);
            m_PatrolPoints.Add("IDF (48)", false);
            m_PatrolPoints.Add("Micro Kitchen (48)", false);
            m_PatrolPoints.Add("(48) Defibrillator + Printer", false);

            //49
            m_PatrolPoints.Add("North storage (49)", false);
            m_PatrolPoints.Add("south storage (49)", false);
            m_PatrolPoints.Add("service elevator (49)", false);
            m_PatrolPoints.Add("fire door (49)", false);
            m_PatrolPoints.Add("Electrical Room (49)", false);
            m_PatrolPoints.Add("Printer (49)", false);
            m_PatrolPoints.Add("Showers (49)", false);
            m_PatrolPoints.Add("Micro Kitchen (49)", false);

            //50
            m_PatrolPoints.Add("North storage (50)", false);
            m_PatrolPoints.Add("service elevator (50)", false);
            m_PatrolPoints.Add("Electrical Room + IDF (50)", false);
            m_PatrolPoints.Add("fire door (50)", false);
            m_PatrolPoints.Add("Micro Kitchen (50)", false);
            m_PatrolPoints.Add("(50) Defibrillator + Printer", false);

            return m_PatrolPoints;
        }

        public static SortedDictionary<String, bool> GetT31Points()
        {
            //0G
            m_PatrolPoints.Add("bicycle storage (-2)", false);
            m_PatrolPoints.Add("bicycle storage (-4)", false);

            //31
            m_PatrolPoints.Add("South storage 31", false);
            m_PatrolPoints.Add("North storage 31", false);
            m_PatrolPoints.Add("Electrical Room  31", false);
            m_PatrolPoints.Add("Fire Door 31", false);
            m_PatrolPoints.Add("Service Elevator 31", false);

            //32
            m_PatrolPoints.Add("South storage 32", false);
            m_PatrolPoints.Add("North storage 32", false);
            m_PatrolPoints.Add("Electrical Room 32", false);
            m_PatrolPoints.Add("Fire Door 32", false);
            m_PatrolPoints.Add("Service Elevator 32", false);

            //33
            m_PatrolPoints.Add("south storage (33)", false);
            m_PatrolPoints.Add("North storage (33)", false);
            m_PatrolPoints.Add("electrical room (33)", false);
            m_PatrolPoints.Add("Fire Door 33", false);
            m_PatrolPoints.Add("service elevator (33)", false);

            //34
            m_PatrolPoints.Add("First Aid room+south storage (34)", false);
            m_PatrolPoints.Add("north storage (34)", false);
            m_PatrolPoints.Add("electrical room (34)", false);
            m_PatrolPoints.Add("Fire Door 34", false);
            m_PatrolPoints.Add("service elevator (34)", false);

            //35
            m_PatrolPoints.Add("south storage (35)", false);
            m_PatrolPoints.Add("north storage (35)", false);
            m_PatrolPoints.Add("electrical room - IT storage (35)", false);
            m_PatrolPoints.Add("Fire Door 35", false);
            m_PatrolPoints.Add("service elevator (35)", false);

            //36
            m_PatrolPoints.Add("south storage (36)", false);
            m_PatrolPoints.Add("IT logistic room (36)", false);
            m_PatrolPoints.Add("Elecrical room 36 (Event rack room)", false);
            m_PatrolPoints.Add("Fire Door 36", false);
            m_PatrolPoints.Add("Service Elevator(36)", false);

            //37
            m_PatrolPoints.Add("Non kosher storage (37)", false);
            m_PatrolPoints.Add("kosher storage (37)", false);
            m_PatrolPoints.Add("electrical room (37)", false);
            m_PatrolPoints.Add("Elevator Lobby 37", false);
            m_PatrolPoints.Add("service elevator (37)", false);

            return m_PatrolPoints;
        }

        public static SortedDictionary<String, bool> GetT46Points()
        {
            //46
            m_PatrolPoints.Add("South storage 46", false);
            m_PatrolPoints.Add("North storage 46", false);
            m_PatrolPoints.Add("Lockers Room 46", false);
            m_PatrolPoints.Add("Fire Door  46", false);
            m_PatrolPoints.Add("Service Elevator 46", false);

            //47
            m_PatrolPoints.Add("south storage (47)", false);
            m_PatrolPoints.Add("North storage (47)", false);
            m_PatrolPoints.Add("Electrical Room (47)", false);
            m_PatrolPoints.Add("fire door (47)", false);
            m_PatrolPoints.Add("service elevator (47)", false);

            //48
            m_PatrolPoints.Add("IT south storage (48)", false);
            m_PatrolPoints.Add("North storage (48)", false);
            m_PatrolPoints.Add("Electrical Room (48)", false);
            m_PatrolPoints.Add("fire door (48)", false);
            m_PatrolPoints.Add("service elevator (48)", false);

            //49
            m_PatrolPoints.Add("south storage (49)", false);
            m_PatrolPoints.Add("North storage (49)", false);
            m_PatrolPoints.Add("Electrical Room (49)", false);
            m_PatrolPoints.Add("fire door (49)", false);
            m_PatrolPoints.Add("service elevator (49)", false);

            //50
            m_PatrolPoints.Add("North storage (50)", false);
            m_PatrolPoints.Add("Electrical Room + IDF (50)", false);
            m_PatrolPoints.Add("fire door (50)", false);
            m_PatrolPoints.Add("service elevator (50)", false);

            return m_PatrolPoints;
        }
    }
}
