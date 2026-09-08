using UnityEngine;
using System.Collections.Generic;
using System.Collections;

namespace Assignment
{
    public class Lecture : MonoBehaviour
    {
        public void Start()
        {
            // LCT01_SyntaxList();
            // LCT02_SyntaxLinkedList();
            // LCT03_SyntaxHashTable();
             LCT04_SyntaxDictionary();
        }

        #region Lecture

        public void LCT01_SyntaxList()
        {

            throw new System.NotImplementedException();
        }

        public void LCT02_SyntaxLinkedList()
        {
            LinkedList<string> linkList = new LinkedList<string>();

            linkList.AddLast("Node_1");

            linkList.AddLast("Node_2");

            linkList.AddFirst("Node_0");

            LinkedListNode<string> firstNode = linkList.First;
            Debug.Log($"first : {firstNode.Value}");

            LinkedListNode<string> lasrNode = linkList.Last;
            Debug.Log($"last : {lasrNode.Value}");

            Debug.Log($"first next : {firstNode.Next.Value}");
            Debug.Log($"first next next : {firstNode.Next.Next.Value}");

            Debug.Log($"last Previous: {lasrNode.Previous.Value}");
            Debug.Log($"last Previous Previous: {lasrNode.Previous.Previous.Value}");
            //Debug.Log($"last Previous Previous Previous: {lasrNode.Previous.Previous.Previous.Value}");

            if (firstNode.Previous == null) Debug.Log("firstNode.Previous == null");
            if (lasrNode.Next == null) Debug.Log("firstNode.Next == null");

            linkList.AddAfter(firstNode, "Node_0.5");
            linkList.AddBefore(lasrNode, "Node_1.5");

            LinkedListNode<string> node1 = linkList.Find("Node_1"); //if more than 1 node find will send first node found

            foreach (string list in linkList)
            {
                Debug.Log(list);
            }

            linkList.Remove("Node_1");
            linkList.Remove(node1);
            linkList.RemoveLast();
            linkList.RemoveFirst();

            linkList.Clear();
           
        }

        public void LCT03_SyntaxHashTable()
        {
            Hashtable table = new Hashtable();
            table.Add("Potion", 1);
            table.Add(true, "");
            table.Add(0, 0);
            table[true] = 1;
        }

        public void LCT04_SyntaxDictionary()
        {
            Dictionary<string, int> inv = new Dictionary<string, int>();
            var inv2 = new Dictionary<string, int>();

            inv.Add("Potion", 1);

            inv.Add("Apple", 10);

            inv["Banana"] = 5;

            inv["Potion"] = 10;

            var pickupItem = "Sword";
            inv[pickupItem] = 1;

            foreach (var pair in inv) 
            {
                string key = pair.Key;
                int value = pair.Value;

                Debug.Log($"Key: {key} value: {value}");

            }

            var appleExists = inv.ContainsKey("Apple");
            Debug.Log(appleExists);

            var keyExists = inv.ContainsKey("Key");
            Debug.Log(keyExists);

            inv.Remove("Apple");

            foreach (var pair in inv)
            {
                string key = pair.Key;
                int value = pair.Value;

                Debug.Log($"Key: {key} value: {value}");

            }


        }

        #endregion
    }
}
