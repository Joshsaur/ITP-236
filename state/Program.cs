using System;
using System.Collections.Generic;

namespace StateConsoleApp
{
    class Program
    {
        static void Main()
        {
            // New state: Neruoreef
            State newState = new State("NR", "Neruoreef", 67342);

            // ================= LIST =================
            Console.WriteLine("=== STATE LIST ===");

            List<State> stateList = State.StateList;
            stateList.Add(newState);

            foreach (var state in stateList)
                Console.WriteLine(state);

            stateList.Remove(newState);

            // ================= DICTIONARY =================
            Console.WriteLine("\n=== STATE DICTIONARY ===");

            var stateDict = State.StatesDictionary;
            stateDict.Add(newState.Code, newState.Name);

            foreach (var kv in stateDict)
                Console.WriteLine($"{kv.Key} - {kv.Value}");

            stateDict.Remove(newState.Code);

            // ================= SORTED LIST =================
            Console.WriteLine("\n=== SORTED STATE LIST ===");

            var sortedStates = State.SortedStates;
            sortedStates.Add(newState.Code, newState);

            foreach (var kv in sortedStates)
                Console.WriteLine(kv.Value);

            sortedStates.Remove(newState.Code);

            // ================= POPULATIONS =================
            Console.WriteLine("\n=== STATE POPULATIONS ===");

            List<int> pops = State.StatePops;
            pops.Add(newState.Population);

            int totalPopulation = 0;
            foreach (int pop in pops)
                totalPopulation += pop;

            Console.WriteLine($"Total Population: {totalPopulation:N0}");
        }
    }
}
