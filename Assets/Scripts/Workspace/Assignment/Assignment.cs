using UnityEngine;
using System.Collections.Generic;
using Unity.VisualScripting;

namespace Assignment
{
    public class Assignment : MonoBehaviour
    {
        public void Start()
        {
            // AS01_CountWords();
            // AS02_CountNumber();
            // AS03_CheckValidBrackets();
            // AS04_PrintReverseLinkedList();
            // AS05_FindMiddleElement();
            // AS06_MergeDictionaries();
            // AS07_RemoveDuplicatesFromLinkedList();
            // AS08_TopFrequentNumber();
            // AS09_PlayerInventory();
             AS10_GameEventQueue();
            // AS11_PlayerStatsTracker();
        }

        #region Assignment

        [Header("AS01 - Count Words")]
        [SerializeField] private string[] as01Words;

        public void AS01_CountWords()
        {
            string[] words = as01Words;
            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            foreach (string word in words) 
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word] += 1;
                }
                else 
                {
                    wordCount.Add(word, 1);
                }
            }

            foreach (KeyValuePair<string, int> pair in wordCount) 
            {
                string key = pair.Key;
                int value = pair.Value;

                Debug.Log($"word: '{key}' count: {value}");
            }
        }

        [Header("AS02 - Count Number")]
        [SerializeField] private int[] as02Numbers;

        public void AS02_CountNumber()
        {
            int[] numbers = as02Numbers;
            Dictionary<int, int> numberCount = new Dictionary<int, int>();

            foreach (int number in numbers)
            {
                if (numberCount.ContainsKey(number))
                {
                    numberCount[number] += 1;
                }
                else
                {
                    numberCount.Add(number, 1);
                }
            }

            foreach (KeyValuePair<int, int> pair in numberCount)
            {
                int key = pair.Key;
                int value = pair.Value;

                Debug.Log($"number: {key} count: {value}");
            }
        }

        [Header("AS03 - Check Valid Brackets")]
        [SerializeField] private string as03Input;

        public void AS03_CheckValidBrackets()
        {
            string input = as03Input;
            string output = "unCheck";

            LinkedList<char> stack = new LinkedList<char>();

            foreach (char c in input)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.AddLast(c);
                }
                else if (c == ')' || c == ']' || c == '}') 
                {
                    if (stack.Count == 0)
                    {
                        output = "Invalid";
                        //Debug.Log("each");
                        break;
                    }

                    stack.AddLast(c);
                }
            }


            while (stack.Count > 0) 
            {
                LinkedListNode<char> firstNode = stack.First;
                LinkedListNode<char> lastNode = stack.Last;

                if (firstNode.Value == '(' && lastNode.Value == ')')
                {
                    stack.RemoveLast();
                    stack.RemoveFirst();
                    output = "Valid";
                }
                else if (firstNode.Value == '[' && lastNode.Value == ']')
                {
                    stack.RemoveLast();
                    stack.RemoveFirst();
                    output = "Valid";
                }
                else if (firstNode.Value == '{' && lastNode.Value == '}')
                {
                    stack.RemoveLast();
                    stack.RemoveFirst();
                    output = "Valid";
                }
                else 
                {
                    //Debug.Log(firstNode.Value);
                    //Debug.Log(lastNode.Value);
                    output = "Invalid";
                    break;
                }
            }

            if (stack.Count <= 0 && !(output == "Invalid")) 
            {
                output = "Valid";
            }

            Debug.Log(output);

            


        }

        [Header("AS04 - Print Reverse Linked List")]
        [SerializeField] private IntLinkedListInput as04List = new IntLinkedListInput();

        public void AS04_PrintReverseLinkedList()
        {
            LinkedList<int> list = as04List.GetLinkedList();

            if (list.Count == 0)
            {
                Debug.Log("List is empty");
            }
            else 
            {
                var currentNode = list.Last;
                while (currentNode != null) 
                {
                    Debug.Log($"{currentNode.Value}");
                    currentNode = currentNode.Previous;
                }
            }

        }

        [Header("AS05 - Find Middle Element")]
        [SerializeField] private StringLinkedListInput as05List = new StringLinkedListInput();

        public void AS05_FindMiddleElement()
        {
            LinkedList<string> list = as05List.GetLinkedList();

            LinkedListNode<string> slow = list.First;
            LinkedListNode<string> fast = list.First;

            while (slow != null || fast != null) 
            {
                if (fast.Next != null)
                {
                    slow = slow.Next;
                    fast = fast.Next;
                    if (fast.Next != null) 
                    {
                        fast = fast.Next;
                    }
                    else 
                    {
                        break;
                    }
                }
                else 
                {
                    break;
                    
                }
                
            }

            Debug.Log($"{slow.Value}");

        }

        [Header("AS06 - Merge Dictionaries")]
        [SerializeField] private StringIntDictionaryInput as06FirstDictionary = new StringIntDictionaryInput();
        [SerializeField] private StringIntDictionaryInput as06SecondDictionary = new StringIntDictionaryInput();

        public void AS06_MergeDictionaries()
        {
            Dictionary<string, int> dict1 = as06FirstDictionary.GetDictionary();
            Dictionary<string, int> dict2 = as06SecondDictionary.GetDictionary();

            Dictionary<string, int> dic3 = new Dictionary<string, int>(dict1);

            foreach(var pair in dict2) 
            {
                if (dic3.ContainsKey(pair.Key))
                {
                    dic3[pair.Key] += pair.Value;
                }
                else 
                {
                    dic3[pair.Key] = pair.Value;
                }
            }

            foreach (var pair in dic3)
            {
                Debug.Log($"Key : {pair.Key} | Value : {pair.Value}");
            }

        }

        [Header("AS07 - Remove Duplicates From Linked List")]
        [SerializeField] private IntLinkedListInput as07List = new IntLinkedListInput();

        public void AS07_RemoveDuplicatesFromLinkedList()
        {
            LinkedList<int> lists = as07List.GetLinkedList();
            Dictionary<int, int> countList = new Dictionary<int, int>();

            foreach (int list in lists) 
            {
                if (countList.ContainsKey(list))
                {
                    countList[list] += 1;
                }
                else 
                {
                    countList[list] = 1;
                }
            }

            foreach (var pair in countList) 
            {
                Debug.Log($"{pair.Key}");
            }


        }

        [Header("AS08 - Top Frequent Number")]
        [SerializeField] private int[] as08Numbers;

        public void AS08_TopFrequentNumber()
        {
            int[] numbers = as08Numbers;
            Dictionary<int, int> countNumber = new Dictionary<int, int>();

            if (numbers.Length != 0) 
            { 
                foreach (int number in numbers)
                {
                    if (countNumber.ContainsKey(number))
                    {
                        countNumber[number] += 1;
                    }
                    else
                    {
                        countNumber[number] = 1;
                    }
                }

                int hightestNumber = 0;
                int hightestNumberCount = 0;

            
            
                foreach (var pair in countNumber)
                {
                    if (pair.Value > hightestNumberCount)
                    {
                        hightestNumber = pair.Key;
                        hightestNumberCount = pair.Value;
                    }
                }

                Debug.Log($"{hightestNumber} | count : {hightestNumberCount}");
            }
            else 
            {
                 Debug.Log($"Input array is empty");

            }
            

        }

        [Header("AS09 - Player Inventory")]
        [SerializeField] private StringIntDictionaryInput as09Inventory = new StringIntDictionaryInput();
        [SerializeField] private string as09ItemName;
        [SerializeField] private int as09Quantity;

        public void AS09_PlayerInventory()
        {
            Dictionary<string, int> inventory = as09Inventory.GetDictionary();
            string itemName = as09ItemName;
            int quantity = as09Quantity;


            if (inventory.ContainsKey(itemName))
            {
                inventory[itemName] += quantity;
            }
            else 
            {
                inventory[itemName] = quantity;
            }

            foreach (var item in inventory) 
            {
                Debug.Log($"Item : {item.Key} | {item.Value}");
            }

        }

        [Header("AS10 - Game Event Queue")]
        [SerializeField] private GameEventLinkedListInput as10EventQueue = new GameEventLinkedListInput();

        public void AS10_GameEventQueue()
        {
            LinkedList<GameEvent> eventQueue = as10EventQueue.GetLinkedList();

            if (eventQueue.Count <= 0) 
            {
                Debug.Log($"Event queue is empty");
            }
            else 
            {
                LinkedListNode<GameEvent> CurrentEvent = eventQueue.First;
                
                while (eventQueue.Count > 0) 
                {
                    CurrentEvent = eventQueue.First;
                    Debug.Log($"Processing event: {eventQueue.First.Value.Name}");

                    eventQueue.RemoveFirst();

                    Debug.Log($"Remaining events in queue: {eventQueue.Count}");
                    Debug.Log($"{CurrentEvent.Value.EventType} event processed - {CurrentEvent.Value.Name}");
                }
            }

        }

        [Header("AS11 - Player Stats Tracker")]
        [SerializeField] private StringIntDictionaryInput as11PlayerStats = new StringIntDictionaryInput();
        [SerializeField] private string as11StatName;
        [SerializeField] private int as11Value;

        public void AS11_PlayerStatsTracker()
        {
            Dictionary<string, int> playerStats = as11PlayerStats.GetDictionary();
            string statName = as11StatName;
            int value = as11Value;

            if (playerStats.ContainsKey(statName)) 
            {
                playerStats[statName] += value;
            }
            else 
            {
                playerStats[statName] = value;
            }

            Debug.Log($"Updated {statName}: {playerStats[statName]}");
            Debug.Log($"Current player statistics:");

            foreach(var stat in playerStats) 
            {
                Debug.Log($"{stat.Key}: {stat.Value}");
            }


        }

        #endregion
    }
}
