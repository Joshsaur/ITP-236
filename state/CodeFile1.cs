using System;
using System.Collections.Generic;
using System.Linq;

namespace StateConsoleApp
{
    public class State
    {
        public string Code { get; }
        public string Name { get; }
        public int Population { get; }

        public State(string code, string name, int population)
        {
            Code = code;
            Name = name;
            Population = population;
        }

        // --- Base data: 50 states ---
        private static State[] _states =
        {
            new State("AL","Alabama",5024279),
            new State("AK","Alaska",733391),
            new State("AZ","Arizona",7151502),
            new State("AR","Arkansas",3011524),
            new State("CA","California",39538223),
            new State("CO","Colorado",5773714),
            new State("CT","Connecticut",3605944),
            new State("DE","Delaware",989948),
            new State("FL","Florida",21538187),
            new State("GA","Georgia",10711908),
            new State("HI","Hawaii",1455271),
            new State("ID","Idaho",1839106),
            new State("IL","Illinois",12812508),
            new State("IN","Indiana",6785528),
            new State("IA","Iowa",3190369),
            new State("KS","Kansas",2937880),
            new State("KY","Kentucky",4505836),
            new State("LA","Louisiana",4657757),
            new State("ME","Maine",1362359),
            new State("MD","Maryland",6177224),
            new State("MA","Massachusetts",7029917),
            new State("MI","Michigan",10077331),
            new State("MN","Minnesota",5706494),
            new State("MS","Mississippi",2961279),
            new State("MO","Missouri",6154913),
            new State("MT","Montana",1084225),
            new State("NE","Nebraska",1961504),
            new State("NV","Nevada",3104614),
            new State("NH","New Hampshire",1377529),
            new State("NJ","New Jersey",9288994),
            new State("NM","New Mexico",2117522),
            new State("NY","New York",20201249),
            new State("NC","North Carolina",10439388),
            new State("ND","North Dakota",779094),
            new State("OH","Ohio",11799448),
            new State("OK","Oklahoma",3959353),
            new State("OR","Oregon",4237256),
            new State("PA","Pennsylvania",13002700),
            new State("RI","Rhode Island",1097379),
            new State("SC","South Carolina",5118425),
            new State("SD","South Dakota",886667),
            new State("TN","Tennessee",6910840),
            new State("TX","Texas",29145505),
            new State("UT","Utah",3271616),
            new State("VT","Vermont",643077),
            new State("VA","Virginia",8631393),
            new State("WA","Washington",7705281),
            new State("WV","West Virginia",1793716),
            new State("WI","Wisconsin",5893718),
            new State("WY","Wyoming",576851)
        };

        // --- Required collections ---

        public static List<State> StateList =>
            new List<State>(_states);

        public static SortedDictionary<string, string> StatesDictionary =>
            new SortedDictionary<string, string>(
                _states.ToDictionary(s => s.Code, s => s.Name));

        public static SortedList<string, State> SortedStates =>
            new SortedList<string, State>(
                _states.ToDictionary(s => s.Code, s => s));

        public static List<int> StatePops =>
            _states.Select(s => s.Population).ToList();

        public override string ToString()
        {
            return $"{Code} - {Name} : {Population:N0}";
        }
    }
}
